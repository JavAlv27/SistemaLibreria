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
    public partial class GestionDeUsuario : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private string archivoUsuarios = "usuarios.txt";
        private int indiceEditando = -1;

        public GestionDeUsuario()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            listaUsuarios.Clear();

            if (File.Exists(archivoUsuarios))
            {
                string[] lineas = File.ReadAllLines(archivoUsuarios);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Usuario u = Usuario.DesdeTexto(linea);
                        if (!string.IsNullOrEmpty(u.Nombre))
                        {
                            listaUsuarios.Add(u);
                        }
                    }
                }
            }
            ActualizarGrid();
        }

        private void GuardarUsuarios()
        {
            List<string> lineas = new List<string>();
            foreach (Usuario u in listaUsuarios)
            {
                lineas.Add(u.ATexto());
            }
            File.WriteAllLines(archivoUsuarios, lineas);
        }

        private void ActualizarGrid()
        {
            listaUsuarios.Sort((x, y) => string.Compare(x.Nombre, y.Nombre));
            dgvUsuarios.Rows.Clear();
            foreach (Usuario p in listaUsuarios)
            {
                int index = dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[index].Cells["dgvNombre"].Value = p.Nombre;
                dgvUsuarios.Rows[index].Cells["dgvApellido"].Value = p.Apellido;
                dgvUsuarios.Rows[index].Cells["dgvEdad"].Value = p.Edad.ToString();
                dgvUsuarios.Rows[index].Cells["dgvTelefono"].Value = p.Telefono.ToString();
                dgvUsuarios.Rows[index].Cells["dgvDireccion"].Value = p.Direccion;
                dgvUsuarios.Rows[index].Cells["dgvRut"].Value = p.Rut;
            }
        }

        private bool ValidarRutChileno(string rut)
        {
            rut = rut.Replace(".", "").ToUpper(); // Sacamos puntos y pasamos a mayúscula

            // Debe tener guion
            if (!rut.Contains("-")) return false;

            string[] partes = rut.Split('-');
            if (partes.Length != 2) return false;

            string cuerpo = partes[0];
            string dvIngresado = partes[1];

            // El cuerpo debe ser numérico
            if (!int.TryParse(cuerpo, out int rutNumerico)) return false;

            // Cálculo matemático del dígito verificador
            int suma = 0;
            int multiplicador = 2;

            for (int i = cuerpo.Length - 1; i >= 0; i--)
            {
                suma += int.Parse(cuerpo.Substring(i, 1)) * multiplicador;
                multiplicador++;
                if (multiplicador == 8) multiplicador = 2;
            }

            int resto = suma % 11;
            int resultado = 11 - resto;

            string dvCalculado;
            if (resultado == 11) dvCalculado = "0";
            else if (resultado == 10) dvCalculado = "K";
            else dvCalculado = resultado.ToString();

            return dvIngresado == dvCalculado;
        }

        private bool ValidarCampos()
        {
     
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("La edad debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (edad <= 12 || edad > 110)
            {
                MessageBox.Show("El usuario debe tener al menos 12 años para registrarse.", "Error Edad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string rut = txtRut.Text.Trim();
            if (string.IsNullOrWhiteSpace(rut))
            {
                MessageBox.Show("Ingrese el RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rut.Contains("-"))
            {
                MessageBox.Show("El RUT debe tener guion (Ej: 11111111-1).", "Formato RUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!ValidarRutChileno(rut))
            {
                MessageBox.Show("El RUT ingresado no es válido (Dígito verificador incorrecto).", "RUT Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtTelefono.Text, out int tel))
            {
                MessageBox.Show("El teléfono debe ser numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtTelefono.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtRut.Clear();
            txtEdad.Clear();
            txtNombre.Focus();

            if (indiceEditando >= 0)
            {
                indiceEditando = -1;
                btnAgregar.Text = "Agregar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int telefono = int.Parse(txtTelefono.Text);
            int edad = int.Parse(txtEdad.Text);

            if (indiceEditando >= 0)
            {
            
                listaUsuarios[indiceEditando].Nombre = txtNombre.Text;
                listaUsuarios[indiceEditando].Apellido = txtApellido.Text;
                listaUsuarios[indiceEditando].Edad = edad;
                listaUsuarios[indiceEditando].Telefono = telefono;
                listaUsuarios[indiceEditando].Direccion = txtDireccion.Text;
                listaUsuarios[indiceEditando].Rut = txtRut.Text;

                indiceEditando = -1;
                btnAgregar.Text = "Agregar";
                MessageBox.Show("Usuario modificado correctamente.");
            }
            else
            {
                foreach (Usuario u in listaUsuarios)
                {
                    if (u.Rut == txtRut.Text)
                    {
                        MessageBox.Show("Este RUT ya existe en el sistema.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                Usuario nuevo = new Usuario
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Edad = edad,
                    Telefono = telefono,
                    Direccion = txtDireccion.Text,
                    Rut = txtRut.Text
                };

                listaUsuarios.Add(nuevo);
                MessageBox.Show("Usuario agregado correctamente.");
            }

            GuardarUsuarios();
            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            indiceEditando = dgvUsuarios.SelectedRows[0].Index;
            Usuario p = listaUsuarios[indiceEditando];

            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            txtEdad.Text = p.Edad.ToString();
            txtTelefono.Text = p.Telefono.ToString();
            txtDireccion.Text = p.Direccion;
            txtRut.Text = p.Rut;

            btnAgregar.Text = "Guardar Cambios";
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = dgvUsuarios.SelectedRows[0].Index;
                listaUsuarios.RemoveAt(indice);

                GuardarUsuarios();
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