using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaLibreria
{
    public partial class HistorialDeUsuarios : Form
    {
        private List<Devolucion> listaDevoluciones = new List<Devolucion>();
        private string archivoDevoluciones = "devoluciones.txt";
        private string archivoPrestamos = "prestamos.txt";
        private string archivoUsuarios = "usuarios.txt";
        private string archivoLibros = "libros.txt";
        private int indiceEditando = -1;

        public HistorialDeUsuarios()
        {
            InitializeComponent();
            CargarCombos();
            CargarDevolucionesGuardadas();
        }

        private void CargarCombos()
        {
            cmbUsuario.Items.Clear();
            cmbLibro.Items.Clear();

            if (File.Exists(archivoUsuarios))
            {
                foreach (string linea in File.ReadAllLines(archivoUsuarios))
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Usuario u = Usuario.DesdeTexto(linea);
                        if (u != null) cmbUsuario.Items.Add($"{u.Nombre} {u.Apellido} | {u.Rut}");
                    }
                }
            }

            if (File.Exists(archivoLibros))
            {
                foreach (string linea in File.ReadAllLines(archivoLibros))
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Libros l = Libros.DesdeTexto(linea);
                        if (l != null) cmbLibro.Items.Add($"{l.Titulo} | {l.Codigo}");
                    }
                }
            }
        }

        private void CargarDevolucionesGuardadas()
        {
            listaDevoluciones.Clear();
            if (File.Exists(archivoDevoluciones))
            {
                foreach (string linea in File.ReadAllLines(archivoDevoluciones))
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Devolucion d = Devolucion.DesdeTexto(linea);
                        if (d != null) listaDevoluciones.Add(d);
                    }
                }
            }
            ActualizarGrid();
        }

        private DateTime? BuscarFechaPrestamo(string rutUsuario, string codigoLibro)
        {
            if (!File.Exists(archivoPrestamos)) return null;

            string[] lineas = File.ReadAllLines(archivoPrestamos);

            for (int i = lineas.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(lineas[i]))
                {
                    Prestamos p = Prestamos.DesdeTexto(lineas[i]);
                    if (p != null)
                    {
                        if (p.RutUsuario == rutUsuario && p.CodigoLibro == codigoLibro)
                        {
                            return p.FechaPrestamo;
                        }
                    }
                }
            }
            return null;
        }

        private void EliminarPrestamoDeArchivo(string rutUsuario, string codigoLibro)
        {
            if (!File.Exists(archivoPrestamos)) return;

            List<string> lineasActualizadas = new List<string>();
            string[] lineas = File.ReadAllLines(archivoPrestamos);

            foreach (string linea in lineas)
            {
                if (!string.IsNullOrWhiteSpace(linea))
                {
                    Prestamos p = Prestamos.DesdeTexto(linea);
                    
                    if (p != null && !(p.RutUsuario == rutUsuario && p.CodigoLibro == codigoLibro))
                    {
                        lineasActualizadas.Add(linea);
                    }
                }
            }

           
            File.WriteAllLines(archivoPrestamos, lineasActualizadas);
        }

        private void GuardarDevoluciones()
        {
            List<string> lineas = new List<string>();
            foreach (Devolucion d in listaDevoluciones)
            {
                lineas.Add(d.ATexto());
            }
            File.WriteAllLines(archivoDevoluciones, lineas);
        }

        private void ActualizarGrid()
        {
            dgvDevolucion.Rows.Clear();
            foreach (Devolucion d in listaDevoluciones)
            {
                dgvDevolucion.Rows.Add(
                    d.CodigoDevolucion,
                    d.NombreUsuario,
                    d.RutUsuario,
                    d.NombreLibro,
                    d.CodigoLibro,
                    d.FechaPrestamoOriginal.ToShortDateString(),
                    d.FechaDevolucionReal.ToShortDateString()
                );
            }
        }

        private void LimpiarCampos()
        {
            cmbUsuario.SelectedIndex = -1;
            cmbUsuario.Text = "";
            cmbLibro.SelectedIndex = -1;
            cmbLibro.Text = "";
            dtpDevolucion.Value = DateTime.Now;

            indiceEditando = -1;
            btnAgregar.Text = "Agregar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            if (cmbUsuario.SelectedIndex == -1 || cmbLibro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Usuario y un Libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDevolucion.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior al día de hoy.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionUsuario = cmbUsuario.Text;
            string[] partesUsuario = seleccionUsuario.Split('|');

            if (partesUsuario.Length < 2)
            {
                MessageBox.Show("El formato del usuario es incorrecto. Seleccione de la lista.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreUsuario = partesUsuario[0].Trim();
            string rutUsuario = partesUsuario[1].Trim();

            string seleccionLibro = cmbLibro.Text;
            string[] partesLibro = seleccionLibro.Split('|');

            if (partesLibro.Length < 2)
            {
                MessageBox.Show("El formato del libro es incorrecto. Seleccione de la lista.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreLibro = partesLibro[0].Trim();
            string codigoLibro = partesLibro[1].Trim();

            DateTime? fechaPrestamoOriginal = BuscarFechaPrestamo(rutUsuario, codigoLibro);

            if (fechaPrestamoOriginal == null)
            {
                MessageBox.Show("No se encontró un préstamo activo de este libro para este usuario.\nVerifique los datos.",
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpDevolucion.Value.Date < fechaPrestamoOriginal.Value.Date)
            {
                MessageBox.Show($"Error lógico: No puedes devolver el libro antes de la fecha en que se prestó.\nFecha Préstamo: {fechaPrestamoOriginal.Value.ToShortDateString()}",
                    "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (indiceEditando >= 0)
            {
               
                listaDevoluciones[indiceEditando].RutUsuario = rutUsuario;
                listaDevoluciones[indiceEditando].NombreUsuario = nombreUsuario;
                listaDevoluciones[indiceEditando].CodigoLibro = codigoLibro;
                listaDevoluciones[indiceEditando].NombreLibro = nombreLibro;
                listaDevoluciones[indiceEditando].FechaPrestamoOriginal = fechaPrestamoOriginal.Value;
                listaDevoluciones[indiceEditando].FechaDevolucionReal = dtpDevolucion.Value;

                MessageBox.Show("Devolución modificada correctamente.");
            }
            else
            {
               
                Random rnd = new Random();
                Devolucion nueva = new Devolucion
                {
                    CodigoDevolucion = "DEV-" + rnd.Next(1000, 9999),
                    RutUsuario = rutUsuario,
                    NombreUsuario = nombreUsuario,
                    CodigoLibro = codigoLibro,
                    NombreLibro = nombreLibro,
                    FechaPrestamoOriginal = fechaPrestamoOriginal.Value,
                    FechaDevolucionReal = dtpDevolucion.Value
                };

                listaDevoluciones.Add(nueva);

                EliminarPrestamoDeArchivo(rutUsuario, codigoLibro);

                MessageBox.Show("Devolución registrada correctamente y eliminada de préstamos pendientes.");
            }

            GuardarDevoluciones();
            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDevolucion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            indiceEditando = dgvDevolucion.SelectedRows[0].Index;
            Devolucion d = listaDevoluciones[indiceEditando];

            foreach (var item in cmbUsuario.Items)
            {
                if (item.ToString().Contains(d.RutUsuario))
                {
                    cmbUsuario.SelectedItem = item;
                    break;
                }
            }

            foreach (var item in cmbLibro.Items)
            {
                if (item.ToString().Contains(d.CodigoLibro))
                {
                    cmbLibro.SelectedItem = item;
                    break;
                }
            }

            dtpDevolucion.Value = d.FechaDevolucionReal;

            btnAgregar.Text = "Guardar Cambios";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDevolucion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro del historial?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = dgvDevolucion.SelectedRows[0].Index;
                listaDevoluciones.RemoveAt(indice);

                GuardarDevoluciones();
                ActualizarGrid();
                LimpiarCampos();
            }
        }
    }
}