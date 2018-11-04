namespace MoverMotorForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCmbPuertos = new System.Windows.Forms.ToolStripComboBox();
            this.velocidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCmbVelocidad = new System.Windows.Forms.ToolStripComboBox();
            this.cerrarPuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPuertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.puertosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirPuertoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.velocidadToolStripMenuItem,
            this.cerrarPuertoToolStripMenuItem});
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.puertosToolStripMenuItem.Text = "Configuracion";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCmbPuertos});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dToolStripMenuItem.Text = "Puertos";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // toolStripCmbPuertos
            // 
            this.toolStripCmbPuertos.Name = "toolStripCmbPuertos";
            this.toolStripCmbPuertos.Size = new System.Drawing.Size(121, 23);
            // 
            // velocidadToolStripMenuItem
            // 
            this.velocidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCmbVelocidad});
            this.velocidadToolStripMenuItem.Name = "velocidadToolStripMenuItem";
            this.velocidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.velocidadToolStripMenuItem.Text = "Velocidad";
            // 
            // toolStripCmbVelocidad
            // 
            this.toolStripCmbVelocidad.Items.AddRange(new object[] {
            "1200",
            "4800",
            "9600",
            "11200"});
            this.toolStripCmbVelocidad.Name = "toolStripCmbVelocidad";
            this.toolStripCmbVelocidad.Size = new System.Drawing.Size(121, 23);
            // 
            // cerrarPuertoToolStripMenuItem
            // 
            this.cerrarPuertoToolStripMenuItem.Name = "cerrarPuertoToolStripMenuItem";
            this.cerrarPuertoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarPuertoToolStripMenuItem.Text = "Cerrar Puerto";
            this.cerrarPuertoToolStripMenuItem.Click += new System.EventHandler(this.cerrarPuertoToolStripMenuItem_Click);
            // 
            // abrirPuertoToolStripMenuItem
            // 
            this.abrirPuertoToolStripMenuItem.Name = "abrirPuertoToolStripMenuItem";
            this.abrirPuertoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirPuertoToolStripMenuItem.Text = "Abrir Puerto";
            this.abrirPuertoToolStripMenuItem.Click += new System.EventHandler(this.abrirPuertoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 147);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripCmbPuertos;
        private System.Windows.Forms.ToolStripMenuItem velocidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripCmbVelocidad;
        private System.Windows.Forms.ToolStripMenuItem cerrarPuertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPuertoToolStripMenuItem;
    }
}

