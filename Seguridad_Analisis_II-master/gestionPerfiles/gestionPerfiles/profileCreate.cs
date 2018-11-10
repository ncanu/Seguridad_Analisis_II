using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Collections;



namespace gestionPerfiles
{
    public partial class profileCreate : Form
    {
        capaGraficaPerfiles dt = new capaGraficaPerfiles();

        public profileCreate()
        {
            InitializeComponent();
        }


        void limpiar()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox2.SelectedIndex = -1;
            textBox6.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            textBox4.Focus();

        }

        void cargarModulos()
        {
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
            comboBox2.DataSource = dt.getModulos();
        }


        void encabezadoDataGrid()
        {

            dataGridView2.RowHeadersVisible = false;

            DataGridViewCheckBoxColumn cc = new DataGridViewCheckBoxColumn();
            cc.Name = "Ingresar";
            cc.Width = 24;

            DataGridViewCheckBoxColumn cu = new DataGridViewCheckBoxColumn();
            cu.Name = "Editar";
            cu.Width = 24;

            DataGridViewCheckBoxColumn cs = new DataGridViewCheckBoxColumn();
            cs.Name = "Guardar";
            cs.Width = 24;

            DataGridViewCheckBoxColumn cd = new DataGridViewCheckBoxColumn();
            cd.Name = "Borrar";
            cd.Width = 24;

            DataGridViewCheckBoxColumn ce = new DataGridViewCheckBoxColumn();
            ce.Name = "Consultar";
            ce.Width = 24;


            /*DataGridViewCheckBoxColumn cr = new DataGridViewCheckBoxColumn();
            cr.Name = "R";
            cr.Width = 24;

            DataGridViewCheckBoxColumn cp = new DataGridViewCheckBoxColumn();
            cp.Name = "P";
            cp.Width = 24;*/


            dataGridView2.Columns.Add("codigo", "codigo");
            dataGridView2.Columns.Add("nombre", "nombre");
            dataGridView2.Columns.Add(cc);
            dataGridView2.Columns.Add(cu);
            dataGridView2.Columns.Add(cs);
            dataGridView2.Columns.Add(cd);
            dataGridView2.Columns.Add(ce);
            /*dataGridView2.Columns.Add(cr);
            dataGridView2.Columns.Add(cp);*/

        }


        void cargarAplicacioes(int codModulo)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt.getApiModulo(codModulo);

        }


        bool searchAddApp(int codApp)
        {
            int codigo = 0;


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                codigo = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (codApp == codigo)
                {
                    return true;
                }

            }

            return false;
        }

        void addSinglerow()
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            string cod = "";
            int referenceCode = 0;
            string name = "";

            cod = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            referenceCode = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
            name = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();

            if (searchAddApp(referenceCode) == false)
            {
                ArrayList row = new ArrayList();

                row.Add(cod);
                row.Add(name);

                dataGridView2.Rows.Add(row.ToArray());
            }
            else
            {
                MessageBox.Show("La aplicacion ya ha sido añadida!");
            }


        }


        void addAllRows()
        {

            string cod = "";
            int referenceCode = 0;
            string name = "";


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cod = row.Cells[0].Value.ToString();
                referenceCode = Convert.ToInt32(row.Cells[0].Value.ToString());
                name = row.Cells[1].Value.ToString();


                if (searchAddApp(referenceCode) == false)
                {
                    ArrayList rows = new ArrayList();

                    rows.Add(cod);
                    rows.Add(name);

                    dataGridView2.Rows.Add(rows.ToArray());
                }
                else
                {
                    MessageBox.Show("La aplicacion ya ha sido añadida!");
                }

            }
        }



        void setCodModulo(string nomModulo)
        {
            textBox6.Text = dt.searchCodModulo(nomModulo).ToString();
        }


        void deleteAllRows()
        {
            dataGridView2.Rows.Clear();
        }


        void deleteSingleRow()
        {
            int rowindex = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows.RemoveAt(rowindex);
        }




        //CREA PERFIL_DETALLE
        public bool createPerfDetalle2(int perfCod, int api_codigo, int ingresar, int editar, int guardar, int borrar, int consultar)
        {


           
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        MessageBox.Show("ok");
                        cmd.CommandText = "INSERT INTO TBL_perfil_detalle VALUES('','" + perfCod + "','" + api_codigo + "','" + ingresar + "','" + editar + "','" + guardar + "','" + borrar + "','" + consultar + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }



        void addAppDetail(int _perfCod)
        {

            int ingresar = 0;
            int editar = 0;
            int guardar = 0;
            int borrar = 0;
            int buscar = 0;
            int consultar = 0;
            int imprimir = 0;
            int codigo = 0;




            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                codigo = Convert.ToInt32(row.Cells[0].Value.ToString());


                //INGRESAR
                DataGridViewCheckBoxCell a = row.Cells[2] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(a.Value) == true)
                {
                    ingresar = 1;
                }
                else
                {
                    ingresar = 0;
                }


                //EDITAR
                DataGridViewCheckBoxCell b = row.Cells[3] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(b.Value) == true)
                {
                    editar = 1;

                }
                else
                {
                    editar = 0;
                }

                //GUARDAR
                DataGridViewCheckBoxCell c = row.Cells[4] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(c.Value) == true)
                {
                    guardar = 1;

                }
                else
                {
                    guardar = 0;
                }


                //BORRAR
                DataGridViewCheckBoxCell d = row.Cells[5] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(d.Value) == true)
                {
                    borrar = 1;

                }
                else
                {
                    borrar = 0;
                }

                //CONSULTAR
                DataGridViewCheckBoxCell f = row.Cells[6] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(f.Value) == true)
                {
                    consultar = 1;

                }
                else
                {
                    consultar = 0;
                }


                //LAMADA A FUNCION PARA INSERTAR APLICACION EN DETALLE


                //dt.createPerfDetalle(_perfCod, codigo, ingresar, editar, guardar, borrar, consultar);
                createPerfDetalle2(_perfCod, codigo, ingresar, editar, guardar, borrar, consultar);



            }


        }

   

        void ClearFrm()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            textBox4.Focus();
        }


        //#######################################################


        private void profileCreate_Load(object sender, EventArgs e)
        {

            cargarModulos();
            encabezadoDataGrid();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCodModulo(this.comboBox2.Text.ToString());
            cargarAplicacioes(Convert.ToInt32(textBox6.Text.ToString()));
        }

        private void Btn_Agregartodas_Click(object sender, EventArgs e)
        {
            addAllRows();
        }

        private void Btn_Quitartodas_Click(object sender, EventArgs e)
        {
            deleteAllRows();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            addSinglerow();
        }

        private void Btn_Quitar_Click(object sender, EventArgs e)
        {
            deleteSingleRow();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            int perCode = 0;
            string name = "";

            perCode = Convert.ToInt32(textBox4.Text.ToString());
            name = textBox5.Text.ToString();

            if (dt.verifyEncaPerf(perCode, name) == 1)
            {
                MessageBox.Show("Error, el perfil ya existe");
                limpiar();
            }
            else if (dt.verifyEncaPerf(perCode, name) == 0)
            {
                if (dt.createEncaPerf(perCode, name) == true)
                {
                    addAppDetail(perCode);
                    MessageBox.Show("Perfil creado Exitosamente!");
                    limpiar();

                }
            }
            else
            {
                MessageBox.Show("Error al hacer la petecion");
            }

            
            
        }
    }
}
