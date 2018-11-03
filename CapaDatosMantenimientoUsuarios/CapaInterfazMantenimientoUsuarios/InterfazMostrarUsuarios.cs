using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosMantenimientoUsuarios;
using CapaInterfazMantenimientoUsuarios;
using System.IO;

namespace CapaInterfazMantenimientoUsuarios
{
    public partial class Interfaz_Mostrar_Usuarios : Form
    {
        public Interfaz_Mostrar_Usuarios()
        {
            InitializeComponent();
        }

        private void InterfazMostrarUsuarios_Load(object sender, EventArgs e)
        {
            DataSet ds;
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            ds = dmu.ConsultarDatosDeUsuarios1();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                DataSet ds;
                DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
                ds = dmu.ConsultarDatosDeUsuarios();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                DataSet ds;
                DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
                ds = dmu.ConsultarDatosDeUsuarios1();
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_reference = "";
            Interfaz_Modificar_Usuarios imu = new Interfaz_Modificar_Usuarios();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[1].Value);
            }
            imu.DatosAModificarUsuario = Id_reference;
            this.Hide();
            imu.Show();
        }

        private void Interfaz_Mostrar_Usuarios_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string rutaCompleta = "" + Path.GetDirectoryName(Environment.CurrentDirectory) + @"\ayudabitacora\ayuda.chm";
            Help.ShowHelp(this, rutaCompleta, "AyudaBitacora.html#ayudabitacora");
        }
    }
}
