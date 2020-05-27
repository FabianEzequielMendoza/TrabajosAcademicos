namespace Control_Aleatorio_Covid_19_Mendoza_Fabian
{
    partial class Formulario
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
            this.lblTituloCovid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTos = new System.Windows.Forms.ComboBox();
            this.cmbAgotamiento = new System.Windows.Forms.ComboBox();
            this.cmbDolor = new System.Windows.Forms.ComboBox();
            this.chkDeclaracion = new System.Windows.Forms.CheckBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmbFiebre = new System.Windows.Forms.ComboBox();
            this.txtEnviarSintoma = new System.Windows.Forms.TextBox();
            this.txtEnviarSalida = new System.Windows.Forms.TextBox();
            this.txtEnviarDirecto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloCovid
            // 
            this.lblTituloCovid.AutoSize = true;
            this.lblTituloCovid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCovid.Location = new System.Drawing.Point(134, 50);
            this.lblTituloCovid.Name = "lblTituloCovid";
            this.lblTituloCovid.Size = new System.Drawing.Size(532, 32);
            this.lblTituloCovid.TabIndex = 1;
            this.lblTituloCovid.Text = "DECLARACIÓN JURADA DE SÍNTOMAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿TIENE FIEBRE?\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "¿TIENE TOS SECA?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "¿SIENTE AGOTAMIENTO?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "¿SIENTE DOLOR EN EL CUERPO?";
            // 
            // cmbTos
            // 
            this.cmbTos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTos.FormattingEnabled = true;
            this.cmbTos.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbTos.Location = new System.Drawing.Point(338, 181);
            this.cmbTos.Name = "cmbTos";
            this.cmbTos.Size = new System.Drawing.Size(121, 21);
            this.cmbTos.TabIndex = 7;
            // 
            // cmbAgotamiento
            // 
            this.cmbAgotamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgotamiento.FormattingEnabled = true;
            this.cmbAgotamiento.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbAgotamiento.Location = new System.Drawing.Point(338, 241);
            this.cmbAgotamiento.Name = "cmbAgotamiento";
            this.cmbAgotamiento.Size = new System.Drawing.Size(121, 21);
            this.cmbAgotamiento.TabIndex = 8;
            // 
            // cmbDolor
            // 
            this.cmbDolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDolor.FormattingEnabled = true;
            this.cmbDolor.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbDolor.Location = new System.Drawing.Point(338, 301);
            this.cmbDolor.Name = "cmbDolor";
            this.cmbDolor.Size = new System.Drawing.Size(121, 21);
            this.cmbDolor.TabIndex = 9;
            // 
            // chkDeclaracion
            // 
            this.chkDeclaracion.AutoSize = true;
            this.chkDeclaracion.Location = new System.Drawing.Point(96, 381);
            this.chkDeclaracion.Name = "chkDeclaracion";
            this.chkDeclaracion.Size = new System.Drawing.Size(454, 30);
            this.chkDeclaracion.TabIndex = 10;
            this.chkDeclaracion.Text = "DECLARO BAJO JURAMENTO QUE LOS DATOS VOLCADOS EN ESTE FORMULARIO \r\nGUARDAN RELACI" +
    "ÓN CON LA REALIDAD.";
            this.chkDeclaracion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkDeclaracion.UseVisualStyleBackColor = true;
            this.chkDeclaracion.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(338, 445);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 41);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // cmbFiebre
            // 
            this.cmbFiebre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiebre.FormattingEnabled = true;
            this.cmbFiebre.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbFiebre.Location = new System.Drawing.Point(338, 121);
            this.cmbFiebre.Name = "cmbFiebre";
            this.cmbFiebre.Size = new System.Drawing.Size(121, 21);
            this.cmbFiebre.TabIndex = 12;
            // 
            // txtEnviarSintoma
            // 
            this.txtEnviarSintoma.Location = new System.Drawing.Point(629, 121);
            this.txtEnviarSintoma.Name = "txtEnviarSintoma";
            this.txtEnviarSintoma.Size = new System.Drawing.Size(100, 20);
            this.txtEnviarSintoma.TabIndex = 13;
            this.txtEnviarSintoma.Text = "0";
            this.txtEnviarSintoma.Visible = false;
            // 
            // txtEnviarSalida
            // 
            this.txtEnviarSalida.Location = new System.Drawing.Point(629, 181);
            this.txtEnviarSalida.Name = "txtEnviarSalida";
            this.txtEnviarSalida.Size = new System.Drawing.Size(100, 20);
            this.txtEnviarSalida.TabIndex = 14;
            this.txtEnviarSalida.Text = "0";
            this.txtEnviarSalida.Visible = false;
            // 
            // txtEnviarDirecto
            // 
            this.txtEnviarDirecto.Location = new System.Drawing.Point(629, 241);
            this.txtEnviarDirecto.Name = "txtEnviarDirecto";
            this.txtEnviarDirecto.Size = new System.Drawing.Size(100, 20);
            this.txtEnviarDirecto.TabIndex = 15;
            this.txtEnviarDirecto.Text = "0";
            this.txtEnviarDirecto.Visible = false;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 523);
            this.Controls.Add(this.txtEnviarDirecto);
            this.Controls.Add(this.txtEnviarSalida);
            this.Controls.Add(this.txtEnviarSintoma);
            this.Controls.Add(this.cmbFiebre);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.chkDeclaracion);
            this.Controls.Add(this.cmbDolor);
            this.Controls.Add(this.cmbAgotamiento);
            this.Controls.Add(this.cmbTos);
            this.Controls.Add(this.lblTituloCovid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCovid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTos;
        private System.Windows.Forms.ComboBox cmbAgotamiento;
        private System.Windows.Forms.ComboBox cmbDolor;
        private System.Windows.Forms.CheckBox chkDeclaracion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cmbFiebre;
        public System.Windows.Forms.TextBox txtEnviarSintoma;
        public System.Windows.Forms.TextBox txtEnviarSalida;
        public System.Windows.Forms.TextBox txtEnviarDirecto;
    }
}