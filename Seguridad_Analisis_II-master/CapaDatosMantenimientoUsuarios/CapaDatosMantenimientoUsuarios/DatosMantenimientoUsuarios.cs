using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using RetornoCadenaDeConexion;

namespace CapaDatosMantenimientoUsuarios
{
    public class DatosMantenimientoUsuarios
    {
        public void InsertarDatosDeUsuarios(string nickname, string password)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO tbl_usuario(usu_nickname, usu_password, usu_estado) VALUES('" + nickname + "','" + password + "',1)";
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

        public void ModificarDatosDeUsuarios(string usuarioActual, string usuarioNuevo, string password, string estado)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE tbl_usuario SET usu_nickname = '" + usuarioNuevo + "', usu_password = '" + password + "', usu_estado = "+estado+" WHERE usu_nickname = '" + usuarioActual + "';";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado");
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
        public DataSet ConsultarDatosDeUsuarios()
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            DataSet ds= new DataSet();
            try
            {
                using (var conn = new OdbcConnection(cdc.Conexion()))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "SELECT PK_Usu_codigo as Codigo, usu_nickname as Nombre, usu_estado as Estado FROM tbl_usuario";
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
        public DataSet ConsultarDatosDeUsuarios1()
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
                            cmd.CommandText = "SELECT PK_Usu_codigo as Codigo, usu_nickname as Nombre, usu_estado as Estado FROM tbl_usuario WHERE usu_estado = 1";
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

        public string[] cargarDatos1(string usuario)
        {
            string[] datos;
            datos = new string[3];
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
                            cmd.CommandText = "SELECT usu_nickname, usu_password, usu_estado FROM tbl_usuario WHERE usu_nickname = '"+usuario+"'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["usu_nickname"].ToString());
                                datos[1] = (Reader["usu_password"].ToString());
                                datos[2] = (Reader["usu_estado"].ToString());
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
        public void CambioDeContraseña(string usuarioActual, string usuarioNuevo, string password)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE tbl_usuario SET usu_nickname = '" + usuarioNuevo + "', usu_password = '" + password + "' WHERE usu_nickname = '" + usuarioActual + "';";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado");
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
