using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaDatosMantenimientoModulos;

namespace CapaInterfazIngresoModulos
{
    public partial class Interfaz_Consultar_Modulos : Form
    {
        public Interfaz_Consultar_Modulos()
        {
            InitializeComponent();
        }

        private void InterfazConsultarModulos_Load(object sender, EventArgs e)
        {
            DataSet ds;
            DatosMantenimientoModulos dmm = new DatosMantenimientoModulos();
            ds = dmm.ConsultarDatosModulo();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_reference = "";
            InterfazModificarModulos imu = new InterfazModificarModulos();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[1].Value);
            }
            imu.DatosAModificarModulo = Id_reference;
            this.Hide();
            imu.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
