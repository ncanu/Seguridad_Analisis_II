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
using CapaLogicaMantenimientoAplicaciones;

namespace CapaInterfazMantenimientoAplicaciones
{
    public partial class InterfazMostrarDocumentosRelacionados : Form
    {
        public InterfazMostrarDocumentosRelacionados()
        {
            InitializeComponent();
        }

        string Id_reference = "";

        private void InterfazMostrarDocumentosRelacionados_Load(object sender, EventArgs e)
        {
            DataSet ds;
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            ds = dmm.ConsultarDatosDocumentos();
            Dgv_aplicaciones.DataSource = ds.Tables[0];
        }

        private void Dgv_aplicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv_aplicaciones.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_aplicaciones.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Dgv_aplicaciones.Rows[selectedrowindex];
                Id_reference = Convert.ToString(selectedRow.Cells[0].Value);
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            LogicaMantenimientoAplicaciones lma = new LogicaMantenimientoAplicaciones();
            lma.ValidarBorrarDatosDocumento(Id_reference);
            DataSet ds;
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            ds = dmm.ConsultarDatosDocumentos();
            Dgv_aplicaciones.DataSource = ds.Tables[0];
        }
    }
}
