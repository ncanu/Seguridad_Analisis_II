using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using RetornoCadenaDeConexion;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Datos
    {



        public List<Permiso> obtenerPermisos(int usuarioCodigo)
        {

            //CadenaDeConexion cadenaConexion = new CadenaDeConexion();
            List<Permiso> respuesta = new List<Permiso>();

            try
            {

                using (var conn = new OdbcConnection(/*cadenaConexion.Conexion()*/"dsn=colchoneria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select d.api_codigo as aplicacion, d.ingresar, d.editar, d.guardar, d.borrar, d.buscar, d.consultar, d.imprimir FROM tbl_usuario a, tbl_relacion_usuario_perfil b, tbl_perfil_encabezado c, tbl_perfil_detalle d WHERE a.PK_Usu_Codigo = " + usuarioCodigo + " AND b.usu_codigo = a.PK_Usu_Codigo AND c.PK_perf_cod_encabezado = b.perf_codigo AND d.perf_cod_encabezado = c.PK_perf_cod_encabezado; ";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        List<Permiso> listaPermisos = new List<Permiso>();
                        while (reader.Read())
                        {
                        
                            Permiso permiso = new Permiso();
                            permiso.aplicacion = Convert.ToInt32(reader["aplicacion"]);
                            permiso.ingresar = Convert.ToBoolean(reader["ingresar"]);
                            permiso.editar = Convert.ToBoolean(reader["editar"]);
                            permiso.guardar = Convert.ToBoolean(reader["guardar"]);
                            permiso.borrar = Convert.ToBoolean(reader["borrar"]);
                            permiso.buscar = Convert.ToBoolean(reader["buscar"]);
                            permiso.consultar = Convert.ToBoolean(reader["consultar"]);
                            permiso.imprimir = Convert.ToBoolean(reader["imprimir"]);

                            listaPermisos.Add(permiso);
                            //respuesta = new List<Permiso>();
                           


                        }

                        conn.Close();
                        respuesta = listaPermisos;
                    }

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());

            }

            return respuesta;
        }


        /*Programado por Victor Jimenez*/
        public List<string> obtenerRutas(int codigoAplicacion)
        {

            //CadenaDeConexion cadenaConexion = new CadenaDeConexion();
            List<string> respuesta = new List<string>();

            try
            {

                using (var conn = new OdbcConnection(/*cadenaConexion.Conexion()*/"dsn=colchoneria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT Ruta FROM tbl_doc_asociado WHERE aplicacion_api_codigo = " + codigoAplicacion + ";";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        List<string> listaRutas = new List<string>();
                        while (reader.Read())
                        {

                            string rutas = "";
                            rutas = Convert.ToString(reader["Ruta"]);
                            //Console.WriteLine(rutas.Ruta);

                            listaRutas.Add(rutas);
                            //respuesta = new List<Permiso>();



                        }

                        conn.Close();
                        /*string s = "";
                        Usuario us = new Usuario();
                        foreach (var elemento in listaRutas)
                        {
                            s += Convert.ToString(elemento) + "\n";
                        }
                        Console.WriteLine(s);*/
                        respuesta = listaRutas;
                    }

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: " + exception.ToString());
            }

            return respuesta;
        }
        /*Programado por Victor Jimenez*/





        public Usuario obtenerObjUsuario(string usuario, string contrasena)
        {

            //CadenaDeConexion cadenaConexion = new CadenaDeConexion();

            try
            {
                Usuario user = new Usuario();
                using (var conn = new OdbcConnection(/*cadenaConexion.Conexion()*/"dsn=colchoneria;"))
                {
                    OdbcDataReader reader;
                    conn.Open();


                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "select * from tbl_usuario where usu_nickname='" + usuario + "' and usu_password='" + contrasena + "'";
                        cmd.ExecuteNonQuery();

                        reader = cmd.ExecuteReader();
                        if (!reader.HasRows)
                        {

                            return null;
                        }
                        else{
                            
                            while (reader.Read())
                            {

                                user.nickName = (reader["usu_nickname"].ToString());
                                user.codigoUsuario = Convert.ToInt32(reader["PK_Usu_Codigo"].ToString());
                            }
                        }
                   

                        conn.Close();

                    }

                }

                if (user.nickName == "" && user.codigoUsuario == 0)
                {
                    return null;
                }
                else{
                }

                return user;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error generado por la base de datos: "+exception.ToString());
            }

            return null;
        }


    }
}