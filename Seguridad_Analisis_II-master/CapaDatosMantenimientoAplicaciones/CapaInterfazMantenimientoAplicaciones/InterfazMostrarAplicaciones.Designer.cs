namespace CapaInterfazMantenimientoAplicaciones
{
    partial class InterfazMostrarAplicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazMostrarAplicaciones));
            this.Dgv_aplicaciones = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_Consultas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_aplicaciones
            // 
            this.Dgv_aplicaciones.AllowUserToAddRows = false;
            this.Dgv_aplicaciones.AllowUserToDeleteRows = false;
            this.Dgv_aplicaciones.AllowUserToOrderColumns = true;
            this.Dgv_aplicaciones.AllowUserToResizeColumns = false;
            this.Dgv_aplicaciones.AllowUserToResizeRows = false;
            this.Dgv_aplicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_aplicaciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_aplicaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_aplicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_aplicaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_aplicaciones.EnableHeadersVisualStyles = false;
            this.Dgv_aplicaciones.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dgv_aplicaciones.Location = new System.Drawing.Point(36, 98);
            this.Dgv_aplicaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_aplicaciones.Name = "Dgv_aplicaciones";
            this.Dgv_aplicaciones.RowHeadersVisible = false;
            this.Dgv_aplicaciones.Size = new System.Drawing.Size(836, 505);
            this.Dgv_aplicaciones.TabIndex = 24;
            this.Dgv_aplicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_aplicaciones_CellClick);
            this.Dgv_aplicaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_aplicaciones_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(102)))), ((int)(((byte)(106)))));
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(36, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 2);
            this.panel3.TabIndex = 23;
            // 
            // Lbl_Consultas
            // 
            this.Lbl_Consultas.AutoSize = true;
            this.Lbl_Consultas.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Consultas.Location = new System.Drawing.Point(44, 20);
            this.Lbl_Consultas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Consultas.Name = "Lbl_Consultas";
            this.Lbl_Consultas.Size = new System.Drawing.Size(485, 47);
            this.Lbl_Consultas.TabIndex = 22;
            this.Lbl_Consultas.Text = "Consultas Aplicaciones";
            // 
            // InterfazMostrarAplicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(192)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(911, 644);
            this.Controls.Add(this.Dgv_aplicaciones);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Lbl_Consultas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfazMostrarAplicaciones";
            this.Text = "InterfazMostrarAplicaciones";
            this.Load += new System.EventHandler(this.InterfazMostrarAplicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aplicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_aplicaciones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Lbl_Consultas;
    }
}