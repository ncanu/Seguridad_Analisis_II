using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatosMantenimientoAplicaciones;
using System.Windows.Forms;

namespace CapaLogicaMantenimientoAplicaciones
{
    public class LogicaMantenimientoAplicaciones
    {
        public void ValidarInsertarDatosAplicaiones(string codigoapli, string nombreapi, string codigomodulo)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            if (codigoapli == "" || nombreapi == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                dmm.InsertarDatosAplicaciones(codigoapli, nombreapi, codigomodulo);
            }
        }
        public void ValidarInsertarDatosDocumento(string codigodoc, string nombredoc, string rutadoc, string codigoapli)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            if (codigodoc == "" || nombredoc == "" || rutadoc == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                dmm.InsertarDatosDocumento(codigodoc,nombredoc,rutadoc,codigoapli);
            }
        }
        public void ValidarBorrarDatosDocumento(string codigodoc)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            if (codigodoc == "" )
            {
                MessageBox.Show("Porfavor selecciona el dato a eliminar");
            }
            else
            {
                dmm.EliminarDocumento(codigodoc);
            }
        }

        public void ValidarModificarDatosAplicaciones(string codigoapliactual, string codigoapli, string nombreapi, string codigomodulo)
        {
            DatosMantenimientoAplicaciones dmm = new DatosMantenimientoAplicaciones();
            if (codigoapli == "" || nombreapi == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                dmm.ModificarDatosModulo(codigoapliactual,codigoapli,nombreapi,codigomodulo);
            }
        }
    }
}
