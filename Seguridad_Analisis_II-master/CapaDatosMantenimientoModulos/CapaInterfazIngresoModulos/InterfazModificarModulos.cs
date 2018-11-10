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
using CapaDatosMantenimientoModulos;
using CapaLogicaMantenimientoModulos;

namespace CapaInterfazIngresoModulos
{
    public partial class InterfazModificarModulos : Form
    {
        public InterfazModificarModulos()
        {
            InitializeComponent();
        }

        public string DatosAModificarModulo;

        private void InterfazModificarModulos_Load(object sender, EventArgs e)
        {
            if (Cbo_modulo.Text != "")
            {
                Btn_modificar.Enabled = true;
                Btn_eliminar.Enabled = true;
            }
            else
            {
                Btn_modificar.Enabled = false;
                Btn_eliminar.Enabled = true;
            }
            cargarDatosaTextBox1();
        }
        public void cargarDatosaTextBox1()
        {
            Cbo_modulo.Items.Clear();
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
                            cmd.CommandText = "SELECT modulo_nombre FROM tbl_modulo";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                Cbo_modulo.Items.Add(Reader["modulo_nombre"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_modulo.Text = DatosAModificarModulo;
                if (Cbo_modulo.Text == "")
                {
                    Cbo_modulo.SelectedIndex = 0;
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
            h = new string[2];
            DatosMantenimientoModulos dmm = new DatosMantenimientoModulos();
            h = dmm.cargarDatos1(textBox1.Text);
            Txt_codigo.Text = h[0];
            Txt_nombre.Text = h[1];
            if (textBox1.Text != "")
            {
                Btn_modificar.Enabled = true;
                Btn_eliminar.Enabled = true;
            }
        }

        private void Cbo_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosMantenimientoModulos dmm = new DatosMantenimientoModulos();
            textBox1.Text = dmm.ExtraerCodigoDeModulo(Cbo_modulo.Text);
            cargarDatosaTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargarDatosaTextBox();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(Txt_codigo.Text))
            {
                //Guardar
                LogicaMantenimientoModulos lmm = new LogicaMantenimientoModulos();
                lmm.ValidarModificarDatosModulos(textBox1.Text, Txt_codigo.Text, Txt_nombre.Text);
                cargarDatosaTextBox1();
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_codigo.Focus();
            }

           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DatosMantenimientoModulos dmm = new DatosMantenimientoModulos();
            dmm.EliminarDatosModulos(textBox1.Text);
            cargarDatosaTextBox1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
