using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BITACORA;
using CapaLogicaMantenimientoUsuarios;
using System.IO;

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class InterfazCrearUsuarios : Form
    {
        public InterfazCrearUsuarios()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Txt_contra.PasswordChar == '*')
            {
                Txt_contra.PasswordChar = '\0';
            }
            else if (Txt_contra.PasswordChar == '\0')
            {
                Txt_contra.PasswordChar = '*';
            }
        }

        public void clean()
        {
            Txt_Nombre.Text = "";
            Txt_contra.Text = "";
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Validar caracteres
            
            Regex reg = new Regex(@"(?=.*\d)(?=.*[a-zA-Z]).*$");
            if (reg.IsMatch(Txt_Nombre.Text))
            {
                if (Txt_contra.Text != textBox1.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    //Guardad
                    LogicaMantenimientoUsuarios lmu = new LogicaMantenimientoUsuarios();
                    lmu.ValidarInsertarDatosDeUsuarios(Txt_Nombre.Text, Txt_contra.Text);
                    clean();
                    //Fin guardar
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario debe ser alfanumerico ", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Nombre.Focus();
            }

           

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_contra_TextChanged(object sender, EventArgs e)
        {

        }

        private void InterfazCrearUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InterfazCrearUsuarios_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string rutaCompleta = "" + Path.GetDirectoryName(Environment.CurrentDirectory) + @"\ayudabitacora\ayuda.chm";
            Help.ShowHelp(this,rutaCompleta, "AyudaBitacora.html#ayudabitacora");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '*')
            {
                textBox1.PasswordChar = '\0';
            }
            else if (textBox1.PasswordChar == '\0')
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
