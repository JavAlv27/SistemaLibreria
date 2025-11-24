namespace SistemaLibreria
{
    partial class Biblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            gestionDeLibrosToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            prestamoToolStripMenuItem = new ToolStripMenuItem();
            prestamosToolStripMenuItem = new ToolStripMenuItem();
            devolucionesToolStripMenuItem = new ToolStripMenuItem();
            registroTotalToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(240, 153);
            label1.Name = "label1";
            label1.Size = new Size(344, 36);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Biblioteca";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.OldLace;
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionDeLibrosToolStripMenuItem, usuariosToolStripMenuItem, prestamoToolStripMenuItem, registroTotalToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip2";
            // 
            // gestionDeLibrosToolStripMenuItem
            // 
            gestionDeLibrosToolStripMenuItem.Name = "gestionDeLibrosToolStripMenuItem";
            gestionDeLibrosToolStripMenuItem.Size = new Size(51, 20);
            gestionDeLibrosToolStripMenuItem.Text = "Libros";
            gestionDeLibrosToolStripMenuItem.Click += gestionDeLibrosToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // prestamoToolStripMenuItem
            // 
            prestamoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { prestamosToolStripMenuItem, devolucionesToolStripMenuItem });
            prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            prestamoToolStripMenuItem.Size = new Size(133, 20);
            prestamoToolStripMenuItem.Text = "Gestion de prestamos";
            // 
            // prestamosToolStripMenuItem
            // 
            prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            prestamosToolStripMenuItem.Size = new Size(145, 22);
            prestamosToolStripMenuItem.Text = "Prestamos";
            prestamosToolStripMenuItem.Click += prestamoToolStripMenuItem_Click;
            // 
            // devolucionesToolStripMenuItem
            // 
            devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            devolucionesToolStripMenuItem.Size = new Size(145, 22);
            devolucionesToolStripMenuItem.Text = "Devoluciones";
            devolucionesToolStripMenuItem.Click += devolucionesToolStripMenuItem_Click;
            // 
            // registroTotalToolStripMenuItem
            // 
            registroTotalToolStripMenuItem.Name = "registroTotalToolStripMenuItem";
            registroTotalToolStripMenuItem.Size = new Size(89, 20);
            registroTotalToolStripMenuItem.Text = "Registro total";
            registroTotalToolStripMenuItem.Click += registroTotalToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(62, 39, 35);
            label2.Location = new Point(293, 426);
            label2.Name = "label2";
            label2.Size = new Size(224, 15);
            label2.TabIndex = 2;
            label2.Text = "Powered by Javier Álvarez Nicole Salgado";
            // 
            // Biblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Biblioteca";
            Text = "Biblioteca";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionDeLibrosToolStripMenuItem;
        private ToolStripMenuItem prestamoToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem prestamosToolStripMenuItem;
        private ToolStripMenuItem devolucionesToolStripMenuItem;
        private ToolStripMenuItem registroTotalToolStripMenuItem;
        private Label label2;
    }
}
