using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosMantenimientoUsuarios;

namespace CapaLogicaMantenimientoUsuarios
{
    public class LogicaMantenimientoUsuarios
    {
        public void ValidarInsertarDatosDeUsuarios(string nickname, string password)
        {
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            if(nickname == "" || password == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }else
            {
                dmu.InsertarDatosDeUsuarios(nickname, password);
            }
        }

        public void ValidarModificarDatosDeUsuarios(string nicknameActual, string nickname, string password, string estado)
        {
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            if (nicknameActual == "" || nickname == "" || password == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                if(estado == "Inactivo")
                {
                    estado = "0";
                }else
                {
                    estado = "1";
                }
                dmu.ModificarDatosDeUsuarios(nicknameActual, nickname, password, estado);
            }
        }
        public void ValidarModificarCambioDeContraseña(string nicknameActual, string nickname, string password)
        {
            DatosMantenimientoUsuarios dmu = new DatosMantenimientoUsuarios();
            if (nicknameActual == "" || nickname == "" || password == "")
            {
                MessageBox.Show("Porfavor Ingresa Todos los campos");
            }
            else
            {
                dmu.CambioDeContraseña(nicknameActual, nickname, password);
            }
        }
    }
}
