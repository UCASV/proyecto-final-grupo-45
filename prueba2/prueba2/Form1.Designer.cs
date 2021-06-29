namespace prueba2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbenfermedadescronicas = new System.Windows.Forms.ComboBox();
            this.cmbgruposprioridad = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.eperror = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnprechequeo = new System.Windows.Forms.Button();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtfechaDos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).BeginInit();
            this.SuspendLayout();
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(714, 76);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(67, 36);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DUI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion de Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Grupos de prioridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enfermedades Cronicas";
            // 
            // cmbenfermedadescronicas
            // 
            this.cmbenfermedadescronicas.FormattingEnabled = true;
            this.cmbenfermedadescronicas.Items.AddRange(new object[] {
            "Renal cronica",
            "Pacientes Oncologicos",
            "Diabetes",
            "otro",
            "Ninguno"});
            this.cmbenfermedadescronicas.Location = new System.Drawing.Point(558, 135);
            this.cmbenfermedadescronicas.Name = "cmbenfermedadescronicas";
            this.cmbenfermedadescronicas.Size = new System.Drawing.Size(121, 21);
            this.cmbenfermedadescronicas.TabIndex = 25;
            this.cmbenfermedadescronicas.Validated += new System.EventHandler(this.cmbenfermedadescronicas_Validated);
            // 
            // cmbgruposprioridad
            // 
            this.cmbgruposprioridad.FormattingEnabled = true;
            this.cmbgruposprioridad.Items.AddRange(new object[] {
            "personal de salud",
            "seguridad nacional",
            "Discapacitados",
            "Gobierno Central",
            "Ninguno"});
            this.cmbgruposprioridad.Location = new System.Drawing.Point(685, 135);
            this.cmbgruposprioridad.Name = "cmbgruposprioridad";
            this.cmbgruposprioridad.Size = new System.Drawing.Size(114, 21);
            this.cmbgruposprioridad.TabIndex = 27;
            this.cmbgruposprioridad.Validated += new System.EventHandler(this.cmbgruposprioridad_Validated);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 224);
            this.dataGridView1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Edad";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(516, 18);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(81, 25);
            this.btnbuscar.TabIndex = 31;
            this.btnbuscar.Text = "Buscar DUI";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(287, 17);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(208, 20);
            this.txtbuscar.TabIndex = 32;
            this.txtbuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 36);
            this.button1.TabIndex = 33;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(155, 24);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 13);
            this.lblfecha.TabIndex = 34;
            // 
            // eperror
            // 
            this.eperror.ContainerControl = this;
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(403, 165);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(121, 20);
            this.txtfecha.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "1ra fecha de vacunacion";
            // 
            // btnprechequeo
            // 
            this.btnprechequeo.Location = new System.Drawing.Point(703, 421);
            this.btnprechequeo.Name = "btnprechequeo";
            this.btnprechequeo.Size = new System.Drawing.Size(96, 25);
            this.btnprechequeo.TabIndex = 37;
            this.btnprechequeo.Text = "PRECHEQUEO";
            this.btnprechequeo.UseVisualStyleBackColor = true;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Location = new System.Drawing.Point(287, 136);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(255, 20);
            this.txtdomicilio.TabIndex = 8;
            this.txtdomicilio.Validated += new System.EventHandler(this.txtdomicilio_Validated);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(224, 136);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(57, 20);
            this.txtedad.TabIndex = 30;
            this.txtedad.TextChanged += new System.EventHandler(this.txtedad_TextChanged);
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress);
            this.txtedad.Validated += new System.EventHandler(this.txtedad_Validated);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(118, 136);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            this.txtnombre.Validated += new System.EventHandler(this.txtnombre_Validated);
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(12, 136);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(100, 20);
            this.txtDUI.TabIndex = 7;
            this.txtDUI.TextChanged += new System.EventHandler(this.txtDUI_TextChanged);
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDUI_KeyPress);
            this.txtDUI.Validated += new System.EventHandler(this.txtDUI_Validated);
            // 
            // txtfechaDos
            // 
            this.txtfechaDos.Enabled = false;
            this.txtfechaDos.Location = new System.Drawing.Point(675, 162);
            this.txtfechaDos.Name = "txtfechaDos";
            this.txtfechaDos.Size = new System.Drawing.Size(121, 20);
            this.txtfechaDos.TabIndex = 38;
            this.txtfechaDos.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "2ra fecha de vacunacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 451);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtfechaDos);
            this.Controls.Add(this.btnprechequeo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbgruposprioridad);
            this.Controls.Add(this.cmbenfermedadescronicas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnagregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eperror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.ErrorProvider eperror;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnprechequeo;
        public System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmbenfermedadescronicas;
        public System.Windows.Forms.ComboBox cmbgruposprioridad;
        public System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.TextBox txtbuscar;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtfecha;
        public System.Windows.Forms.TextBox txtedad;
        public System.Windows.Forms.TextBox txtdomicilio;
        public System.Windows.Forms.TextBox txtDUI;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtfechaDos;
    }
}

