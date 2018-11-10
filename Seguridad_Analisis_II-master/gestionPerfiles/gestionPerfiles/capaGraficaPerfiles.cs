using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using logica;

namespace gestionPerfiles
{
    public class capaGraficaPerfiles
    {

        logica.capaLogicaPerfiles cpl = new logica.capaLogicaPerfiles();
        //capaLogicaPerfiles cpl = new capaLogicaPerfiles();


        //VALIDAR ENCABEZADO_PERFIL

        public int verifyEncaPerf(int perfCod, string perfNom)
        {
            if (cpl.verifyEncaPerf(perfCod, perfNom) == 1)
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
            if (cpl.createEncaPerf(perfCod, perfNom))
            {
                return true;
            }

            return false;
        }


        //CREA PERFIL_DETALLE
        public bool createPerfDetalle(int perfCod, int api_codigo, int ingresar, int editar, int guardar, int borrar, int consultar)
        {

            if (cpl.createPerfDetalle(perfCod, api_codigo, ingresar, editar, guardar, borrar, consultar))
            {
                return true;
            }

            return false;

        }


        //ACTUALIZA PERFIL_DETALLE
        public bool updatePerfDetalle(int perfCod, int api_codigo, int ingresar, int editar, int guardar, int borrar,int consultar)
        {
            if (cpl.updatePerfDetalle(perfCod, api_codigo, ingresar, editar, guardar, borrar, consultar))
            {
                return true;
            }

            return false;

        }



        //GET MODULOS
        public DataTable getModulos()
        {
            return cpl.getModulos();

        }


        //GET APPNAME
        public string getAppName(int code)
        {
            return cpl.getAppName(code);
        }


        //SEARCH COD_MODULO
        public int searchCodModulo(string nomModulo)
        {
            return cpl.searchCodModulo(nomModulo);
        }


        //GET CORRELATIVO
        public int getCorrelativo(int perfCod, int appCod)
        {
            return cpl.getCorrelativo(perfCod, appCod);
        }

        //DELETE APP PERFIL
        public void deleteAppPerfil(int perfCod, int appCod)
        {
            cpl.deleteAppPerfil(perfCod, appCod);
        }



        //GET APLICACION_MODULO
        public DataTable getApiModulo(int codModulo)
        {
            return cpl.getApiModulo(codModulo);
        }


        //GET PROFILES
        public DataTable getAllProfiles()
        {

            return cpl.getAllProfiles();

        }


        //SEARCH PROFILES
        public DataTable searchProfiles(string nombre)
        {
            return cpl.searchProfiles(nombre);
        }
    }
}
