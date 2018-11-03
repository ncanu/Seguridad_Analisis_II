using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaMantenimientoUsuarios;
using CapaDatosMantenimientoUsuarios;

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class CambioContraseñaUsuarios : Form
    {
        public CambioContraseñaUsuarios()
        {
            InitializeComponent();
        }
        public string UsuarioActual = "";

        private void button1_Click(object sender, EventArgs e)
        {
            LogicaMantenimientoUsuarios lmu = new LogicaMantenimientoUsuarios();
            lmu.ValidarModificarCambioDeContraseña(textBox2.Text, textBox1.Text, textBox5.Text);
        }

        private void CambioContraseñaUsuarios_Load(object sender, EventArgs e)
        {
            if(UsuarioActual != "")
            {
                textBox2.Text = UsuarioActual;
            }else
            {
                MessageBox.Show("No se ha encontrado usuario. ", "ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.PasswordChar == '*')
            {
                textBox5.PasswordChar = '\0';
            }
            else if (textBox5.PasswordChar == '\0')
            {
                textBox5.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            string[] h;
            h = new string[2];
            h = dmu.cargarDatos1(UsuarioActual);
            textBox1.Text = h[0];
            textBox5.Text = h[1];
        }
    }
}
