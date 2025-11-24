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
    public partial class GestionDePrestamos : Form
    {
        private List<Prestamos> listaPrestamos = new List<Prestamos>(); 
        private int indiceEditando = -1;
        private string archivoPrestamos = "prestamos.txt";
        private string archivoUsuarios = "usuarios.txt";
        private string archivoLibros = "libros.txt";

        public GestionDePrestamos()
        {
            InitializeComponent();
            CargarCombos();
            CargarPrestamos();
        }

        private void CargarCombos()
        {
            cmbUsuario.Items.Clear();
            cmbLibro.Items.Clear();

            if (File.Exists(archivoUsuarios))
            {
                string[] lineas = File.ReadAllLines(archivoUsuarios);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Usuario u = Usuario.DesdeTexto(linea);
                        if (u != null)
                        {
                            cmbUsuario.Items.Add($"{u.Nombre} {u.Apellido} | {u.Rut}");
                        }
                    }
                }
            }

            if (File.Exists(archivoLibros))
            {
                string[] lineas = File.ReadAllLines(archivoLibros);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Libros l = Libros.DesdeTexto(linea);
                        if (l != null)
                        {
                            cmbLibro.Items.Add($"{l.Titulo} | {l.Codigo}");
                        }
                    }
                }
            }
        }

        private void CargarPrestamos()
        {
            listaPrestamos.Clear();
            if (File.Exists(archivoPrestamos))
            {
                string[] lineas = File.ReadAllLines(archivoPrestamos);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Prestamos p = Prestamos.DesdeTexto(linea);
                        if (p != null)
                        {
                            listaPrestamos.Add(p);
                        }
                    }
                }
            }
            ActualizarGrid();
        }

        private void GuardarPrestamosEnArchivo()
        {
            List<string> lineas = new List<string>();
            foreach (Prestamos p in listaPrestamos)
            {
                lineas.Add(p.ATexto());
            }
            File.WriteAllLines(archivoPrestamos, lineas);
        }

        private void ActualizarGrid()
        {
            dgvPrestamos.Rows.Clear();
            foreach (Prestamos p in listaPrestamos)
            {
                dgvPrestamos.Rows.Add(
                    p.CodigoPrestamo,
                    p.RutUsuario,
                    p.NombreUsuario,
                    p.CodigoLibro,
                    p.NombreLibro,
                    p.FechaPrestamo.ToShortDateString(),
                    p.FechaDevolucion.ToShortDateString()
                );
            }
        }

        private void LimpiarCampos()
        {
            cmbUsuario.SelectedIndex = -1;
            cmbUsuario.Text = "";
            cmbLibro.SelectedIndex = -1;
            cmbLibro.Text = "";
            dtpPrestamo.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now;

            indiceEditando = -1;
            btnAgregar.Text = "Agregar";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(cmbUsuario.Text) || string.IsNullOrWhiteSpace(cmbLibro.Text))
            {
                MessageBox.Show("Debe seleccionar un Usuario y un Libro de las listas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpPrestamo.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de préstamo no puede ser anterior al día de hoy.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDevolucion.Value.Date < dtpPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior a la fecha del préstamo.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string seleccionUsuario = cmbUsuario.Text;
            string[] partesUsuario = seleccionUsuario.Split('|');


            string nombreUsuario = partesUsuario[0].Trim();
            string rutUsuario = partesUsuario[1].Trim();

            string seleccionLibro = cmbLibro.Text;
            string[] partesLibro = seleccionLibro.Split('|');

       

            string nombreLibro = partesLibro[0].Trim();
            string codigoLibro = partesLibro[1].Trim();

            if (indiceEditando >= 0)
            {
              
                listaPrestamos[indiceEditando].RutUsuario = rutUsuario;
                listaPrestamos[indiceEditando].NombreUsuario = nombreUsuario;
                listaPrestamos[indiceEditando].CodigoLibro = codigoLibro;
                listaPrestamos[indiceEditando].NombreLibro = nombreLibro;
                listaPrestamos[indiceEditando].FechaPrestamo = dtpPrestamo.Value;
                listaPrestamos[indiceEditando].FechaDevolucion = dtpDevolucion.Value;

                MessageBox.Show("Préstamo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
       
                Random rnd = new Random();
                string codigoPrestamo = "P-" + rnd.Next(1000, 9999).ToString();

                Prestamos nuevo = new Prestamos
                {
                    CodigoPrestamo = codigoPrestamo,
                    NombreUsuario = nombreUsuario,
                    RutUsuario = rutUsuario,
                    NombreLibro = nombreLibro,
                    CodigoLibro = codigoLibro,
                    FechaPrestamo = dtpPrestamo.Value,
                    FechaDevolucion = dtpDevolucion.Value
                };

                listaPrestamos.Add(nuevo);
                MessageBox.Show($"Préstamo registrado. Código: {codigoPrestamo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            GuardarPrestamosEnArchivo();
            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un préstamo de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            indiceEditando = dgvPrestamos.SelectedRows[0].Index;
            Prestamos p = listaPrestamos[indiceEditando];
            cmbUsuario.Text = $"{p.NombreUsuario} | {p.RutUsuario}";
            cmbLibro.Text = $"{p.NombreLibro} | {p.CodigoLibro}";
            dtpPrestamo.Value = p.FechaPrestamo;
            dtpDevolucion.Value = p.FechaDevolucion;
            btnAgregar.Text = "Guardar Cambios";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un préstamo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este préstamo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = dgvPrestamos.SelectedRows[0].Index;
                listaPrestamos.RemoveAt(indice);

                GuardarPrestamosEnArchivo();
                ActualizarGrid();
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}