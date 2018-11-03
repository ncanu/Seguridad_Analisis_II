using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosAsignacionDePerfiles;
using RetornoCadenaDeConexion;
using System.Data.Odbc;
using CapaLogicaAsignacionDePerfiles;

namespace CapaInterfazAsignacionDePerfiles
{
    public partial class InterfazAsignacionDePerfiles : Form
    {
        public InterfazAsignacionDePerfiles()
        {
            InitializeComponent();
        }

        public string DatoDGW1="";
        public string DatoDGW2 = "";

        private void InterfazAsignacionDePerfiles_Load(object sender, EventArgs e)
        {
            DatosAsignacionDePerfiles dadp = new DatosAsignacionDePerfiles();
            DataSet ds = dadp.MostrarDatosDePerfiles();
            Dgv_asignacion.DataSource = ds.Tables[0];

            ////
            Cbo_usuarios.Items.Clear();
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
                                Cbo_usuarios.Items.Add(Reader["usu_nickname"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                Cbo_usuarios.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
        }

        private void Cbo_usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosAsignacionDePerfiles dadp = new DatosAsignacionDePerfiles();
            Txt_usuario.Text = dadp.ExtrarCodigoDeUsuario(Cbo_usuarios.Text);
            DataSet ds = dadp.MostrarDatosDePerfilesDeUsuarios(Cbo_usuarios.Text);
            Dgv_asignacion2.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Btn_agregar.Enabled = true;
            Btn_quitar.Enabled = true;
            DatosAsignacionDePerfiles dadp = new DatosAsignacionDePerfiles();
            DataSet ds = dadp.MostrarDatosDePerfilesDeUsuarios(Cbo_usuarios.Text);
            Dgv_asignacion2.DataSource = ds.Tables[0];
        }

        private void Dgv_asignacion_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_asignacion.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_asignacion.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_asignacion.Rows[selectedrowindex];
                DatoDGW1 = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }

        private void Dgv_asignacion2_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_asignacion2.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_asignacion2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_asignacion2.Rows[selectedrowindex];
                DatoDGW2 = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            LogicaAsignacionDePerfiles ladp = new LogicaAsignacionDePerfiles();
            ladp.ValidarIngresoDeDatosPerfilUsuario(Txt_usuario.Text, DatoDGW1);
            DatosAsignacionDePerfiles dadp = new DatosAsignacionDePerfiles();
            DataSet ds = dadp.MostrarDatosDePerfilesDeUsuarios(Cbo_usuarios.Text);
            Dgv_asignacion2.DataSource = ds.Tables[0];
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            LogicaAsignacionDePerfiles ladp = new LogicaAsignacionDePerfiles();
            ladp.ValidarEliminacionDeDatosPerfilUsuario(Txt_usuario.Text, DatoDGW2);
            DatosAsignacionDePerfiles dadp = new DatosAsignacionDePerfiles();
            DataSet ds = dadp.MostrarDatosDePerfilesDeUsuarios(Cbo_usuarios.Text);
            Dgv_asignacion2.DataSource = ds.Tables[0];
        }

        private void Dgv_asignacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dgv_asignacion2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
