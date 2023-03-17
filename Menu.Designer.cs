namespace PROYECTO
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrinciplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.papaIngresadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convectorDePesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrinciplaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrinciplaToolStripMenuItem
            // 
            this.menuPrinciplaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.papaIngresadaToolStripMenuItem,
            this.convectorDePesoToolStripMenuItem,
            this.mostrarFacturasToolStripMenuItem,
            this.crearUsuarioToolStripMenuItem});
            this.menuPrinciplaToolStripMenuItem.Name = "menuPrinciplaToolStripMenuItem";
            this.menuPrinciplaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrinciplaToolStripMenuItem.Text = "Menu Principal";
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // papaIngresadaToolStripMenuItem
            // 
            this.papaIngresadaToolStripMenuItem.Name = "papaIngresadaToolStripMenuItem";
            this.papaIngresadaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.papaIngresadaToolStripMenuItem.Text = "Papa Ingresada";
            // 
            // convectorDePesoToolStripMenuItem
            // 
            this.convectorDePesoToolStripMenuItem.Name = "convectorDePesoToolStripMenuItem";
            this.convectorDePesoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.convectorDePesoToolStripMenuItem.Text = "Convector de peso";
            // 
            // mostrarFacturasToolStripMenuItem
            // 
            this.mostrarFacturasToolStripMenuItem.Name = "mostrarFacturasToolStripMenuItem";
            this.mostrarFacturasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mostrarFacturasToolStripMenuItem.Text = "Mostrar Facturas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(619, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Crear Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 295);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrinciplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem papaIngresadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convectorDePesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarFacturasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
    }
}

