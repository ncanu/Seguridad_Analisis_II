using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionPerfiles
{
    public partial class searchProfile : Form
    {
        capaGraficaPerfiles dt = new capaGraficaPerfiles();

        public searchProfile()
        {
            InitializeComponent();
        }


        void getProfiles()
        {
            dataGridView1.DataSource = dt.getAllProfiles();

        }


        void searchProfiles(string name)
        {
            dataGridView1.DataSource = dt.searchProfiles(name);
        }

        void getCurrentRow()
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            string cod = "";
            int referenceCode = 0;
            string name = "";

            cod = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            referenceCode = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            name = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();

            profileMantenimiento frm = new profileMantenimiento();
            frm.Txt_CodPerfil.Text = cod;
            frm.Txt_NombrePerfil.Text = name;
            frm.mostrar();
            frm.Show();
            frm.mostrar();
            this.Close();

        }


        //########################################


        private void searchProfile_Load(object sender, EventArgs e)
        {
            getProfiles();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchProfiles(textBox1.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getCurrentRow();
        }
    }
}
