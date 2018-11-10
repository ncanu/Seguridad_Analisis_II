using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosMantenimientoAplicaciones;

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazMostrarAplicaciones : Form
    {
        public InterfazMostrarAplicaciones()
        {
            InitializeComponent();
        }

        private void InterfazMostrarAplicaciones_Load(object sender, EventArgs e)
        {
            DataSet ds;
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            ds = dmm.ConsultarDatosAplicacion();
            Dgv_aplicaciones.DataSource = ds.Tables[0];
        }

        private void Dgv_aplicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_reference = "";
            InterfazModificarAplicaciones imu = new InterfazModificarAplicaciones();
            if (Dgv_aplicaciones.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_aplicaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_aplicaciones.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[1].Value);
            }
            imu.DatosAModificarAplicaciones = Id_reference;
            this.Hide();
            imu.Show();
        }

        private void Dgv_aplicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
