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
using RetornoCadenaDeConexion;
using CapaDatosMantenimientoAplicaciones;
using CapaLogicaMantenimientoAplicaciones;
using System.Data.Odbc;

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazModificarAplicaciones : Form
    {
        public InterfazModificarAplicaciones()
        {
            InitializeComponent();
        }

        public string DatosAModificarAplicaciones;

        private void InterfazModificarAplicaciones_Load(object sender, EventArgs e)
        {
            cargarDatosaTxt_Nombre_App_Modificar();
            cargarDatosaTextBox2();
        }
        public void cargarDatosaTxt_Nombre_App_Modificar()
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
                            cmd.CommandText = "SELECT modulo_nombre FROM TBL_Modulo";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                Cbo_Nombre_Modulo.Items.Add(Reader["modulo_nombre"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_Nombre_Modulo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        public void cargarDatosaTextBox2()
        {
            Cbo_App_Modificar.Items.Clear();
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
                            cmd.CommandText = "SELECT api_descripcion FROM TBL_Aplicacion";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                Cbo_App_Modificar.Items.Add(Reader["api_descripcion"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_App_Modificar.Text = DatosAModificarAplicaciones;
                if (Cbo_App_Modificar.Text == "")
                {
                    Cbo_App_Modificar.SelectedIndex = 0;
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
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            h = dmm.cargarDatos1(Txt_Nombre_App_Modificar.Text);
            Txt_CodigoApp.Text = h[0];
            Txt_NombreApp.Text = h[1];
            Cbo_Nombre_Modulo.Text = h[2];
            if (Txt_Nombre_App_Modificar.Text != "")
            {
                Btn_modificar.Enabled = true;
                Btn_eliminar.Enabled = true;
            }
        }

        private void Cbo_Nombre_Modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            Txt_Nombre_Modulo.Text = dmm.ExtraerCodigoDeModulo(Cbo_Nombre_Modulo.Text);
        }

        private void Cbo_App_Modificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            Txt_Nombre_App_Modificar.Text = dmm.ExtraerCodigoDeAplicacion(Cbo_App_Modificar.Text);
            cargarDatosaTextBox();
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(Txt_CodigoApp.Text))
            {
                //Guardar
                LogicaMantenimientoAplicaciones lmm = new LogicaMantenimientoAplicaciones();
                lmm.ValidarModificarDatosAplicaciones(Txt_Nombre_App_Modificar.Text, Txt_CodigoApp.Text, Txt_NombreApp.Text, Txt_Nombre_Modulo.Text);
                cargarDatosaTextBox2();
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_CodigoApp.Focus();
            }
            
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            dmm.EliminarDatosModulos(Txt_Nombre_App_Modificar.Text);
            cargarDatosaTextBox2();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txt_Nombre_App_Modificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
