using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using RetornoCadenaDeConexion;
using System.Windows.Forms;

namespace CapaDatosAsignacionDePerfiles
{
    public class DatosAsignacionDePerfiles
    {
        public String ExtrarCodigoDeUsuario(string usuario)
        {
            string datos = "";
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
                            cmd.CommandText = "SELECT PK_Usu_codigo FROM tbl_usuario WHERE usu_nickname = '" + usuario + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader["PK_Usu_codigo"].ToString());
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR");
            }
            return datos;
        }
        public DataSet MostrarDatosDePerfiles()
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT PK_perf_cod_encabezado as Codigo, perf_nombre as Nombre FROM tbl_perfil_encabezado";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }
        public DataSet MostrarDatosDePerfilesDeUsuarios(string usuario)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            DataSet ds = new DataSet();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT PK_perf_cod_encabezado as Codigo, perf_nombre as Nombre FROM tbl_perfil_encabezado WHERE PK_Perf_cod_encabezado IN (SELECT FK_Perf_codigo from tbl_relacion_usuario_perfil WHERE FK_Usu_codigo = (SELECT PK_Usu_Codigo from tbl_usuario where usu_nickname = '" + usuario + "'))";
                            OdbcDataAdapter m_datos = new OdbcDataAdapter(cmd);
                            ds = new DataSet();
                            m_datos.Fill(ds);
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return ds;
        }


        public void CrearRelacionPerfilUsuario(string usuario, string perfil)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            string username = usuario;
            string perfname = perfil;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO tbl_relacion_usuario_perfil(FK_Usu_codigo, FK_Perf_codigo) values(" + username + "," + perfname + ");";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Insertado");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void EliminarRelacionPerfilUsuario(string usuario, string perfil)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            string username = usuario;
            string perfname = perfil;
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "DELETE FROM tbl_relacion_usuario_perfil WHERE FK_Usu_codigo = "+usuario+" AND FK_Perf_codigo = "+perfil+"";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Removido");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
