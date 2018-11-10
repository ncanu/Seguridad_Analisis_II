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
using CapaDatosMantenimientoAplicaciones;
using CapaLogicaMantenimientoAplicaciones;
using RetornoCadenaDeConexion;
using System.Data.Odbc;

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazIngrearAplicaciones : Form
    {
        public InterfazIngrearAplicaciones()
        {
            InitializeComponent();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(Txt_CodigoApp.Text))
            {
                //Guardar
                LogicaMantenimientoAplicaciones lma = new LogicaMantenimientoAplicaciones();
                lma.ValidarInsertarDatosAplicaiones(Txt_CodigoApp.Text, Txt_NombreApp.Text, Txt_nombre_Modulo.Text);
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_CodigoApp.Focus();
            }

        }

        private void InterfazIngrearAplicaciones_Load(object sender, EventArgs e)
        {
            cargarDatosaTxt_nombre_Modulo();
        }
        public void cargarDatosaTxt_nombre_Modulo()
        {
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
                                Cbo_nombre_modulo.Items.Add(Reader["modulo_nombre"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_nombre_modulo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void Cbo_nombre_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            Txt_nombre_Modulo.Text = dmm.ExtraerCodigoDeModulo(Cbo_nombre_modulo.Text);
        }

        private void Txt_CodigoApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NombreApp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_nombre_Modulo_TextChanged(object sender, EventArgs e)
        {

        }

        public void clean()
        {
            Txt_CodigoApp.Text = "";
            Txt_NombreApp.Text = "";
            Cbo_nombre_modulo.SelectedIndex = 0;
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
