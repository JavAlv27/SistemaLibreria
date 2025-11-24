namespace SistemaLibreria
{
    public partial class Biblioteca : Form
    {
        public Biblioteca()
        {
            InitializeComponent();
        }

        private void gestionDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDeLibros gestionDeLibros = new GestionDeLibros();
            gestionDeLibros.ShowDialog();
        }
        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDePrestamos ventanaPrestamos = new GestionDePrestamos();
            ventanaPrestamos.ShowDialog();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDeUsuario gestionUsuarios = new GestionDeUsuario();
            gestionUsuarios.ShowDialog();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialDeUsuarios historialDeUsuarios = new HistorialDeUsuarios();
            historialDeUsuarios.ShowDialog();
        }

        private void registroTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroTotal registroTotal = new RegistroTotal();
            registroTotal.ShowDialog();
        }
    }
}
