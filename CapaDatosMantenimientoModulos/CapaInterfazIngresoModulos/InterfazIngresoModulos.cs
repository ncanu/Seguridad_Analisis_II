using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaLogicaMantenimientoModulos;

namespace CapaInterfazIngresoModulos
{
    public partial class InterfazIngresoModulos : Form
    {
        public InterfazIngresoModulos()
        {
            InitializeComponent();
        }

        public void clear()
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {


            //Validar solo numeros
            Regex Val = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            if (Val.IsMatch(textBox4.Text))
            {
                //Guardar
                LogicaMantenimientoModulos lmm = new LogicaMantenimientoModulos();
                lmm.ValidarInsertarDatosModulos(textBox4.Text, textBox5.Text);
                clear();
            }
            else
            {
                MessageBox.Show("Codigo solo debe llevar numeros", "Error de Sintaxis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
            }
            
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
