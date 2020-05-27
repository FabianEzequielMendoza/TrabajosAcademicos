namespace CentralTurnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pantalla = new System.Windows.Forms.RichTextBox();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnAtencionPublico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pantalla
            // 
            this.pantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pantalla.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pantalla.Font = new System.Drawing.Font("Swis721 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantalla.Location = new System.Drawing.Point(399, 33);
            this.pantalla.Name = "pantalla";
            this.pantalla.ReadOnly = true;
            this.pantalla.Size = new System.Drawing.Size(362, 367);
            this.pantalla.TabIndex = 0;
            this.pantalla.Text = "                                      \n\n\n\n\n\n\n\t\t\t\n                                " +
    "              \n                                 ";
            this.pantalla.TextChanged += new System.EventHandler(this.pantalla_TextChanged);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(72, 78);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(240, 65);
            this.BtnClientes.TabIndex = 1;
            this.BtnClientes.Text = "CLIENTES";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnAtencionPublico
            // 
            this.BtnAtencionPublico.Location = new System.Drawing.Point(72, 267);
            this.BtnAtencionPublico.Name = "BtnAtencionPublico";
            this.BtnAtencionPublico.Size = new System.Drawing.Size(240, 65);
            this.BtnAtencionPublico.TabIndex = 3;
            this.BtnAtencionPublico.Text = "ATENCION AL PUBLICO";
            this.BtnAtencionPublico.UseVisualStyleBackColor = true;
            this.BtnAtencionPublico.Click += new System.EventHandler(this.BtnAtencionPublico_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAtencionPublico);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.pantalla);
            this.Name = "Form1";
            this.Text = "Central de turnos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox pantalla;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnAtencionPublico;
    }
}

