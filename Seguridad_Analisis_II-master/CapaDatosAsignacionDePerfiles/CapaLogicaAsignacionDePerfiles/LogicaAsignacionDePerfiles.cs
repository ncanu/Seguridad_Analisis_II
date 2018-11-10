using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosAsignacionDePerfiles;
using System.Windows.Forms;

namespace CapaLogicaAsignacionDePerfiles
{
    public class LogicaAsignacionDePerfiles
    {
        public void ValidarIngresoDeDatosPerfilUsuario(string usuario, string perfil)
        {
            DatosAsignacionDePerfiles dadp = new DatosAsignacionDePerfiles();
            if(usuario == ""||perfil == "")
            {
                MessageBox.Show("Porfavor Selecciona los datos");   
            }else
            {
                dadp.CrearRelacionPerfilUsuario(usuario, perfil);
            }
        }
        public void ValidarEliminacionDeDatosPerfilUsuario(string usuario, string perfil)
        {
            DatosAsignacionDePerfiles dadp = new DatosAsignacionDePerfiles();
            if (usuario == "" || perfil == "")
            {
                MessageBox.Show("Porfavor Selecciona los datos");
            }
            else
            {
                dadp.EliminarRelacionPerfilUsuario(usuario, perfil);
            }
        }
    }
}
