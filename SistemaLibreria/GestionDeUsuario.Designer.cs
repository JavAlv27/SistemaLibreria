namespace SistemaLibreria
{
    partial class GestionDeUsuario
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
            label7 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label6 = new Label();
            lalbel5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtRut = new TextBox();
            dgvUsuarios = new DataGridView();
            dgvNombre = new DataGridViewTextBoxColumn();
            DgvApellido = new DataGridViewTextBoxColumn();
            DgvEdad = new DataGridViewTextBoxColumn();
            dgvTelefono = new DataGridViewTextBoxColumn();
            dgvDireccion = new DataGridViewTextBoxColumn();
            dgvRut = new DataGridViewTextBoxColumn();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Imprint MT Shadow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(403, 9);
            label7.Name = "label7";
            label7.Size = new Size(148, 42);
            label7.TabIndex = 48;
            label7.Text = "Usuarios";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(18, 18, 18);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(679, 260);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 47;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(18, 18, 18);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(571, 260);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(18, 18, 18);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(305, 260);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(18, 18, 18);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(197, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 197);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 37;
            label6.Text = "Rut:";
            // 
            // lalbel5
            // 
            lalbel5.AutoSize = true;
            lalbel5.Location = new Point(367, 171);
            lalbel5.Name = "lalbel5";
            lalbel5.Size = new Size(60, 15);
            lalbel5.TabIndex = 36;
            lalbel5.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 144);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 34;
            label4.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 117);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 33;
            label3.Text = "Edad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 89);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 32;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 62);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 31;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(427, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 49;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(426, 86);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(144, 23);
            txtApellido.TabIndex = 50;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(403, 114);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(167, 23);
            txtEdad.TabIndex = 51;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(426, 141);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(144, 23);
            txtTelefono.TabIndex = 52;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(433, 168);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(137, 23);
            txtDireccion.TabIndex = 53;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(403, 194);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(167, 23);
            txtRut.TabIndex = 54;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { dgvNombre, DgvApellido, DgvEdad, dgvTelefono, dgvDireccion, dgvRut });
            dgvUsuarios.Location = new Point(12, 320);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(935, 300);
            dgvUsuarios.TabIndex = 55;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Imprint MT Shadow", 12.25F);
            label5.Location = new Point(12, 297);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 56;
            label5.Text = "Registro";
            // 
            // GestionDeUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(959, 632);
            Controls.Add(label5);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtRut);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label7);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(lalbel5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionDeUsuario";
            Text = "GestionDeUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtStock;
        private TextBox txtCodigo;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtCategoria;
        private TextBox sdfsd;
        private Label label6;
        private Label lalbel5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtRut;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn dgvNombre;
        private DataGridViewTextBoxColumn DgvApellido;
        private DataGridViewTextBoxColumn DgvEdad;
        private DataGridViewTextBoxColumn dgvTelefono;
        private DataGridViewTextBoxColumn dgvDireccion;
        private DataGridViewTextBoxColumn dgvRut;
        private Label label5;
    }
}