using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using RetornoCadenaDeConexion;
using System.Windows.Forms;
using System.Data;

namespace CapaDatosMantenimientoModulos
{
    public class DatosMantenimientoModulos
    {
        public void InsertarDatosModulos(string codigomodulo, string nombremodulo)
        {
            CadenaDeConexion cdc = new CadenaDeConexion();
            try
            {
                using (var conn = new OdbcConnection(/*cdc.Conexion()*/"dsn=colchoneria"))
                {
                    conn.Open();

                    {
                        using (var cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = "INSERT INTO TBL_Modulo(PK_Modulo_codigo, modulo_nombre, modulo_estado) VALUES(" + codigomodulo + ",'" + nombremodulo + "',1)";
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

        public void ModificarDatosModulo(string codigomoduloactual, string codigomodulo, string nombremodulo)
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
                            cmd.CommandText = "UPDATE TBL_Modulo SET PK_Modulo_codigo = " + codigomodulo + ", modulo_nombre = '" + nombremodulo + "' WHERE PK_Modulo_codigo = '" + codigomoduloactual + "';";
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

        public void EliminarDatosModulos(string codigomoduloactual)
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
                            cmd.CommandText = "Update TBL_Modulo set modulo_estado = 0 where PK_Modulo_codigo = " + codigomoduloactual + ";";
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

        public string[] cargarDatos1(string codigomodulo)
        {
            string[] datos;
            datos = new string[2];
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
                            cmd.CommandText = "SELECT PK_Modulo_codigo, modulo_nombre FROM TBL_Modulo WHERE PK_Modulo_codigo = '" + codigomodulo + "'";
                            Reader = cmd.ExecuteReader();
                            while (Reader.Read())
                            {
                                datos[0] = (Reader["PK_Modulo_codigo"].ToString());
                                datos[1] = (Reader["modulo_nombre"].ToString());
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

        public DataSet ConsultarDatosModulo()
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
                            cmd.CommandText = "SELECT PK_Modulo_codigo as Codigo, modulo_nombre as Nombre FROM TBL_Modulo where modulo_estado = 1";
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
    }
}
