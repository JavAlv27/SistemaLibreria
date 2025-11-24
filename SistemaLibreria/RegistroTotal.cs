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
    public partial class RegistroTotal : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private List<Libros> listaLibros = new List<Libros>();
        private List<Prestamos> listaPrestamos = new List<Prestamos>();
        private List<Devolucion> listaDevoluciones = new List<Devolucion>();

        private string fileUsuarios = "usuarios.txt";
        private string fileLibros = "libros.txt";
        private string filePrestamos = "prestamos.txt";
        private string fileDevoluciones = "devoluciones.txt";

        private int idxUsr = -1;
        private int idxLib = -1;
        private int idxPrest = -1;
        private int idxDev = -1;

        private string[] categorias = {
            "Acción y Aventura",
            "Ciencia Ficción (Sci-Fi)",
            "Fantasía",
            "Terror / Horror",
            "Misterio / Novela Negra",
            "Thriller / Suspense",
            "Romance",
            "Novela Histórica",
            "Realismo Mágico",
            "Literatura Contemporánea",
            "Literatura Juvenil",
            "Distopía",
            "Cuentos",
            "Educativo / Académico"
        };

        public RegistroTotal()
        {
            InitializeComponent();
        }

        private void RegistroTotal_Load(object sender, EventArgs e)
        {
            CargarCategorias(); 
            CargarTodo();
            ConfigurarCombosOrdenamiento();
            BloquearTodosLosCampos(true);
        }

        private void CargarCategorias()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.AddRange(categorias);
        }

        private void CargarTodo()
        {
           
            listaUsuarios.Clear();
            if (File.Exists(fileUsuarios))
            {
                string[] lineas = File.ReadAllLines(fileUsuarios);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        listaUsuarios.Add(Usuario.DesdeTexto(linea));
                    }
                }
            }
            ActualizarGridUsuarios();

            listaLibros.Clear();
            if (File.Exists(fileLibros))
            {
                string[] lineas = File.ReadAllLines(fileLibros);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        listaLibros.Add(Libros.DesdeTexto(linea));
                    }
                }
            }
            ActualizarGridLibros();

            listaPrestamos.Clear();
            if (File.Exists(filePrestamos))
            {
                string[] lineas = File.ReadAllLines(filePrestamos);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        listaPrestamos.Add(Prestamos.DesdeTexto(linea));
                    }
                }
            }
            ActualizarGridPrestamos();
 
            listaDevoluciones.Clear();
            if (File.Exists(fileDevoluciones))
            {
                string[] lineas = File.ReadAllLines(fileDevoluciones);
                foreach (string linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        listaDevoluciones.Add(Devolucion.DesdeTexto(linea));
                    }
                }
            }
            ActualizarGridDevoluciones();
        }

        private void ConfigurarCombosOrdenamiento()
        {
            cmbBuscarUsr.Items.Clear();
            cmbBuscarUsr.Items.AddRange(new string[] { "Nombre", "Apellido", "Rut" });

            cmbBuscarLib.Items.Clear();
            cmbBuscarLib.Items.AddRange(new string[] { "Titulo", "Autor", "Editorial", "Categoria", "Stock" });

            cmbBuscarPrest.Items.Clear();
            cmbBuscarPrest.Items.AddRange(new string[] { "Rut Usuario", "Codigo Libro", "Fecha Prestamo" });

            cmbBuscarDev.Items.Clear();
            cmbBuscarDev.Items.AddRange(new string[] { "Rut Usuario", "Codigo Libro", "Fecha Devolucion" });
        }

        private void BloquearTodosLosCampos(bool bloquear)
        {
            
            txtNombre.ReadOnly = bloquear;
            txtApellido.ReadOnly = bloquear;
            txtEdad.ReadOnly = bloquear;
            txtTelefono.ReadOnly = bloquear;
            txtDireccion.ReadOnly = bloquear;
            txtRut.ReadOnly = bloquear;
            txtTitulo.ReadOnly = bloquear;
            txtAutor.ReadOnly = bloquear;
            txtEditorial.ReadOnly = bloquear;
            txtStock.ReadOnly = bloquear;
            cmbCategoria.Enabled = !bloquear;
        }

        private void ActualizarGridUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            foreach (var u in listaUsuarios)
            {
                dgvUsuarios.Rows.Add(u.Nombre, u.Apellido, u.Edad, u.Telefono, u.Direccion, u.Rut);
            }
        }

        private void cmbBuscarUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = cmbBuscarUsr.Text;

            if (criterio == "Nombre")
            {
                listaUsuarios = listaUsuarios.OrderBy(x => x.Nombre).ToList();
            }
            else if (criterio == "Apellido")
            {
                listaUsuarios = listaUsuarios.OrderBy(x => x.Apellido).ToList();
            }
            else if (criterio == "Rut")
            {
                listaUsuarios = listaUsuarios.OrderBy(x => x.Rut).ToList();
            }

            ActualizarGridUsuarios();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idxUsr = e.RowIndex;

                if (idxUsr < listaUsuarios.Count)
                {
                    Usuario u = listaUsuarios[idxUsr];
                    txtNombre.Text = u.Nombre;
                    txtApellido.Text = u.Apellido;
                    txtEdad.Text = u.Edad.ToString();
                    txtTelefono.Text = u.Telefono.ToString();
                    txtDireccion.Text = u.Direccion;
                    txtRut.Text = u.Rut;
                }
            }
        }

        private void btnModificarUsr_Click(object sender, EventArgs e)
        {
            if (idxUsr == -1)
            {
                MessageBox.Show("Selecciona un usuario primero.");
                return;
            }

            if (btnModificarUsr.Text == "Modificar")
            {
                txtNombre.ReadOnly = false;
                txtApellido.ReadOnly = false;
                txtEdad.ReadOnly = false;
                txtTelefono.ReadOnly = false;
                txtDireccion.ReadOnly = false;

                btnModificarUsr.Text = "Guardar";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    MessageBox.Show("El apellido no puede estar vacío.");
                    return;
                }

                int edadValidada;
                int telefonoValidado;

                if (!int.TryParse(txtEdad.Text, out edadValidada))
                {
                    MessageBox.Show("La edad debe ser un número válido.");
                    return;
                }
                else if (!int.TryParse(txtTelefono.Text, out telefonoValidado))
                {
                    MessageBox.Show("El teléfono debe ser un número válido.");
                    return;
                }
                else
                {
                    listaUsuarios[idxUsr].Nombre = txtNombre.Text;
                    listaUsuarios[idxUsr].Apellido = txtApellido.Text;
                    listaUsuarios[idxUsr].Edad = edadValidada;
                    listaUsuarios[idxUsr].Telefono = telefonoValidado;
                    listaUsuarios[idxUsr].Direccion = txtDireccion.Text;

                    List<string> lineas = new List<string>();
                    foreach (var u in listaUsuarios)
                    {
                        lineas.Add(u.ATexto());
                    }
                    File.WriteAllLines(fileUsuarios, lineas);

                    MessageBox.Show("Usuario actualizado correctamente.");

                    BloquearTodosLosCampos(true);
                    ActualizarGridUsuarios();
                    btnModificarUsr.Text = "Modificar";
                }
            }
        }

        private void btnEliminarUsr_Click(object sender, EventArgs e)
        {
            if (idxUsr == -1)
            {
                MessageBox.Show("Selecciona un usuario.");
                return;
            }

            if (MessageBox.Show("¿Eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaUsuarios.RemoveAt(idxUsr);

                List<string> lineas = new List<string>();
                foreach (var u in listaUsuarios)
                {
                    lineas.Add(u.ATexto());
                }
                File.WriteAllLines(fileUsuarios, lineas);

                ActualizarGridUsuarios();
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                txtRut.Clear();
                idxUsr = -1;
            }
        }

        private void ActualizarGridLibros()
        {
            dgvLibros.Rows.Clear();
            foreach (var l in listaLibros)
            {
                dgvLibros.Rows.Add(l.Titulo, l.Autor, l.Editorial, l.Categoria, l.Codigo, l.Stock);
            }
        }

        private void cmbBuscarLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = cmbBuscarLib.Text;

            if (criterio == "Titulo")
            {
                listaLibros = listaLibros.OrderBy(x => x.Titulo).ToList();
            }
            else if (criterio == "Autor")
            {
                listaLibros = listaLibros.OrderBy(x => x.Autor).ToList();
            }
            else if (criterio == "Editorial")
            {
                listaLibros = listaLibros.OrderBy(x => x.Editorial).ToList();
            }
            else if (criterio == "Categoria")
            {
                listaLibros = listaLibros.OrderBy(x => x.Categoria).ToList();
            }
            else if (criterio == "Stock")
            {
                listaLibros = listaLibros.OrderBy(x => x.Stock).ToList();
            }

            ActualizarGridLibros();
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idxLib = e.RowIndex;
                if (idxLib < listaLibros.Count)
                {
                    Libros l = listaLibros[idxLib];
                    txtTitulo.Text = l.Titulo;
                    txtAutor.Text = l.Autor;
                    txtEditorial.Text = l.Editorial;
                    txtStock.Text = l.Stock.ToString();
                    cmbCategoria.Text = l.Categoria;
                }
            }
        }

        private void btnModificarLib_Click(object sender, EventArgs e)
        {
            if (idxLib == -1)
            {
                MessageBox.Show("Selecciona un libro.");
                return;
            }

            if (btnModificarLib.Text == "Modificar")
            {
                txtTitulo.ReadOnly = false;
                txtAutor.ReadOnly = false;
                txtEditorial.ReadOnly = false;
                txtStock.ReadOnly = false;
                cmbCategoria.Enabled = true;
                btnModificarLib.Text = "Guardar";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("El título es obligatorio.");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtAutor.Text))
                {
                    MessageBox.Show("El autor es obligatorio.");
                    return;
                }
                else if (cmbCategoria.Text == "")
                {
                    MessageBox.Show("Selecciona una categoría.");
                    return;
                }

                int stockValidado;
                if (!int.TryParse(txtStock.Text, out stockValidado))
                {
                    MessageBox.Show("El stock debe ser un número entero válido.");
                    return;
                }
                else if (stockValidado < 0)
                {
                    MessageBox.Show("El stock no puede ser negativo.");
                    return;
                }
                else
                {
                    listaLibros[idxLib].Titulo = txtTitulo.Text;
                    listaLibros[idxLib].Autor = txtAutor.Text;
                    listaLibros[idxLib].Editorial = txtEditorial.Text;
                    listaLibros[idxLib].Categoria = cmbCategoria.Text;
                    listaLibros[idxLib].Stock = stockValidado;

                    List<string> lineas = new List<string>();
                    foreach (var l in listaLibros)
                    {
                        lineas.Add(l.ATexto());
                    }
                    File.WriteAllLines(fileLibros, lineas);

                    MessageBox.Show("Libro actualizado.");

                    BloquearTodosLosCampos(true);
                    ActualizarGridLibros();
                    btnModificarLib.Text = "Modificar";
                }
            }
        }

        private void btnEliminarLib_Click(object sender, EventArgs e)
        {
            if (idxLib == -1)
            {
                MessageBox.Show("Selecciona un libro.");
                return;
            }

            if (MessageBox.Show("¿Eliminar este libro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaLibros.RemoveAt(idxLib);

                List<string> lineas = new List<string>();
                foreach (var l in listaLibros)
                {
                    lineas.Add(l.ATexto());
                }
                File.WriteAllLines(fileLibros, lineas);

                ActualizarGridLibros();

                txtTitulo.Clear();
                txtAutor.Clear();
                txtEditorial.Clear();
                txtStock.Clear();
                cmbCategoria.SelectedIndex = -1;
                idxLib = -1;
            }
        }

        private void ActualizarGridPrestamos()
        {
            dgvPrestamos.Rows.Clear();
            foreach (var p in listaPrestamos)
            {
                dgvPrestamos.Rows.Add(p.CodigoPrestamo, p.RutUsuario, p.NombreUsuario, p.CodigoLibro, p.NombreLibro, p.FechaPrestamo.ToShortDateString(), p.FechaDevolucion.ToShortDateString());
            }
        }

        private void cmbBuscarPrest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = cmbBuscarPrest.Text;

            if (criterio == "Rut Usuario")
            {
                listaPrestamos = listaPrestamos.OrderBy(x => x.RutUsuario).ToList();
            }
            else if (criterio == "Codigo Libro")
            {
                listaPrestamos = listaPrestamos.OrderBy(x => x.CodigoLibro).ToList();
            }
            else if (criterio == "Fecha Prestamo")
            {
                listaPrestamos = listaPrestamos.OrderBy(x => x.FechaPrestamo).ToList();
            }

            ActualizarGridPrestamos();
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idxPrest = e.RowIndex;
            }
        }

        private void btnEliminarPrest_Click(object sender, EventArgs e)
        {
            if (idxPrest == -1)
            {
                MessageBox.Show("Selecciona un préstamo.");
                return;
            }

            if (MessageBox.Show("¿Eliminar registro de préstamo?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaPrestamos.RemoveAt(idxPrest);

                List<string> lineas = new List<string>();
                foreach (var p in listaPrestamos)
                {
                    lineas.Add(p.ATexto());
                }
                File.WriteAllLines(filePrestamos, lineas);

                ActualizarGridPrestamos();
                idxPrest = -1;
            }
        }

        private void ActualizarGridDevoluciones()
        {
            dgvDevolucion.Rows.Clear();
            foreach (var d in listaDevoluciones)
            {
                dgvDevolucion.Rows.Add(d.CodigoDevolucion, d.NombreUsuario, d.RutUsuario, d.NombreLibro, d.CodigoLibro, d.FechaPrestamoOriginal.ToShortDateString(), d.FechaDevolucionReal.ToShortDateString());
            }
        }

        private void cmbBuscarDev_SelectedIndexChanged(object sender, EventArgs e)
        {
            string criterio = cmbBuscarDev.Text;

            if (criterio == "Rut Usuario")
            {
                listaDevoluciones = listaDevoluciones.OrderBy(x => x.RutUsuario).ToList();
            }
            else if (criterio == "Codigo Libro")
            {
                listaDevoluciones = listaDevoluciones.OrderBy(x => x.CodigoLibro).ToList();
            }
            else if (criterio == "Fecha Devolucion")
            {
                listaDevoluciones = listaDevoluciones.OrderBy(x => x.FechaDevolucionReal).ToList();
            }

            ActualizarGridDevoluciones();
        }

        private void dgvDevolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idxDev = e.RowIndex;
            }
        }

        private void btnEliminarDev_Click(object sender, EventArgs e)
        {
            if (idxDev == -1)
            {
                MessageBox.Show("Selecciona una devolución.");
                return;
            }

            if (MessageBox.Show("¿Eliminar registro de devolución?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listaDevoluciones.RemoveAt(idxDev);

                List<string> lineas = new List<string>();
                foreach (var d in listaDevoluciones)
                {
                    lineas.Add(d.ATexto());
                }
                File.WriteAllLines(fileDevoluciones, lineas);

                ActualizarGridDevoluciones();
                idxDev = -1;
            }
        }
    }
}