namespace CapaInterfazMantenimientoAplicaciones
{
    partial class InterfazIngresarDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazIngresarDocumento));
            this.Txt_codigoAppi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_nombre_appi = new System.Windows.Forms.ComboBox();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_NombreDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_CodigoDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Ruta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Txt_codigoAppi
            // 
            this.Txt_codigoAppi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigoAppi.Location = new System.Drawing.Point(287, 293);
            this.Txt_codigoAppi.Name = "Txt_codigoAppi";
            this.Txt_codigoAppi.ReadOnly = true;
            this.Txt_codigoAppi.Size = new System.Drawing.Size(82, 27);
            this.Txt_codigoAppi.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "Nombre de la aplicacion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cbo_nombre_appi
            // 
            this.Cbo_nombre_appi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_nombre_appi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_nombre_appi.FormattingEnabled = true;
            this.Cbo_nombre_appi.Location = new System.Drawing.Point(375, 292);
            this.Cbo_nombre_appi.Name = "Cbo_nombre_appi";
            this.Cbo_nombre_appi.Size = new System.Drawing.Size(110, 29);
            this.Cbo_nombre_appi.TabIndex = 92;
            this.Cbo_nombre_appi.SelectedIndexChanged += new System.EventHandler(this.Cbo_nombre_modulo_SelectedIndexChanged);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_limpiar.Image = global::CapaInterfazMantenimientoAplicaciones.Properties.Resources.Refresh_32x32;
            this.Btn_limpiar.Location = new System.Drawing.Point(431, 339);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(53, 45);
            this.Btn_limpiar.TabIndex = 91;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_limpiar.UseVisualStyleBackColor = false;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_guardar.BackgroundImage = global::CapaInterfazMantenimientoAplicaciones.Properties.Resources.Save_32x32;
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_guardar.Location = new System.Drawing.Point(361, 339);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(53, 45);
            this.Btn_guardar.TabIndex = 90;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Txt_NombreDoc
            // 
            this.Txt_NombreDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreDoc.Location = new System.Drawing.Point(286, 191);
            this.Txt_NombreDoc.Name = "Txt_NombreDoc";
            this.Txt_NombreDoc.Size = new System.Drawing.Size(199, 27);
            this.Txt_NombreDoc.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 19);
            this.label6.TabIndex = 88;
            this.label6.Text = "Nombre de Documento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Txt_CodigoDoc
            // 
            this.Txt_CodigoDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CodigoDoc.Location = new System.Drawing.Point(286, 135);
            this.Txt_CodigoDoc.Name = "Txt_CodigoDoc";
            this.Txt_CodigoDoc.Size = new System.Drawing.Size(199, 27);
            this.Txt_CodigoDoc.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 19);
            this.label5.TabIndex = 86;
            this.label5.Text = "Codigo de Documento:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(45, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 1);
            this.panel3.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 32);
            this.label2.TabIndex = 84;
            this.label2.Text = "Ingreso de Documentos";
            // 
            // Txt_Ruta
            // 
            this.Txt_Ruta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Ruta.Location = new System.Drawing.Point(287, 243);
            this.Txt_Ruta.Name = "Txt_Ruta";
            this.Txt_Ruta.Size = new System.Drawing.Size(164, 27);
            this.Txt_Ruta.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 95;
            this.label3.Text = "Ruta del documento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(457, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 97;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InterfazIngresarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(607, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_Ruta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_codigoAppi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_nombre_appi);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Txt_NombreDoc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_CodigoDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfazIngresarDocumento";
            this.Text = "InterfazIngresarDocumento";
            this.Load += new System.EventHandler(this.InterfazIngresarDocumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_codigoAppi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_nombre_appi;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.TextBox Txt_NombreDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_CodigoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Ruta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}