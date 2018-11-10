using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Threading.Tasks;
using datos;

namespace logica
{
    public class capaLogicaPerfiles
    {

        datos.capaDatosPerfiles cpd = new datos.capaDatosPerfiles();
        //capaDatosPerfiles cpd = new capaDatosPerfiles();


        //VALIDAR ENCABEZADO_PERFIL

        public int verifyEncaPerf(int perfCod, string perfNom)
        {
            if (cpd.verifyEncaPerf(perfCod, perfNom) == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }

        //CREA ENCABEZADO_PERFIL
        public bool createEncaPerf(int perfCod, string perfNom)
        {
            if (cpd.createEncaPerf(perfCod, perfNom))
            {
                return true;
            }

            return false;
        }


        //CREA PERFIL_DETALLE
        public bool createPerfDetalle(int perfCod, int api_codigo, int ingresar, int editar, int guardar, int borrar, int consultar)
        {

            if (cpd.createPerfDetalle( perfCod, api_codigo,  ingresar,  editar,  guardar,  borrar,  consultar))
            {
                return true;
            }

            return false;

        }


        //ACTUALIZA PERFIL_DETALLE
        public bool updatePerfDetalle(int perfCod, int api_codigo, int ingresar, int editar, int guardar, int borrar, int consultar)
        {
            if (cpd.updatePerfDetalle(perfCod, api_codigo, ingresar, editar, guardar, borrar,consultar))
            {
                return true;
            }

            return false;

        }



        //GET MODULOS
        public DataTable getModulos()
        {
            return cpd.getModulos();

        }


        //GET APPNAME
        public string getAppName(int code)
        {
            return cpd.getAppName(code);
        }


        //SEARCH COD_MODULO
        public int searchCodModulo(string nomModulo)
        {
            return cpd.searchCodModulo(nomModulo);
        }


        //GET CORRELATIVO
        public int getCorrelativo(int perfCod, int appCod)
        {
            return cpd.getCorrelativo(perfCod,appCod);
        }

        //DELETE APP PERFIL
        public void deleteAppPerfil(int perfCod, int appCod)
        {
            cpd.deleteAppPerfil(perfCod, appCod);
        }



        //GET APLICACION_MODULO
        public DataTable getApiModulo(int codModulo)
        {
            return cpd.getApiModulo(codModulo);
        }


        //GET PROFILES
        public DataTable getAllProfiles()
        {

            return cpd.getAllProfiles();

        }


        //SEARCH PROFILES
        public DataTable searchProfiles(string nombre)
        {
            return cpd.searchProfiles(nombre);
        }


        }
}
