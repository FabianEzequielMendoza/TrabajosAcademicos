namespace Control_Aleatorio_Covid_19_Mendoza_Fabian
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
            this.lblTituloCovid = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRecibirCantDirectos = new System.Windows.Forms.TextBox();
            this.txtRecibirCantSintoma = new System.Windows.Forms.TextBox();
            this.txtRecibirCantSalida = new System.Windows.Forms.TextBox();
            this.btnPulsarBotón = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOnline = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.txtHisopadoDirecto = new System.Windows.Forms.TextBox();
            this.txtHisopadoSintoma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloCovid
            // 
            this.lblTituloCovid.AutoSize = true;
            this.lblTituloCovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCovid.Location = new System.Drawing.Point(175, 41);
            this.lblTituloCovid.Name = "lblTituloCovid";
            this.lblTituloCovid.Size = new System.Drawing.Size(451, 32);
            this.lblTituloCovid.TabIndex = 0;
            this.lblTituloCovid.Text = "CONTROL ALEATORIO COVID-19";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(84, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 344);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.txtRecibirCantDirectos);
            this.tabPage1.Controls.Add(this.txtRecibirCantSintoma);
            this.tabPage1.Controls.Add(this.txtRecibirCantSalida);
            this.tabPage1.Controls.Add(this.btnPulsarBotón);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 318);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONTROL";
            // 
            // txtRecibirCantDirectos
            // 
            this.txtRecibirCantDirectos.Location = new System.Drawing.Point(487, 196);
            this.txtRecibirCantDirectos.Name = "txtRecibirCantDirectos";
            this.txtRecibirCantDirectos.Size = new System.Drawing.Size(100, 20);
            this.txtRecibirCantDirectos.TabIndex = 18;
            this.txtRecibirCantDirectos.Text = "0";
            this.txtRecibirCantDirectos.Visible = false;
            // 
            // txtRecibirCantSintoma
            // 
            this.txtRecibirCantSintoma.Location = new System.Drawing.Point(487, 122);
            this.txtRecibirCantSintoma.Name = "txtRecibirCantSintoma";
            this.txtRecibirCantSintoma.Size = new System.Drawing.Size(100, 20);
            this.txtRecibirCantSintoma.TabIndex = 17;
            this.txtRecibirCantSintoma.Text = "0";
            this.txtRecibirCantSintoma.Visible = false;
            // 
            // txtRecibirCantSalida
            // 
            this.txtRecibirCantSalida.Location = new System.Drawing.Point(487, 53);
            this.txtRecibirCantSalida.Name = "txtRecibirCantSalida";
            this.txtRecibirCantSalida.Size = new System.Drawing.Size(100, 20);
            this.txtRecibirCantSalida.TabIndex = 16;
            this.txtRecibirCantSalida.Text = "0";
            this.txtRecibirCantSalida.Visible = false;
            // 
            // btnPulsarBotón
            // 
            this.btnPulsarBotón.Location = new System.Drawing.Point(198, 98);
            this.btnPulsarBotón.Name = "btnPulsarBotón";
            this.btnPulsarBotón.Size = new System.Drawing.Size(226, 118);
            this.btnPulsarBotón.TabIndex = 0;
            this.btnPulsarBotón.Text = "PULSE EL BOTÓN";
            this.btnPulsarBotón.UseVisualStyleBackColor = true;
            this.btnPulsarBotón.Click += new System.EventHandler(this.BtnPulsarBotón_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btnOnline);
            this.tabPage2.Controls.Add(this.btnLocal);
            this.tabPage2.Controls.Add(this.txtHisopadoDirecto);
            this.tabPage2.Controls.Add(this.txtHisopadoSintoma);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtCantidadPersonas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 318);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ESTADÍSTICAS";
            // 
            // btnOnline
            // 
            this.btnOnline.Location = new System.Drawing.Point(338, 246);
            this.btnOnline.Name = "btnOnline";
            this.btnOnline.Size = new System.Drawing.Size(121, 41);
            this.btnOnline.TabIndex = 13;
            this.btnOnline.Text = "ONLINE";
            this.btnOnline.UseVisualStyleBackColor = true;
            this.btnOnline.Click += new System.EventHandler(this.BtnOnline_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(81, 246);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(121, 41);
            this.btnLocal.TabIndex = 12;
            this.btnLocal.Text = "LOCAL";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.BtnLocal_Click);
            // 
            // txtHisopadoDirecto
            // 
            this.txtHisopadoDirecto.Location = new System.Drawing.Point(284, 177);
            this.txtHisopadoDirecto.Name = "txtHisopadoDirecto";
            this.txtHisopadoDirecto.ReadOnly = true;
            this.txtHisopadoDirecto.Size = new System.Drawing.Size(126, 20);
            this.txtHisopadoDirecto.TabIndex = 5;
            // 
            // txtHisopadoSintoma
            // 
            this.txtHisopadoSintoma.Location = new System.Drawing.Point(284, 114);
            this.txtHisopadoSintoma.Name = "txtHisopadoSintoma";
            this.txtHisopadoSintoma.ReadOnly = true;
            this.txtHisopadoSintoma.Size = new System.Drawing.Size(126, 20);
            this.txtHisopadoSintoma.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "HISOPADOS DIRECTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "HISOPADOS POR SINTOMAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CANTIDAD DE PERSONAS";
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.Location = new System.Drawing.Point(284, 51);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.ReadOnly = true;
            this.txtCantidadPersonas.Size = new System.Drawing.Size(126, 20);
            this.txtCantidadPersonas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTituloCovid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCovid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnPulsarBotón;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtHisopadoDirecto;
        private System.Windows.Forms.TextBox txtHisopadoSintoma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.Button btnOnline;
        private System.Windows.Forms.Button btnLocal;
        public System.Windows.Forms.TextBox txtRecibirCantSintoma;
        public System.Windows.Forms.TextBox txtRecibirCantDirectos;
        public System.Windows.Forms.TextBox txtRecibirCantSalida;
    }
}

