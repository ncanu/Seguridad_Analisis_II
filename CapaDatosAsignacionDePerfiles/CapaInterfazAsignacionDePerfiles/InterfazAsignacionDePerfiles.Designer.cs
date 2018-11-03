namespace CapaInterfazAsignacionDePerfiles
{
    partial class InterfazAsignacionDePerfiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazAsignacionDePerfiles));
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.Cbo_usuarios = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_asignacionPerfiles = new System.Windows.Forms.Label();
            this.Dgv_asignacion = new System.Windows.Forms.DataGridView();
            this.Dgv_asignacion2 = new System.Windows.Forms.DataGridView();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_quitar = new System.Windows.Forms.Button();
            this.Txt_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.AutoSize = true;
            this.Lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(79, 126);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(69, 19);
            this.Lbl_usuario.TabIndex = 52;
            this.Lbl_usuario.Text = "Usuario:";
            this.Lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Cbo_usuarios
            // 
            this.Cbo_usuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_usuarios.FormattingEnabled = true;
            this.Cbo_usuarios.Location = new System.Drawing.Point(243, 123);
            this.Cbo_usuarios.Name = "Cbo_usuarios";
            this.Cbo_usuarios.Size = new System.Drawing.Size(457, 27);
            this.Cbo_usuarios.TabIndex = 50;
            this.Cbo_usuarios.SelectedIndexChanged += new System.EventHandler(this.Cbo_usuarios_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(40, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 1);
            this.panel3.TabIndex = 49;
            // 
            // Lbl_asignacionPerfiles
            // 
            this.Lbl_asignacionPerfiles.AutoSize = true;
            this.Lbl_asignacionPerfiles.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_asignacionPerfiles.Location = new System.Drawing.Point(35, 53);
            this.Lbl_asignacionPerfiles.Name = "Lbl_asignacionPerfiles";
            this.Lbl_asignacionPerfiles.Size = new System.Drawing.Size(311, 32);
            this.Lbl_asignacionPerfiles.TabIndex = 48;
            this.Lbl_asignacionPerfiles.Text = "Asignacion  De Perfiles";
            // 
            // Dgv_asignacion
            // 
            this.Dgv_asignacion.AllowUserToAddRows = false;
            this.Dgv_asignacion.AllowUserToDeleteRows = false;
            this.Dgv_asignacion.AllowUserToOrderColumns = true;
            this.Dgv_asignacion.AllowUserToResizeColumns = false;
            this.Dgv_asignacion.AllowUserToResizeRows = false;
            this.Dgv_asignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_asignacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_asignacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion.EnableHeadersVisualStyles = false;
            this.Dgv_asignacion.Location = new System.Drawing.Point(83, 171);
            this.Dgv_asignacion.Name = "Dgv_asignacion";
            this.Dgv_asignacion.RowHeadersVisible = false;
            this.Dgv_asignacion.Size = new System.Drawing.Size(269, 308);
            this.Dgv_asignacion.TabIndex = 53;
            this.Dgv_asignacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asignacion_CellContentClick);
            this.Dgv_asignacion.SelectionChanged += new System.EventHandler(this.Dgv_asignacion_SelectionChanged);
            // 
            // Dgv_asignacion2
            // 
            this.Dgv_asignacion2.AllowUserToAddRows = false;
            this.Dgv_asignacion2.AllowUserToDeleteRows = false;
            this.Dgv_asignacion2.AllowUserToOrderColumns = true;
            this.Dgv_asignacion2.AllowUserToResizeColumns = false;
            this.Dgv_asignacion2.AllowUserToResizeRows = false;
            this.Dgv_asignacion2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_asignacion2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_asignacion2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_asignacion2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_asignacion2.EnableHeadersVisualStyles = false;
            this.Dgv_asignacion2.Location = new System.Drawing.Point(430, 171);
            this.Dgv_asignacion2.Name = "Dgv_asignacion2";
            this.Dgv_asignacion2.RowHeadersVisible = false;
            this.Dgv_asignacion2.Size = new System.Drawing.Size(269, 308);
            this.Dgv_asignacion2.TabIndex = 54;
            this.Dgv_asignacion2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_asignacion2_CellContentClick);
            this.Dgv_asignacion2.SelectionChanged += new System.EventHandler(this.Dgv_asignacion2_SelectionChanged);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_agregar.Location = new System.Drawing.Point(357, 224);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(67, 68);
            this.Btn_agregar.TabIndex = 55;
            this.Btn_agregar.Tag = "";
            this.Btn_agregar.Text = ">";
            this.Btn_agregar.UseVisualStyleBackColor = false;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Btn_quitar.FlatAppearance.BorderSize = 0;
            this.Btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_quitar.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_quitar.Location = new System.Drawing.Point(357, 298);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(67, 68);
            this.Btn_quitar.TabIndex = 56;
            this.Btn_quitar.Text = "<";
            this.Btn_quitar.UseVisualStyleBackColor = false;
            this.Btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // Txt_usuario
            // 
            this.Txt_usuario.Location = new System.Drawing.Point(148, 123);
            this.Txt_usuario.Name = "Txt_usuario";
            this.Txt_usuario.ReadOnly = true;
            this.Txt_usuario.Size = new System.Drawing.Size(90, 27);
            this.Txt_usuario.TabIndex = 57;
            this.Txt_usuario.TextChanged += new System.EventHandler(this.Txt_usuario_TextChanged);
            // 
            // InterfazAsignacionDePerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(917, 661);
            this.Controls.Add(this.Txt_usuario);
            this.Controls.Add(this.Btn_quitar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Dgv_asignacion2);
            this.Controls.Add(this.Dgv_asignacion);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Cbo_usuarios);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lbl_asignacionPerfiles);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfazAsignacionDePerfiles";
            this.Text = "Interfaz_Asignacion_De_Perfiles";
            this.Load += new System.EventHandler(this.InterfazAsignacionDePerfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_asignacion2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.ComboBox Cbo_usuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_asignacionPerfiles;
        private System.Windows.Forms.DataGridView Dgv_asignacion;
        private System.Windows.Forms.DataGridView Dgv_asignacion2;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_quitar;
        private System.Windows.Forms.TextBox Txt_usuario;
    }
}