using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using RetornoCadenaDeConexion;

namespace gestionPerfiles
{
    public partial class profileMantenimiento : Form
    {

        capaGraficaPerfiles dt = new capaGraficaPerfiles();

        public profileMantenimiento()
        {
            InitializeComponent();
        }


        void limpiar()
        {
            Txt_CodPerfil.Text = "";
            Txt_NombrePerfil.Text = "";
            Txt_CodModulo.Text = "";
            comboBox1.SelectedIndex = -1;
            Txt_CodModulo.Text = "";
            dataGridView4.DataSource = null;
            dataGridView4.Rows.Clear();
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();


        }


        void encabezadoDataGrid2()
        {

            dataGridView3.RowHeadersVisible = false;

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


            dataGridView3.Columns.Add("codigo", "codigo");
            dataGridView3.Columns.Add("nombre", "nombre");
            dataGridView3.Columns.Add(cc);
            dataGridView3.Columns.Add(cu);
            dataGridView3.Columns.Add(cs);
            dataGridView3.Columns.Add(cd);
            dataGridView3.Columns.Add(ce);
            /*dataGridView3.Columns.Add(cr);
            dataGridView3.Columns.Add(cp);*/

        }


        void deleteSingleRow2()
        {
            int rowindex = dataGridView3.CurrentCell.RowIndex;

            dataGridView3.Rows.RemoveAt(rowindex);
        }


        void encabezadoDataGrid3()
        {

            dataGridView5.RowHeadersVisible = false;

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


            dataGridView5.Columns.Add("codigo", "codigo");
            dataGridView5.Columns.Add("nombre", "nombre");
            dataGridView5.Columns.Add(cc);
            dataGridView5.Columns.Add(cu);
            dataGridView5.Columns.Add(cs);
            dataGridView5.Columns.Add(cd);
            dataGridView5.Columns.Add(ce);
            /*dataGridView5.Columns.Add(cr);
            dataGridView5.Columns.Add(cp);*/

        }


        void cargarAplicacioes2(int codModulo)
        {
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = dt.getApiModulo(codModulo);

        }


        bool searchAddApp2(int codApp)
        {
            int codigo = 0;


            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                codigo = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (codApp == codigo)
                {
                    return true;
                }

            }

            return false;
        }

        void addSinglerow2()
        {
            int rowindex = dataGridView4.CurrentCell.RowIndex;

            string cod = "";
            int referenceCode = 0;
            string name = "";

            cod = dataGridView4.Rows[rowindex].Cells[0].Value.ToString();
            referenceCode = Convert.ToInt32(dataGridView4.Rows[rowindex].Cells[0].Value.ToString());
            name = dataGridView4.Rows[rowindex].Cells[1].Value.ToString();

            if (searchAddApp2(referenceCode) == false)
            {
                ArrayList row = new ArrayList();

                row.Add(cod);
                row.Add(name);

                dataGridView3.Rows.Add(row.ToArray());
            }
            else
            {
                MessageBox.Show("La aplicacion ya ha sido añadida!");
            }


        }


