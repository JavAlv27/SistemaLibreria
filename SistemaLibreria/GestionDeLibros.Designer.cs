namespace SistemaLibreria
{
    partial class GestionDeLibros
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
            txtStock = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtTitulo = new TextBox();
            label6 = new Label();
            dgvLibros = new DataGridView();
            dgvTitulo = new DataGridViewTextBoxColumn();
            dgvAutor = new DataGridViewTextBoxColumn();
            dgvEditorial = new DataGridViewTextBoxColumn();
            dgvCategoria = new DataGridViewTextBoxColumn();
            dgvCodigo = new DataGridViewTextBoxColumn();
            dgvStock = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            label7 = new Label();
            label8 = new Label();
            cmbCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // txtStock
            // 
            txtStock.Location = new Point(429, 166);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(112, 23);
            txtStock.TabIndex = 25;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(427, 82);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(114, 23);
            txtAutor.TabIndex = 23;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(441, 110);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(116, 23);
            txtEditorial.TabIndex = 22;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(429, 55);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(112, 23);
            txtTitulo.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 169);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 19;
            label6.Text = "Stock:";
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.BackgroundColor = Color.FromArgb(18, 18, 18);
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { dgvTitulo, dgvAutor, dgvEditorial, dgvCategoria, dgvCodigo, dgvStock });
            dgvLibros.Location = new Point(12, 314);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(932, 276);
            dgvLibros.TabIndex = 17;
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
            // dgvCodigo
            // 
            dgvCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCodigo.HeaderText = "Código";
            dgvCodigo.Name = "dgvCodigo";
            dgvCodigo.ReadOnly = true;
            // 
            // dgvStock
            // 
            dgvStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvStock.HeaderText = "Stock";
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 140);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 16;
            label4.Text = "Categoría:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 15;
            label3.Text = "Editorial:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 85);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 14;
            label2.Text = "Autor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(385, 58);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 13;
            label1.Text = "Título:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(18, 18, 18);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.WhiteSmoke;
            btnAgregar.Location = new Point(170, 259);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(18, 18, 18);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.WhiteSmoke;
            btnModificar.Location = new Point(279, 259);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 27;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(18, 18, 18);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(554, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(18, 18, 18);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.WhiteSmoke;
            btnLimpiar.Location = new Point(675, 259);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Imprint MT Shadow", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(423, 9);
            label7.Name = "label7";
            label7.Size = new Size(114, 42);
            label7.TabIndex = 30;
            label7.Text = "Libros";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Imprint MT Shadow", 12.25F);
            label8.Location = new Point(12, 291);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 31;
            label8.Text = "Registro";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(451, 137);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(143, 23);
            cmbCategoria.TabIndex = 32;
            // 
            // GestionDeLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(956, 602);
            Controls.Add(cmbCategoria);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(txtAutor);
            Controls.Add(txtEditorial);
            Controls.Add(txtTitulo);
            Controls.Add(label6);
            Controls.Add(dgvLibros);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionDeLibros";
            Text = "GestionDeLibros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStock;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtTitulo;
        private Label label6;
        private DataGridView dgvLibros;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn dgvTitulo;
        private DataGridViewTextBoxColumn dgvAutor;
        private DataGridViewTextBoxColumn dgvEditorial;
        private DataGridViewTextBoxColumn dgvCategoria;
        private DataGridViewTextBoxColumn dgvCodigo;
        private DataGridViewTextBoxColumn dgvStock;
        private ComboBox cmbCategoria;
    }
}