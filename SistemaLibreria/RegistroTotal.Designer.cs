namespace SistemaLibreria
{
    partial class RegistroTotal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUsuarios = new DataGridView();
            dgvNombre = new DataGridViewTextBoxColumn();
            DgvApellido = new DataGridViewTextBoxColumn();
            DgvEdad = new DataGridViewTextBoxColumn();
            dgvTelefono = new DataGridViewTextBoxColumn();
            dgvDireccion = new DataGridViewTextBoxColumn();
            dgvRut = new DataGridViewTextBoxColumn();
            dgvDevolucion = new DataGridView();
            dgvCodigoDevolucion = new DataGridViewTextBoxColumn();
            dgvNombreUsuario = new DataGridViewTextBoxColumn();
            dgvRutUsuario = new DataGridViewTextBoxColumn();
            dgvLibro = new DataGridViewTextBoxColumn();
            dgvCodigoLibro = new DataGridViewTextBoxColumn();
            dgvFechaPrestamo = new DataGridViewTextBoxColumn();
            dgvFechaDevolucion = new DataGridViewTextBoxColumn();
            dgvPrestamos = new DataGridView();
            dgvCodigo = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dgvNombreLibro = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dgvLibros = new DataGridView();
            dgvTitulo = new DataGridViewTextBoxColumn();
            dgvAutor = new DataGridViewTextBoxColumn();
            dgvEditorial = new DataGridViewTextBoxColumn();
            dgvCategoria = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dgvStock = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbBuscarUsr = new ComboBox();
            label6 = new Label();
            btnModificarUsr = new Button();
            btnEliminarUsr = new Button();
            btnEliminarDev = new Button();
            label1 = new Label();
            cmbBuscarDev = new ComboBox();
            btnElimnarLib = new Button();
            btnModificarLib = new Button();
            label7 = new Label();
            cmbBuscarLib = new ComboBox();
            btnEliminarPrest = new Button();
            label8 = new Label();
            cmbBuscarPrest = new ComboBox();
            txtRut = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            lalbel5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            cmbCategoria = new ComboBox();
            txtStock = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtTitulo = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { dgvNombre, DgvApellido, DgvEdad, dgvTelefono, dgvDireccion, dgvRut });
            dgvUsuarios.Location = new Point(12, 166);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(704, 329);
            dgvUsuarios.TabIndex = 56;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellClick;
            // 
            // dgvNombre
            // 
            dgvNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNombre.HeaderText = "Nombre";
            dgvNombre.Name = "dgvNombre";
            dgvNombre.ReadOnly = true;
            // 
            // DgvApellido
            // 
            DgvApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvApellido.HeaderText = "Apellido";
            DgvApellido.Name = "DgvApellido";
            DgvApellido.ReadOnly = true;
            // 
            // DgvEdad
            // 
            DgvEdad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvEdad.HeaderText = "Edad";
            DgvEdad.Name = "DgvEdad";
            DgvEdad.ReadOnly = true;
            // 
            // dgvTelefono
            // 
            dgvTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTelefono.HeaderText = "Teléfono";
            dgvTelefono.Name = "dgvTelefono";
            dgvTelefono.ReadOnly = true;
            // 
            // dgvDireccion
            // 
            dgvDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDireccion.HeaderText = "Dirección";
            dgvDireccion.Name = "dgvDireccion";
            dgvDireccion.ReadOnly = true;
            // 
            // dgvRut
            // 
            dgvRut.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRut.HeaderText = "Rut";
            dgvRut.Name = "dgvRut";
            dgvRut.ReadOnly = true;
            // 
            // dgvDevolucion
            // 
            dgvDevolucion.AllowUserToAddRows = false;
            dgvDevolucion.AllowUserToDeleteRows = false;
            dgvDevolucion.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvDevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevolucion.Columns.AddRange(new DataGridViewColumn[] { dgvCodigoDevolucion, dgvNombreUsuario, dgvRutUsuario, dgvLibro, dgvCodigoLibro, dgvFechaPrestamo, dgvFechaDevolucion });
            dgvDevolucion.Location = new Point(1046, 166);
            dgvDevolucion.MultiSelect = false;
            dgvDevolucion.Name = "dgvDevolucion";
            dgvDevolucion.ReadOnly = true;
            dgvDevolucion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevolucion.Size = new Size(704, 329);
            dgvDevolucion.TabIndex = 57;
            dgvDevolucion.CellContentClick += dgvDevolucion_CellClick;
            // 
            // dgvCodigoDevolucion
            // 
            dgvCodigoDevolucion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigoDevolucion.HeaderText = "Codigo de devolución";
            dgvCodigoDevolucion.Name = "dgvCodigoDevolucion";
            dgvCodigoDevolucion.ReadOnly = true;
            // 
            // dgvNombreUsuario
            // 
            dgvNombreUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNombreUsuario.HeaderText = "Nombre de usuario";
            dgvNombreUsuario.Name = "dgvNombreUsuario";
            dgvNombreUsuario.ReadOnly = true;
            // 
            // dgvRutUsuario
            // 
            dgvRutUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvRutUsuario.HeaderText = "Rut de usuario";
            dgvRutUsuario.Name = "dgvRutUsuario";
            dgvRutUsuario.ReadOnly = true;
            // 
            // dgvLibro
            // 
            dgvLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLibro.HeaderText = "Libro";
            dgvLibro.Name = "dgvLibro";
            dgvLibro.ReadOnly = true;
            // 
            // dgvCodigoLibro
            // 
            dgvCodigoLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigoLibro.HeaderText = "Codigo de libro";
            dgvCodigoLibro.Name = "dgvCodigoLibro";
            dgvCodigoLibro.ReadOnly = true;
            // 
            // dgvFechaPrestamo
            // 
            dgvFechaPrestamo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFechaPrestamo.HeaderText = "Fecha de préstamo";
            dgvFechaPrestamo.Name = "dgvFechaPrestamo";
            dgvFechaPrestamo.ReadOnly = true;
            // 
            // dgvFechaDevolucion
            // 
            dgvFechaDevolucion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvFechaDevolucion.HeaderText = "Fecha de devolución";
            dgvFechaDevolucion.Name = "dgvFechaDevolucion";
            dgvFechaDevolucion.ReadOnly = true;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Columns.AddRange(new DataGridViewColumn[] { dgvCodigo, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dgvNombreLibro, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvPrestamos.Location = new Point(1033, 654);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(704, 329);
            dgvPrestamos.TabIndex = 58;
            dgvPrestamos.CellContentClick += dgvPrestamos_CellClick;
            // 
            // dgvCodigo
            // 
            dgvCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigo.HeaderText = "Codigo Prestamo";
            dgvCodigo.Name = "dgvCodigo";
            dgvCodigo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "Rut de usuario";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Nombre de usuario";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Codigo de libro";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvNombreLibro
            // 
            dgvNombreLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNombreLibro.HeaderText = "Nombre de libro";
            dgvNombreLibro.Name = "dgvNombreLibro";
            dgvNombreLibro.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Fecha de préstamo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Fecha de devolución(estimada)";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { dgvTitulo, dgvAutor, dgvEditorial, dgvCategoria, dataGridViewTextBoxColumn6, dgvStock });
            dgvLibros.Location = new Point(12, 654);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(704, 329);
            dgvLibros.TabIndex = 59;
            dgvLibros.CellContentClick += dgvLibros_CellClick;
            // 
            // dgvTitulo
            // 
            dgvTitulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTitulo.HeaderText = "Título";
            dgvTitulo.Name = "dgvTitulo";
            dgvTitulo.ReadOnly = true;
            // 
            // dgvAutor
            // 
            dgvAutor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAutor.HeaderText = "Autor";
            dgvAutor.Name = "dgvAutor";
            dgvAutor.ReadOnly = true;
            // 
            // dgvEditorial
            // 
            dgvEditorial.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEditorial.HeaderText = "Editorial";
            dgvEditorial.Name = "dgvEditorial";
            dgvEditorial.ReadOnly = true;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCategoria.HeaderText = "Categoría";
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn6.HeaderText = "Código";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dgvStock
            // 
            dgvStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.HeaderText = "Stock";
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 26.25F);
            label2.Location = new Point(16, 24);
            label2.Name = "label2";
            label2.Size = new Size(148, 42);
            label2.TabIndex = 60;
            label2.Text = "Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 26.25F);
            label3.Location = new Point(1033, 24);
            label3.Name = "label3";
            label3.Size = new Size(221, 42);
            label3.TabIndex = 61;
            label3.Text = "Devoluciones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Imprint MT Shadow", 26.25F);
            label4.Location = new Point(18, 512);
            label4.Name = "label4";
            label4.Size = new Size(114, 42);
            label4.TabIndex = 62;
            label4.Text = "Libros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Imprint MT Shadow", 26.25F);
            label5.Location = new Point(1048, 503);
            label5.Name = "label5";
            label5.Size = new Size(173, 42);
            label5.TabIndex = 63;
            label5.Text = "Préstamos";
            // 
            // cmbBuscarUsr
            // 
            cmbBuscarUsr.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarUsr.FormattingEnabled = true;
            cmbBuscarUsr.Location = new Point(584, 42);
            cmbBuscarUsr.Name = "cmbBuscarUsr";
            cmbBuscarUsr.Size = new Size(136, 23);
            cmbBuscarUsr.TabIndex = 64;
            cmbBuscarUsr.SelectedIndexChanged += cmbBuscarUsr_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(584, 24);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 68;
            label6.Text = "Buscar por:";
            // 
            // btnModificarUsr
            // 
            btnModificarUsr.BackColor = Color.FromArgb(18, 18, 18);
            btnModificarUsr.FlatAppearance.BorderSize = 0;
            btnModificarUsr.FlatStyle = FlatStyle.Flat;
            btnModificarUsr.ForeColor = Color.WhiteSmoke;
            btnModificarUsr.Location = new Point(584, 71);
            btnModificarUsr.Name = "btnModificarUsr";
            btnModificarUsr.Size = new Size(66, 23);
            btnModificarUsr.TabIndex = 72;
            btnModificarUsr.Text = "Modificar";
            btnModificarUsr.UseVisualStyleBackColor = false;
            btnModificarUsr.Click += btnModificarUsr_Click;
            // 
            // btnEliminarUsr
            // 
            btnEliminarUsr.BackColor = Color.FromArgb(18, 18, 18);
            btnEliminarUsr.FlatAppearance.BorderSize = 0;
            btnEliminarUsr.FlatStyle = FlatStyle.Flat;
            btnEliminarUsr.ForeColor = Color.WhiteSmoke;
            btnEliminarUsr.Location = new Point(656, 71);
            btnEliminarUsr.Name = "btnEliminarUsr";
            btnEliminarUsr.Size = new Size(66, 23);
            btnEliminarUsr.TabIndex = 73;
            btnEliminarUsr.Text = "Eliminar";
            btnEliminarUsr.UseVisualStyleBackColor = false;
            btnEliminarUsr.Click += btnEliminarUsr_Click;
            // 
            // btnEliminarDev
            // 
            btnEliminarDev.BackColor = Color.FromArgb(18, 18, 18);
            btnEliminarDev.FlatAppearance.BorderSize = 0;
            btnEliminarDev.FlatStyle = FlatStyle.Flat;
            btnEliminarDev.ForeColor = Color.WhiteSmoke;
            btnEliminarDev.Location = new Point(1673, 72);
            btnEliminarDev.Name = "btnEliminarDev";
            btnEliminarDev.Size = new Size(66, 23);
            btnEliminarDev.TabIndex = 77;
            btnEliminarDev.Text = "Eliminar";
            btnEliminarDev.UseVisualStyleBackColor = false;
            btnEliminarDev.Click += btnEliminarDev_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1601, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 75;
            label1.Text = "Buscar por:";
            // 
            // cmbBuscarDev
            // 
            cmbBuscarDev.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarDev.FormattingEnabled = true;
            cmbBuscarDev.Location = new Point(1601, 43);
            cmbBuscarDev.Name = "cmbBuscarDev";
            cmbBuscarDev.Size = new Size(136, 23);
            cmbBuscarDev.TabIndex = 74;
            cmbBuscarDev.SelectedIndexChanged += cmbBuscarDev_SelectedIndexChanged;
            // 
            // btnElimnarLib
            // 
            btnElimnarLib.BackColor = Color.FromArgb(18, 18, 18);
            btnElimnarLib.FlatAppearance.BorderSize = 0;
            btnElimnarLib.FlatStyle = FlatStyle.Flat;
            btnElimnarLib.ForeColor = Color.WhiteSmoke;
            btnElimnarLib.Location = new Point(658, 551);
            btnElimnarLib.Name = "btnElimnarLib";
            btnElimnarLib.Size = new Size(66, 23);
            btnElimnarLib.TabIndex = 81;
            btnElimnarLib.Text = "Eliminar";
            btnElimnarLib.UseVisualStyleBackColor = false;
            btnElimnarLib.Click += btnEliminarLib_Click;
            // 
            // btnModificarLib
            // 
            btnModificarLib.BackColor = Color.FromArgb(18, 18, 18);
            btnModificarLib.FlatAppearance.BorderSize = 0;
            btnModificarLib.FlatStyle = FlatStyle.Flat;
            btnModificarLib.ForeColor = Color.WhiteSmoke;
            btnModificarLib.Location = new Point(586, 551);
            btnModificarLib.Name = "btnModificarLib";
            btnModificarLib.Size = new Size(66, 23);
            btnModificarLib.TabIndex = 80;
            btnModificarLib.Text = "Modificar";
            btnModificarLib.UseVisualStyleBackColor = false;
            btnModificarLib.Click += btnModificarLib_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(586, 504);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 79;
            label7.Text = "Buscar por:";
            // 
            // cmbBuscarLib
            // 
            cmbBuscarLib.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarLib.FormattingEnabled = true;
            cmbBuscarLib.Location = new Point(586, 522);
            cmbBuscarLib.Name = "cmbBuscarLib";
            cmbBuscarLib.Size = new Size(136, 23);
            cmbBuscarLib.TabIndex = 78;
            cmbBuscarLib.SelectedIndexChanged += cmbBuscarLib_SelectedIndexChanged;
            // 
            // btnEliminarPrest
            // 
            btnEliminarPrest.BackColor = Color.FromArgb(18, 18, 18);
            btnEliminarPrest.FlatAppearance.BorderSize = 0;
            btnEliminarPrest.FlatStyle = FlatStyle.Flat;
            btnEliminarPrest.ForeColor = Color.WhiteSmoke;
            btnEliminarPrest.Location = new Point(1677, 551);
            btnEliminarPrest.Name = "btnEliminarPrest";
            btnEliminarPrest.Size = new Size(66, 23);
            btnEliminarPrest.TabIndex = 85;
            btnEliminarPrest.Text = "Eliminar";
            btnEliminarPrest.UseVisualStyleBackColor = false;
            btnEliminarPrest.Click += btnEliminarPrest_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1605, 504);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 83;
            label8.Text = "Buscar por:";
            // 
            // cmbBuscarPrest
            // 
            cmbBuscarPrest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuscarPrest.FormattingEnabled = true;
            cmbBuscarPrest.Location = new Point(1605, 522);
            cmbBuscarPrest.Name = "cmbBuscarPrest";
            cmbBuscarPrest.Size = new Size(136, 23);
            cmbBuscarPrest.TabIndex = 82;
            cmbBuscarPrest.SelectedIndexChanged += cmbBuscarPrest_SelectedIndexChanged;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(605, 125);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(106, 23);
            txtRut.TabIndex = 97;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(495, 125);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(104, 23);
            txtDireccion.TabIndex = 96;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(386, 125);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(103, 23);
            txtTelefono.TabIndex = 95;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(274, 125);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(106, 23);
            txtEdad.TabIndex = 94;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(156, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(112, 23);
            txtApellido.TabIndex = 93;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(49, 125);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(101, 23);
            txtNombre.TabIndex = 92;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(631, 101);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 91;
            label9.Text = "Rut:";
            // 
            // lalbel5
            // 
            lalbel5.AutoSize = true;
            lalbel5.Location = new Point(517, 101);
            lalbel5.Name = "lalbel5";
            lalbel5.Size = new Size(60, 15);
            lalbel5.TabIndex = 90;
            lalbel5.Text = "Dirección:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(402, 101);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 89;
            label10.Text = "Teléfono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(304, 101);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 88;
            label11.Text = "Edad:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(185, 101);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 87;
            label12.Text = "Apellido:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(73, 101);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 86;
            label13.Text = "Nombre:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(390, 611);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(107, 23);
            cmbCategoria.TabIndex = 107;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(601, 611);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(115, 23);
            txtStock.TabIndex = 106;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(174, 611);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 105;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(280, 611);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(104, 23);
            txtEditorial.TabIndex = 104;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(51, 611);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(117, 23);
            txtTitulo.TabIndex = 103;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(640, 582);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 102;
            label14.Text = "Stock:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(413, 582);
            label15.Name = "label15";
            label15.Size = new Size(61, 15);
            label15.TabIndex = 101;
            label15.Text = "Categoría:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(310, 582);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 100;
            label16.Text = "Editorial:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(205, 582);
            label17.Name = "label17";
            label17.Size = new Size(40, 15);
            label17.TabIndex = 99;
            label17.Text = "Autor:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(87, 582);
            label18.Name = "label18";
            label18.Size = new Size(41, 15);
            label18.TabIndex = 98;
            label18.Text = "Título:";
            // 
            // RegistroTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1749, 1020);
            Controls.Add(cmbCategoria);
            Controls.Add(txtStock);
            Controls.Add(txtAutor);
            Controls.Add(txtEditorial);
            Controls.Add(txtTitulo);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(txtRut);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(lalbel5);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(btnEliminarPrest);
            Controls.Add(label8);
            Controls.Add(cmbBuscarPrest);
            Controls.Add(btnElimnarLib);
            Controls.Add(btnModificarLib);
            Controls.Add(label7);
            Controls.Add(cmbBuscarLib);
            Controls.Add(btnEliminarDev);
            Controls.Add(label1);
            Controls.Add(cmbBuscarDev);
            Controls.Add(btnEliminarUsr);
            Controls.Add(btnModificarUsr);
            Controls.Add(label6);
            Controls.Add(cmbBuscarUsr);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvLibros);
            Controls.Add(dgvPrestamos);
            Controls.Add(dgvDevolucion);
            Controls.Add(dgvUsuarios);
            Name = "RegistroTotal";
            Text = "RegistroTotal";
            Load += RegistroTotal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevolucion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn dgvNombre;
        private DataGridViewTextBoxColumn DgvApellido;
        private DataGridViewTextBoxColumn DgvEdad;
        private DataGridViewTextBoxColumn dgvTelefono;
        private DataGridViewTextBoxColumn dgvDireccion;
        private DataGridViewTextBoxColumn dgvRut;
        private DataGridView dgvDevolucion;
        private DataGridViewTextBoxColumn dgvCodigoDevolucion;
        private DataGridViewTextBoxColumn dgvNombreUsuario;
        private DataGridViewTextBoxColumn dgvRutUsuario;
        private DataGridViewTextBoxColumn dgvLibro;
        private DataGridViewTextBoxColumn dgvCodigoLibro;
        private DataGridViewTextBoxColumn dgvFechaPrestamo;
        private DataGridViewTextBoxColumn dgvFechaDevolucion;
        private DataGridView dgvPrestamos;
        private DataGridViewTextBoxColumn dgvCodigo;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dgvNombreLibro;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn dgvTitulo;
        private DataGridViewTextBoxColumn dgvAutor;
        private DataGridViewTextBoxColumn dgvEditorial;
        private DataGridViewTextBoxColumn dgvCategoria;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dgvStock;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbBuscarUsr;
        private Label label6;
        private Button btnModificarUsr;
        private Button btnEliminarUsr;
        private Button btnEliminarDev;
        private Label label1;
        private ComboBox cmbBuscarDev;
        private Button btnElimnarLib;
        private Button btnModificarLib;
        private Label label7;
        private ComboBox cmbBuscarLib;
        private Button btnEliminarPrest;
        private Label label8;
        private ComboBox cmbBuscarPrest;
        private TextBox txtRut;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label9;
        private Label lalbel5;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ComboBox cmbCategoria;
        private TextBox txtStock;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtTitulo;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
    }
}