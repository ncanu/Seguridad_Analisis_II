using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using RetornoCadenaDeConexion;

namespace CapaDatosMantenimientoAplicaciones
{
    public class DatosMantenimientoAplicaciones
    {
        public void InsertarDatosAplicaciones(string codigoaplicacion, string nombreaplicacion, string codigomodulo)
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
                            cmd.CommandText = "INSERT INTO tbl_aplicacion(PK_Api_codigo, api_descripcion, FK_Codigo_modulo, api_estado) VALUES(" + codigoaplicacion + ",'" + nombreaplicacion + "'," + codigomodulo + ",1)";
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
        public void InsertarDatosDocumento(string codigodoc, string nombredoc, string rutadoc, string codigoapli)
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
                            cmd.CommandText = "INSERT INTO tbl_doc_asociado(PK_Id_Documento, Nombre_doc, Ruta, FK_Api_codigo, doc_estado) VALUES(" + codigodoc + ",'" + nombredoc + "','" + rutadoc + "'," + codigoapli + ", 1)";
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

        public void ModificarDatosModulo(string codigoaplicacionactual, string codigoaplicacion, string nombreaplicacion, string codigomodulo)
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
                            cmd.CommandText = "UPDATE tbl_aplicacion SET PK_Api_codigo = " + codigoaplicacion + ", api_descripcion = '" + nombreaplicacion + "', FK_Codigo_modulo = " + codigomodulo + " WHERE PK_Api_codigo = '" + codigoaplicacionactual + "';";
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
        public void EliminarDocumento(string codigoaplicacionactual)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection("dsn = colchoneria "))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "UPDATE tbl_doc_asociado SET doc_estado = 0 where id_documento = "+codigoaplicacionactual+";";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Eliminado");
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

        public void EliminarDatosModulos(string codigoapliacionactual)
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
                            cmd.CommandText = "Update tbl_aplicacion set api_estado = 0 WHERE PK_Api_codigo = " + codigoapliacionactual + ";";
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Eliminado");
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

        public string[] cargarDatos1(string codigoapi)
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
                            cmd.CommandText = "SELECT tbl_aplicacion.PK_Api_codigo, tbl_aplicacion.api_descripcion , tbl_modulo.modulo_nombre FROM tbl_modulo, tbl_aplicacion WHERE tbl_modulo.PK_Modulo_codigo = tbl_aplicacion.FK_Codigo_modulo AND tbl_aplicacion.PK_Api_codigo = " + codigoapi+" AND api_estado = 1";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["PK_Api_codigo"].ToString());
                                datos[1] = (Reader["api_descripcion"].ToString());
                                datos[2] = (Reader["modulo_nombre"].ToString());
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
        public DataSet ConsultarDatosAplicacion()
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
                            cmd.CommandText = "SELECT tbl_aplicacion.PK_Api_codigo as Codigo, tbl_aplicacion.api_descripcion as Aplicacion, tbl_modulo.modulo_nombre as Modulo FROM tbl_modulo, tbl_aplicacion WHERE tbl_modulo.PK_Modulo_codigo = tbl_aplicacion.FK_Codigo_modulo AND api_estado = 1";
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
        public DataSet ConsultarDatosDocumentos()
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
                            cmd.CommandText = "SELECT PK_Id_Documento as Codigo, Nombre_doc as Nombre, Ruta as Ruta from tbl_doc_asociado WHERE doc_estado = 1";
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
        public String ExtraerCodigoDeModulo(string nombremodulo)
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
                            cmd.CommandText = "SELECT PK_Modulo_codigo FROM tbl_modulo WHERE modulo_nombre = '" + nombremodulo + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader["PK_Modulo_codigo"].ToString());
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
        public String ExtraerCodigoDeAplicacion(string nombreaplicacion)
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
                            cmd.CommandText = "SELECT PK_Api_codigo FROM tbl_aplicacion WHERE api_descripcion = '" + nombreaplicacion + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos = (Reader["PK_Api_codigo"].ToString());
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
    }
}
