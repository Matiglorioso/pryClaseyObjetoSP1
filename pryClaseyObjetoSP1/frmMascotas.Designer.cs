namespace pryClaseyObjetoSP1
{
    partial class frmMascotas
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
            this.mrcMascota = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lstMascotas = new System.Windows.Forms.ListBox();
            this.btnCuidar = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblCuidar = new System.Windows.Forms.Label();
            this.lblJugar = new System.Windows.Forms.Label();
            this.lblAlimentar = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.mrcMascota.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcMascota
            // 
            this.mrcMascota.Controls.Add(this.cmbTipo);
            this.mrcMascota.Controls.Add(this.lblCodigo);
            this.mrcMascota.Controls.Add(this.lblNombre);
            this.mrcMascota.Controls.Add(this.lblPrecio);
            this.mrcMascota.Controls.Add(this.txtNombre);
            this.mrcMascota.Controls.Add(this.txtEdad);
            this.mrcMascota.Location = new System.Drawing.Point(12, 12);
            this.mrcMascota.Name = "mrcMascota";
            this.mrcMascota.Size = new System.Drawing.Size(278, 177);
            this.mrcMascota.TabIndex = 5;
            this.mrcMascota.TabStop = false;
            this.mrcMascota.Text = "Mascota:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(43, 80);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(76, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Tipo de animal";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(113, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de la mascota";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(55, 124);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Edad (años)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(125, 121);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(131, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(655, 78);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(84, 32);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "C&onsultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(325, 28);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(84, 32);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "&Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(325, 155);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 32);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lstMascotas
            // 
            this.lstMascotas.FormattingEnabled = true;
            this.lstMascotas.Location = new System.Drawing.Point(415, 12);
            this.lstMascotas.Name = "lstMascotas";
            this.lstMascotas.Size = new System.Drawing.Size(234, 173);
            this.lstMascotas.TabIndex = 21;
            // 
            // btnCuidar
            // 
            this.btnCuidar.Location = new System.Drawing.Point(21, 262);
            this.btnCuidar.Name = "btnCuidar";
            this.btnCuidar.Size = new System.Drawing.Size(84, 32);
            this.btnCuidar.TabIndex = 4;
            this.btnCuidar.Text = "&Cuidar";
            this.btnCuidar.UseVisualStyleBackColor = true;
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(21, 317);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(84, 32);
            this.btnAlimentar.TabIndex = 5;
            this.btnAlimentar.Text = "&Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(21, 371);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(84, 32);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "&Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // lblCuidar
            // 
            this.lblCuidar.AutoSize = true;
            this.lblCuidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuidar.Location = new System.Drawing.Point(164, 267);
            this.lblCuidar.Name = "lblCuidar";
            this.lblCuidar.Size = new System.Drawing.Size(19, 20);
            this.lblCuidar.TabIndex = 22;
            this.lblCuidar.Text = "0";
            // 
            // lblJugar
            // 
            this.lblJugar.AutoSize = true;
            this.lblJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugar.Location = new System.Drawing.Point(164, 376);
            this.lblJugar.Name = "lblJugar";
            this.lblJugar.Size = new System.Drawing.Size(19, 20);
            this.lblJugar.TabIndex = 26;
            this.lblJugar.Text = "0";
            // 
            // lblAlimentar
            // 
            this.lblAlimentar.AutoSize = true;
            this.lblAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentar.Location = new System.Drawing.Point(164, 322);
            this.lblAlimentar.Name = "lblAlimentar";
            this.lblAlimentar.Size = new System.Drawing.Size(19, 20);
            this.lblAlimentar.TabIndex = 27;
            this.lblAlimentar.Text = "0";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Cabra"});
            this.cmbTipo.Location = new System.Drawing.Point(125, 77);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(131, 21);
            this.cmbTipo.TabIndex = 5;
            // 
            // frmMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.lblAlimentar);
            this.Controls.Add(this.lblJugar);
            this.Controls.Add(this.lblCuidar);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.btnCuidar);
            this.Controls.Add(this.lstMascotas);
            this.Controls.Add(this.mrcMascota);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmMascotas";
            this.Text = "Puto el que lee";
            this.mrcMascota.ResumeLayout(false);
            this.mrcMascota.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcMascota;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstMascotas;
        private System.Windows.Forms.Button btnCuidar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblCuidar;
        private System.Windows.Forms.Label lblJugar;
        private System.Windows.Forms.Label lblAlimentar;
    }
}