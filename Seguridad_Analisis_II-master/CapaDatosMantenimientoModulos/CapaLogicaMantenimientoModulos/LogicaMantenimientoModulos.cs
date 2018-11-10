using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosMantenimientoModulos;
using System.Windows.Forms;

namespace CapaLogicaMantenimientoModulos
{
    public class LogicaMantenimientoModulos
    {
        public void ValidarInsertarDatosModulos(string codigomodulo, string nombremodulo)
        {
            DatosMantenimientoModulos dmm = new DatosMantenimientoModulos();
            if (codigomodulo == "" || nombremodulo == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                dmm.InsertarDatosModulos(codigomodulo, nombremodulo);
            }
        }

        public void ValidarModificarDatosModulos(string codigoactual, string codigomodulo, string nombremodulo)
        {
            DatosMantenimientoModulos dmm = new DatosMantenimientoModulos();
            if (codigomodulo == "" || nombremodulo == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                dmm.ModificarDatosModulo(codigoactual, codigomodulo, nombremodulo);
            }
        }
    }
}
