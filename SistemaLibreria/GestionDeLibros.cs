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
    public partial class GestionDeLibros : Form
    {
        private List<Libros> listaLibros = new List<Libros>();
        private string archivoLibros = "libros.txt";
        private int indiceEditando = -1;
        private string[] categorias = {
            "Acción y Aventura",
            "Ciencia Ficción (Sci-Fi)",
            "Fantasía",
            "Terror / Horror",
            "Misterio / Novela Negra / Policial",
            "Thriller / Suspense",
            "Romance / Novela Rosa",
            "Novela Histórica",
            "Realismo Mágico",
            "Literatura Contemporánea",
            "Literatura Juvenil (Young Adult)",
            "Distopía",
            "Sátira / Humor",
            "Western (del Oeste)",
            "Cuentos / Relatos cortos"
        };

        public GestionDeLibros()
        {
            InitializeComponent();
            CargarCategorias();
            CargarLibros();
        }

        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(categorias);
        }

        private void CargarLibros()
        {
            listaLibros.Clear();

            if (File.Exists(archivoLibros))
            {
                string[] lineas = File.ReadAllLines(archivoLibros);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        Libros p = Libros.DesdeTexto(linea);
                        listaLibros.Add(p);
                    }
                }
            }
            ActualizarGrid();
        }

        private void GuardarLibros()
        {
            List<string> lineas = new List<string>();
            foreach (Libros p in listaLibros)
            {
                lineas.Add(p.ATexto());
            }
            File.WriteAllLines(archivoLibros, lineas);
        }

        private void ActualizarGrid()
        {
            listaLibros.Sort((x, y) => string.Compare(x.Titulo, y.Titulo));

            dgvLibros.Rows.Clear();

            foreach (Libros p in listaLibros)
            {
                int index = dgvLibros.Rows.Add();
                dgvLibros.Rows[index].Cells["dgvCodigo"].Value = p.Codigo;
                dgvLibros.Rows[index].Cells["dgvTitulo"].Value = p.Titulo;
                dgvLibros.Rows[index].Cells["dgvStock"].Value = p.Stock.ToString();
                dgvLibros.Rows[index].Cells["dgvEditorial"].Value = p.Editorial;
                dgvLibros.Rows[index].Cells["dgvAutor"].Value = p.Autor;
                dgvLibros.Rows[index].Cells["dgvCategoria"].Value = p.Categoria;
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Ingrese el título del libro", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Ingrese el autor del libro", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría de la lista", "Falta información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número válido (0 o mayor)", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtStock.Clear();
            txtEditorial.Clear();
            
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = "";

            txtTitulo.Focus();

            if (indiceEditando >= 0)
            {
                indiceEditando = -1;
                btnAgregar.Text = "Agregar";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (indiceEditando >= 0)
            {
                listaLibros[indiceEditando].Titulo = txtTitulo.Text;
                listaLibros[indiceEditando].Categoria = cmbCategoria.Text;
                listaLibros[indiceEditando].Editorial = txtEditorial.Text;
                listaLibros[indiceEditando].Autor = txtAutor.Text;
                listaLibros[indiceEditando].Stock = int.Parse(txtStock.Text);

                MessageBox.Show("Libro modificado correctamente.");
                indiceEditando = -1;
                btnAgregar.Text = "Agregar";
            }
            else
            {
                Random rnd = new Random();
                string codigoGenerado = "LIB-" + rnd.Next(10000, 99999).ToString();

                foreach(var libro in listaLibros)
                {
                    if(libro.Codigo == codigoGenerado)
                    {
                        codigoGenerado = "LIB-" + rnd.Next(10000, 99999).ToString();
                    }
                }

                Libros nuevo = new Libros
                {
                    Codigo = codigoGenerado,
                    Titulo = txtTitulo.Text,
                    Categoria = cmbCategoria.Text,
                    Editorial = txtEditorial.Text,
                    Autor = txtAutor.Text,
                    Stock = int.Parse(txtStock.Text)
                };

                listaLibros.Add(nuevo);
                MessageBox.Show($"Libro agregado con éxito.\nCódigo generado: {codigoGenerado}");
            }

            GuardarLibros();
            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            indiceEditando = dgvLibros.SelectedRows[0].Index;
            Libros p = listaLibros[indiceEditando];
            txtTitulo.Text = p.Titulo;
            txtEditorial.Text = p.Editorial;
            txtAutor.Text = p.Autor;
            txtStock.Text = p.Stock.ToString();
            cmbCategoria.Text = p.Categoria;
            btnAgregar.Text = "Guardar Cambios";
            txtTitulo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de eliminar este libro?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                int indice = dgvLibros.SelectedRows[0].Index;
                listaLibros.RemoveAt(indice);

                GuardarLibros();
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