namespace CapaInterfazMantenimientoUsuarios
{
    partial class Interfaz_Modificar_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Modificar_Usuarios));
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_usuario_modificar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_limpiar.BackgroundImage = global::CapaInterfazMantenimientoUsuarios.Properties.Resources.Refresh_32x32;
            this.Btn_limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_limpiar.Location = new System.Drawing.Point(684, 438);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(79, 70);
            this.Btn_limpiar.TabIndex = 41;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_limpiar.UseVisualStyleBackColor = false;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(297, 317);
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '*';
            this.textBox5.Size = new System.Drawing.Size(484, 27);
            this.textBox5.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Contraseña:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nuevo Nombre del Usuario:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(45, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 1);
            this.panel3.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "Modificacion de Datos de Usuarios";
            // 
            // Cbo_usuario_modificar
            // 
            this.Cbo_usuario_modificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_usuario_modificar.FormattingEnabled = true;
            this.Cbo_usuario_modificar.Location = new System.Drawing.Point(297, 203);
            this.Cbo_usuario_modificar.Name = "Cbo_usuario_modificar";
            this.Cbo_usuario_modificar.Size = new System.Drawing.Size(484, 29);
            this.Cbo_usuario_modificar.TabIndex = 43;
            this.Cbo_usuario_modificar.SelectedIndexChanged += new System.EventHandler(this.Cbo_usuario_modificar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre del Usuario a Modificar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(297, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 27);
            this.textBox1.TabIndex = 46;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_estado.Location = new System.Drawing.Point(297, 379);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(517, 29);
            this.Cbo_estado.TabIndex = 48;
            this.Cbo_estado.SelectedIndexChanged += new System.EventHandler(this.Cbo_estado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Estado:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(787, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 44;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(787, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 27);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_modificar.BackgroundImage = global::CapaInterfazMantenimientoUsuarios.Properties.Resources.Edit_32x32;
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_modificar.Enabled = false;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_modificar.Location = new System.Drawing.Point(555, 438);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(79, 70);
            this.Btn_modificar.TabIndex = 40;
            this.Btn_modificar.Text = "Editar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Interfaz_Modificar_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(911, 644);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Cbo_usuario_modificar);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Interfaz_Modificar_Usuarios";
            this.Text = "InterfazModificarUsuarios";
            this.Load += new System.EventHandler(this.InterfazModificarUsuarios_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Interfaz_Modificar_Usuarios_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_usuario_modificar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.Label label3;
    }
}