        void addAllRows2()
        {

            string cod = "";
            int referenceCode = 0;
            string name = "";


            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                cod = row.Cells[0].Value.ToString();
                referenceCode = Convert.ToInt32(row.Cells[0].Value.ToString());
                name = row.Cells[1].Value.ToString();


                if (searchAddApp2(referenceCode) == false)
                {
                    ArrayList rows = new ArrayList();

                    rows.Add(cod);
                    rows.Add(name);

                    dataGridView3.Rows.Add(rows.ToArray());
                }
                else
                {
                    MessageBox.Show("La aplicacion ya ha sido añadida!");
                }

            }
        }




        bool exist(int cod)
        {

            int refCod = 0;
            bool band = false;

            foreach (DataGridViewRow row in dataGridView5.Rows)
            {

                refCod = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (refCod == cod)
                {
                    band = true;
                }


            }

            return band;

        }



        bool deleted(int cod)
        {

            int refCod = 0;
            bool band = true;

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {

                refCod = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (refCod == cod)
                {
                    band = false;
                }


            }

            return band;

        }


        bool added(int cod)
        {

            int refCod = 0;
            bool band = true;

            foreach (DataGridViewRow row in dataGridView5.Rows)
            {

                refCod = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (refCod == cod)
                {
                    band = false;
                }


            }

            return band;

        }


        void addAppDetail2(int _perfCod, int row)
        {

            int ingresar = 0;
            int editar = 0;
            int guardar = 0;
            int borrar = 0;
        
            int consultar = 0;
  
            int codigo = 0;


            codigo = Convert.ToInt32(dataGridView3.Rows[row].Cells[0].Value.ToString());


            //INGRESAR
            DataGridViewCheckBoxCell a = dataGridView3.Rows[row].Cells[2] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(a.Value) == true)
            {
                ingresar = 1;
            }
            else
            {
                ingresar = 0;
            }


            //EDITAR
            DataGridViewCheckBoxCell b = dataGridView3.Rows[row].Cells[3] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(b.Value) == true)
            {
                editar = 1;

            }
            else
            {
                editar = 0;
            }

            //GUARDAR
            DataGridViewCheckBoxCell c = dataGridView3.Rows[row].Cells[4] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(c.Value) == true)
            {
                guardar = 1;

            }
            else
            {
                guardar = 0;
            }


            //BORRAR
            DataGridViewCheckBoxCell d = dataGridView3.Rows[row].Cells[5] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(d.Value) == true)
            {
                borrar = 1;

            }
            else
            {
                borrar = 0;
            }



            //CONSULTAR
            DataGridViewCheckBoxCell f = dataGridView3.Rows[row].Cells[6] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(f.Value) == true)
            {
                consultar = 1;

            }
            else
            {
                consultar = 0;
            }


 

            //LAMADA A FUNCION PARA INSERTAR APLICACION EN DETALLE


            dt.createPerfDetalle(_perfCod, codigo, ingresar, editar, guardar, borrar, consultar);






        }



        void Agrega()
        {

            string cod = "";
            int referenceCode = 0;
            string name = "";

            int codPerf = Convert.ToInt32(Txt_CodPerfil.Text.ToString());


            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                cod = row.Cells[0].Value.ToString();


                referenceCode = Convert.ToInt32(row.Cells[0].Value.ToString());
                name = row.Cells[1].Value.ToString();

                //DETECTA APLICACIONES AGREGADAS
                if (added(referenceCode))
                {
                    addAppDetail2(codPerf, row.Index);
                }
            }

        }

        void Elimina()
        {
            string cod = "";
            int referenceCode = 0;
            string name = "";

            int codPerf = Convert.ToInt32(Txt_CodPerfil.Text.ToString());


            foreach (DataGridViewRow row in dataGridView5.Rows)
            {
                cod = row.Cells[0].Value.ToString();
                referenceCode = Convert.ToInt32(row.Cells[0].Value.ToString());
                name = row.Cells[1].Value.ToString();

                //DETECTA APLICACIONES ELIMINADAS
                if (deleted(referenceCode))
                {
                    dt.deleteAppPerfil(codPerf, referenceCode);

                }
            }

        }





        void detecta(int rowindex, int perfCod, int appCod)
        {
            int ing = 0;
            int edit = 0;
            int gua = 0;
            int borr = 0;
            int busq = 0;
            int cons = 0;
            int imp = 0;


            DataGridViewCheckBoxCell a = dataGridView3.Rows[rowindex].Cells[2] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(a.Value) == true)
            {
                ing = 1;
            }
            else
            {
                ing = 0;
            }



            DataGridViewCheckBoxCell b = dataGridView3.Rows[rowindex].Cells[3] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(b.Value) == true)
            {
                edit = 1;
            }
            else
            {
                edit = 0;
            }


            DataGridViewCheckBoxCell c = dataGridView3.Rows[rowindex].Cells[4] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(c.Value) == true)
            {
                gua = 1;
            }
            else
            {
                gua = 0;
            }


            DataGridViewCheckBoxCell d = dataGridView3.Rows[rowindex].Cells[5] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(d.Value) == true)
            {
                borr = 1;
            }
            else
            {
                borr = 0;
            }



           /* DataGridViewCheckBoxCell e = dataGridView3.Rows[rowindex].Cells[6] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(e.Value) == true)
            {
                busq = 1;
            }
            else
            {
                busq = 0;
            }*/


            DataGridViewCheckBoxCell f = dataGridView3.Rows[rowindex].Cells[6] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(f.Value) == true)
            {
                cons = 1;
            }
            else
            {
                cons = 0;
            }



            /*DataGridViewCheckBoxCell g = dataGridView3.Rows[rowindex].Cells[8] as DataGridViewCheckBoxCell;

            if (Convert.ToBoolean(g.Value) == true)
            {
                imp = 1;
            }
            else
            {
                imp = 0;
            }

            */




            dt.updatePerfDetalle(perfCod, appCod, ing, edit, gua, borr, cons);


        }


        void Actualiza()
        {

            string cod = "";
            int referenceCode = 0;
            string name = "";

            int codPerf = Convert.ToInt32(Txt_CodPerfil.Text.ToString());


            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                cod = row.Cells[0].Value.ToString();
                referenceCode = Convert.ToInt32(row.Cells[0].Value.ToString());
                name = row.Cells[1].Value.ToString();

                //HERE
                //DETECTA APLICACIONES EXISTENTES
                if (exist(referenceCode))
                {

                    detecta(row.Index, codPerf, referenceCode);

                }
            }

        }


        void clearFrm()
        {
            Txt_CodPerfil.Text = "";
            Txt_NombrePerfil.Text = "";

            dataGridView3.Rows.Clear();

            Txt_CodPerfil.Focus();
        }

        void changesProfile()
        {

            Elimina();
            Agrega();
            Actualiza();

            Btn_quitar.Enabled = false;
            Btn_Quitartodas.Enabled = false;
            Btn_Agregar.Enabled = false;
            Btn_Agregartodas.Enabled = false;

            MessageBox.Show("Cambios realizados exitosamente!");
            clearFrm();
            limpiar();

        }





        void deleteAllRows2()
        {
            dataGridView3.Rows.Clear();
        }

        void setCodModulo2(string nomModulo)
        {
            Txt_CodModulo.Text = dt.searchCodModulo(nomModulo).ToString();
        }

        void cargarModulos2()
        {
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";
            comboBox1.DataSource = dt.getModulos();
        }


        //GET APPS PERFIL
        private void getAppsPerfil(int code)
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            int refCode = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_perfil_detalle WHERE perf_cod_encabezado = '" + code + "'";

                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                //HERE

                                ArrayList row = new ArrayList();

                                row.Add(dr["api_codigo"].ToString());
                                refCode = Convert.ToInt32(dr["api_codigo"].ToString());

                                row.Add(dt.getAppName(refCode));

                                if (Convert.ToBoolean(dr["ingresar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                if (Convert.ToBoolean(dr["editar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                if (Convert.ToBoolean(dr["guardar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                if (Convert.ToBoolean(dr["borrar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                /*if (Convert.ToBoolean(dr["buscar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }*/


                                if (Convert.ToBoolean(dr["consultar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                /*if (Convert.ToBoolean(dr["imprimir"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }*/





                                dataGridView3.Rows.Add(row.ToArray());
                            }

                            dr.Close();
                            conn.Close();


                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }



        //GET APPS PERFIL
        private void getAppsPerfil2(int code)
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            int refCode = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_perfil_detalle WHERE perf_cod_encabezado = '" + code + "'";

                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                //HERE

                                ArrayList row = new ArrayList();

                                row.Add(dr["api_codigo"].ToString());
                                refCode = Convert.ToInt32(dr["api_codigo"].ToString());

                                row.Add(dt.getAppName(refCode));

                                if (Convert.ToBoolean(dr["ingresar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                if (Convert.ToBoolean(dr["editar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                if (Convert.ToBoolean(dr["guardar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                if (Convert.ToBoolean(dr["borrar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                               /* if (Convert.ToBoolean(dr["buscar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }*/


                                if (Convert.ToBoolean(dr["consultar"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }


                                /*if (Convert.ToBoolean(dr["imprimir"]))
                                {
                                    row.Add(true);
                                }
                                else
                                {
                                    row.Add(false);
                                }*/




                                //CAMBIOS
                                dataGridView5.Rows.Add(row.ToArray());
                                //dataGridView1.Rows.Add(row.ToArray());
                            }

                            dr.Close();
                            conn.Close();


                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }

        public void mostrar()
        {
            Btn_quitar.Enabled = true;
            Btn_Quitartodas.Enabled = true;
            Btn_Agregar.Enabled = true;
            Btn_Agregartodas.Enabled = true;
            getAppsPerfil(Convert.ToInt32(Txt_CodPerfil.Text.ToString()));
            getAppsPerfil2(Convert.ToInt32(Txt_CodPerfil.Text.ToString()));
        }


        //################################


        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            searchProfile sp = new searchProfile();
            sp.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCodModulo2(this.comboBox1.Text.ToString());
            cargarAplicacioes2(Convert.ToInt32(Txt_CodModulo.Text.ToString()));
        }

        private void profileMantenimiento_Load(object sender, EventArgs e)
        {
            
            cargarModulos2();
          
            encabezadoDataGrid2();
            encabezadoDataGrid3();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void Btn_Agregartodas_Click(object sender, EventArgs e)
        {
            addAllRows2();
        }

        private void Btn_Quitartodas_Click(object sender, EventArgs e)
        {
            deleteAllRows2();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            addSinglerow2();
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            deleteSingleRow2();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            if ((Equals(Txt_CodPerfil.Text.ToString() , ""))|| (Equals(Txt_CodPerfil.Text.ToString() , "")))
            {
                MessageBox.Show("Porfavor debe llenar todos los campos!");
            }
            else
            {
                changesProfile();
            }
        }
    }
}
