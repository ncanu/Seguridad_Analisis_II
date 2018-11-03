using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetornoCadenaDeConexion;
using System.Data.Odbc;
using System.Text.RegularExpressions;
using CapaLogicaMantenimientoUsuarios;
using CapaDatosMantenimientoUsuarios;
using System.IO;

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class Interfaz_Modificar_Usuarios : Form
    {
        public Interfaz_Modificar_Usuarios()
        {
            InitializeComponent();
        }
        public void clean()
        {
            Cbo_usuario_modificar.SelectedIndex = 0;
            textBox5.Text = "";
            textBox1.Text = "";
            Cbo_estado.SelectedIndex = 0;
        }

        public string DatosAModificarUsuario = "";

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

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {

            //Validar caracteres
            Regex reg = new Regex(@"(?=.*\d)(?=.*[a-zA-Z]).*$");
            if (reg.IsMatch(textBox1.Text))
            {
                //Guardad
                LogicaMantenimientoUsuarios lmu = new LogicaMantenimientoUsuarios();
                lmu.ValidarModificarDatosDeUsuarios(Cbo_usuario_modificar.Text, textBox1.Text, textBox5.Text, Cbo_estado.Text);
                cargarDatosaTextBox1();
                //Fin guardar
            }
            else
            {
                MessageBox.Show("El nombre de usuario debe ser alfanumerico ", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }

           
        }

        private void InterfazModificarUsuarios_Load(object sender, EventArgs e)
        {
            Cbo_estado.SelectedIndex = 0;
            if (Cbo_usuario_modificar.Text != "")
            {
                Btn_modificar.Enabled = true;
            }
            else
            {
                Btn_modificar.Enabled = false;
            }
            cargarDatosaTextBox1();
        }

        public void cargarDatosaTextBox1()
        {
            Cbo_usuario_modificar.Items.Clear();
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader Reader;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT usu_nickname FROM TBL_Usuario";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                Cbo_usuario_modificar.Items.Add(Reader["usu_nickname"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_usuario_modificar.Text = DatosAModificarUsuario;
                if (Cbo_usuario_modificar.Text == "")
                {
                    Cbo_usuario_modificar.SelectedIndex = 0;
                }
                else
                {
                    cargarDatosaTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        public void cargarDatosaTextBox()
        {
            string[] h = { "" };
            h = new string[3];
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            h = dmu.cargarDatos1(Cbo_usuario_modificar.Text);
            textBox1.Text = h[0];
            textBox5.Text = h[1];
            if (h[2] == "0")
            {
                Cbo_estado.Text = "Inactivo";
            }
            else
            {
                Cbo_estado.Text = "Activo";
            }
            if(textBox1.Text != "")
            {
                Btn_modificar.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarDatosaTextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Cbo_usuario_modificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_modificar.Enabled = false;
        }

        private void Cbo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Interfaz_Modificar_Usuarios_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string rutaCompleta = "" + Path.GetDirectoryName(Environment.CurrentDirectory) + @"\ayudabitacora\ayuda.chm";
            Help.ShowHelp(this, rutaCompleta, "AyudaBitacora.html#ayudabitacora");
        }
    }
}
