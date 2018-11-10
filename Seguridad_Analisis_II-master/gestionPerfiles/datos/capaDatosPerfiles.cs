using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using RetornoCadenaDeConexion;

namespace datos
{
    public class capaDatosPerfiles
    {
        //VALIDAR ENCABEZADO_PERFIL

        public int verifyEncaPerf(int perfCod, string perfNom)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            OdbcDataReader dr = null;
            int resp = -1;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM TBL_perfil_encabezado WHERE PK_perf_cod_encabezado = '" + perfCod + "' OR perf_nombre = '" + perfNom + "'";
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            resp = 1;
                        }
                        else
                        {
                            resp = 0;
                        }
                        conn.Close();

                        return resp;
                    }

                }
            }
            catch (Exception ex)
            {

                return resp;
            }
        }



        //CREA ENCABEZADO_PERFIL
        public bool createEncaPerf(int perfCod, string perfNom)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();
                    int estado = 1;

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO TBL_perfil_encabezado VALUES('" + perfCod + "','" + perfNom + "','"+estado+"')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }




        //CREA PERFIL_DETALLE
        public bool createPerfDetalle(int perfCod, int api_codigo, int ingresar, int editar, int guardar, int borrar, int consultar)
        {


            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {

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

        //ACTUALIZA PERFIL_DETALLE
        public bool updatePerfDetalle(int perfCod, int api_codigo, int ingresar, int editar, int guardar, int borrar, int consultar)
        {


            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {

                        cmd.CommandText = "UPDATE TBL_perfil_detalle SET ingresar = '" + ingresar + "', editar = '" + editar + "', guardar = '" + guardar + "', borrar = '" + borrar + "', consultar = '" + consultar + "' WHERE perf_cod_encabezado = '" + perfCod + "' AND api_codigo = '" + api_codigo + "'";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        //GET MODULOS
        public DataTable getModulos()
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    OdbcDataReader dr;
                    conn.Open();
                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT * FROM TBL_modulo";
                            dt.Columns.Add("name");
                            dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["name"] = dr["modulo_nombre"];
                                dt.Rows.Add(row);
                            }

                            dr.Close();
                            conn.Close();
                            return dt;

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }



        //GET APPNAME

        public string getAppName(int code)
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            OdbcDataReader dr = null;
            string name = "";

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT api_descripcion FROM TBL_aplicacion WHERE PK_Api_codigo = '" + code + "'";
                        dr = cmd.ExecuteReader();
                        dr.Read();

                        name = dr["api_descripcion"].ToString();


                        dr.Close();
                        conn.Close();
                        return name;

                    }

                }
            }
            catch (Exception ex)
            {
                return name;
            }

        }


        //SEARCH COD_MODULO
        public int searchCodModulo(string nomModulo)
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            OdbcDataReader dr = null;
            int cod = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_Modulo_codigo FROM TBL_modulo WHERE modulo_nombre = '" + nomModulo + "'";
                        dr = cmd.ExecuteReader();
                        dr.Read();

                        cod = Convert.ToInt32(dr["PK_Modulo_codigo"].ToString());


                        dr.Close();
                        conn.Close();
                        return cod;

                    }

                }
            }
            catch (Exception ex)
            {
                return -1;
            }

        }



        //GET CORRELATIVO

        public int getCorrelativo(int perfCod, int appCod)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            OdbcDataReader dr = null;

            int correlativo = 0;

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT PK_correlativo FROM TBL_perfil_detalle WHERE perf_cod_encabezado = '" + perfCod + "' AND api_codigo = '" + appCod + "'";
                        dr = cmd.ExecuteReader();
                        dr.Read();

                        correlativo = Convert.ToInt32(dr["PK_correlativo"].ToString());

                        dr.Close();
                        conn.Close();

                        return correlativo;

                    }

                }
            }
            catch (Exception ex)
            {
                return correlativo;
            }
        }

        //DELETE APP PERFIL
        public void deleteAppPerfil(int perfCod, int appCod)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();

            int correlativo = getCorrelativo(perfCod, appCod);


            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM TBL_perfil_detalle WHERE PK_correlativo = '" + correlativo + "'";
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }

                }
            }
            catch (Exception ex)
            {

            }
        }


        //GET APLICACION_MODULO
        public DataTable getApiModulo(int codModulo)
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            OdbcDataReader dr = null;
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {

                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        dt.Columns.Add("codigo");
                        dt.Columns.Add("nombre");
                        cmd.CommandText = "SELECT * FROM TBL_aplicacion WHERE codigo_modulo = '" + codModulo + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            DataRow row = dt.NewRow();

                            row["codigo"] = dr["PK_Api_codigo"];
                            row["nombre"] = dr["api_descripcion"];
                            dt.Rows.Add(row);
                        }


                        dr.Read();
                        conn.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }



        //GET PROFILES
        public DataTable getAllProfiles()
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            OdbcDataReader dr = null;
            DataTable dt = new DataTable();

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {

                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        dt.Columns.Add("codigo");
                        dt.Columns.Add("nombre");
                        cmd.CommandText = "SELECT * FROM TBL_perfil_encabezado";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            DataRow row = dt.NewRow();

                            row["codigo"] = dr["PK_perf_cod_encabezado"];
                            row["nombre"] = dr["perf_nombre"];
                            dt.Rows.Add(row);
                        }


                        dr.Read();
                        conn.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }


        //SEARCH PROFILES
        public DataTable searchProfiles(string nombre)
        {

            CadenaDeConexion cdc = new CadenaDeConexion();
            OdbcDataReader dr = null;
            DataTable dt = new DataTable();
            string format = nombre + "%";

            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {

                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        dt.Columns.Add("codigo");
                        dt.Columns.Add("nombre");
                        cmd.CommandText = "SELECT * FROM TBL_perfil_encabezado WHERE perf_nombre LIKE '" + format + "'";
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            DataRow row = dt.NewRow();

                            row["codigo"] = dr["PK_perf_cod_encabezado"];
                            row["nombre"] = dr["perf_nombre"];
                            dt.Rows.Add(row);
                        }


                        dr.Read();
                        conn.Close();
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}
