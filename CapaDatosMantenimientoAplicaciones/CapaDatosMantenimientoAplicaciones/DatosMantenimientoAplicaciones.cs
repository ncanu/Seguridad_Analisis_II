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
                            cmd.CommandText = "INSERT INTO TBL_Aplicacion(PK_Api_codigo, api_descripcion, FK_Codigo_modulo, api_estado) VALUES(" + codigoaplicacion + ",'" + nombreaplicacion + "'," + codigomodulo + ",1)";
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
                            cmd.CommandText = "INSERT INTO TBL_Doc_Asociado(PK_Id_Documento, Nombre_doc, Ruta, FK_Api_codigo, doc_estado) VALUES(" + codigodoc + ",'" + nombredoc + "','" + rutadoc + "'," + codigoapli + ", 1)";
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
                            cmd.CommandText = "UPDATE TBL_Aplicacion SET PK_Api_codigo = " + codigoaplicacion + ", api_descripcion = '" + nombreaplicacion + "', FK_Codigo_modulo = " + codigomodulo + " WHERE PK_Api_codigo = '" + codigoaplicacionactual + "';";
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
                            cmd.CommandText = "UPDATE TBL_Doc_Asociado SET doc_estado = 0 where id_documento = "+codigoaplicacionactual+";";
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
                            cmd.CommandText = "Update TBL_Aplicacion set api_estado = 0 WHERE PK_Api_codigo = " + codigoapliacionactual + ";";
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
                            cmd.CommandText = "SELECT TBL_Aplicacion.PK_Api_codigo, TBL_Aplicacion.api_descripcion , TBL_Modulo.modulo_nombre FROM TBL_Modulo, TBL_Aplicacion WHERE TBL_Modulo.PK_Modulo_codigo = TBL_Aplicacion.FK_Codigo_modulo AND TBL_Aplicacion.PK_Api_codigo = " + codigoapi+" AND api_estado = 1";
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
                            cmd.CommandText = "SELECT TBL_Aplicacion.PK_Api_codigo as Codigo, TBL_Aplicacion.api_descripcion as Aplicacion, TBL_Modulo.modulo_nombre as Modulo FROM TBL_Modulo, TBL_Aplicacion WHERE TBL_Modulo.PK_Modulo_codigo = TBL_Aplicacion.FK_Codigo_modulo AND api_estado = 1";
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
                            cmd.CommandText = "SELECT PK_Id_Documento as Codigo, Nombre_doc as Nombre, Ruta as Ruta from TBL_Doc_asociado WHERE doc_estado = 1";
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
                            cmd.CommandText = "SELECT PK_Modulo_codigo FROM TBL_Modulo WHERE modulo_nombre = '" + nombremodulo + "'";
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
                            cmd.CommandText = "SELECT PK_Api_codigo FROM TBL_Aplicacion WHERE api_descripcion = '" + nombreaplicacion + "'";
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
