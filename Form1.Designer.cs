namespace diabloide
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSangre = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtLastname2 = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgPersonas = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(14, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtSangre
            // 
            this.txtSangre.Location = new System.Drawing.Point(156, 154);
            this.txtSangre.Name = "txtSangre";
            this.txtSangre.Size = new System.Drawing.Size(100, 20);
            this.txtSangre.TabIndex = 3;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(156, 98);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidad.TabIndex = 4;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(156, 41);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(100, 20);
            this.txtOcupacion.TabIndex = 5;
            // 
            // txtLastname2
            // 
            this.txtLastname2.Location = new System.Drawing.Point(14, 154);
            this.txtLastname2.Name = "txtLastname2";
            this.txtLastname2.Size = new System.Drawing.Size(100, 20);
            this.txtLastname2.TabIndex = 6;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(14, 98);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 7;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(316, 41);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 8;
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Location = new System.Drawing.Point(316, 124);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(74, 17);
            this.cbMale.TabIndex = 9;
            this.cbMale.Text = "Masculino";
            this.cbMale.UseVisualStyleBackColor = true;
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Location = new System.Drawing.Point(316, 154);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(72, 17);
            this.cbFemale.TabIndex = 10;
            this.cbFemale.Text = "Femenino";
            this.cbFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ocupacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Primer Apellido: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nacionalidad: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Segundo Apellido: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sangre: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sexo: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(313, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha de Nacimiento: ";
            // 
            // dgPersonas
            // 
            this.dgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonas.Location = new System.Drawing.Point(546, 12);
            this.dgPersonas.Name = "dgPersonas";
            this.dgPersonas.Size = new System.Drawing.Size(465, 183);
            this.dgPersonas.TabIndex = 19;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.dtFecha);
            this.gbDatos.Controls.Add(this.txtName);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.txtSangre);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.txtNacionalidad);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtOcupacion);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txtLastname2);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.txtLastname);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.cbMale);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.cbFemale);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(528, 183);
            this.gbDatos.TabIndex = 20;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(168, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonas)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSangre;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtLastname2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgPersonas;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button button1;
    }
}

