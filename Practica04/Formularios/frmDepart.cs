using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica04
{
    public partial class frmDepart : Form
    {
        public frmDepart()
        {
            InitializeComponent();
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtDepartamento.Text.Trim() != string.Empty)
                {
                    txtNombreDepto.Focus();
                }
            }
        }

        private void txtDepartamento_Leave(object sender, EventArgs e)
        {
            if (txtDepartamento.Text.Trim() != string.Empty)
            {
                // ----------------------------------------------------------------------
                // Busco.NombreDepartamento
                // Busco...                                  es la clase que se esta invocando
                // NombreDepartamento...                     es el metodo dento de la clase
                // Convert.ToString(txtDepartamento.Text)... es el parametro enviado al metodo de la clase, convertido en un string
                // ----------------------------------------------------------------------
                txtNombreDepto.Text = Busco.Departamento(Convert.ToString(txtDepartamento.Text)); // valor retornado por la clase es asignado al TextBox
            }
        }

        private void btnConsultaDepto_Click(object sender, EventArgs e)
        {
            txtDepartamento.Focus();  // el curso se queda en el textbox txtdepartamento

            // creo el objeto frm y se le asigna el formulario frmVENDEPTO al objeto
            frmVENDEPTO frm = new frmVENDEPTO();

            DialogResult res = frm.ShowDialog();  // aqui muestra la ventana
                                                  // res = obtiene el valor de la ventana de consulta abierta
                                                  // obtendra el valor de ok cuando cierre la ventana

            if (res == DialogResult.OK)           // aqui pregunta que si res es igual a ok ejecute el siguiente codigo
            {
                txtDepartamento.Text = frm.varf1; // txtdepartamento se le asignara el valor contenido en la variable varf1
                lblFabricaNombre.Text = frm.varf2; // txtdepartamento se le asignara el valor contenido en la variable varf2
            }
        }
        private void btnConsultaFabrica_Click(object sender, EventArgs e)
        {
            txtFabrica.Focus();  // el curso se queda en el textbox txtdepartamento

            // creo el objeto frm y se le asigna el formulario frmVENDEPTO al objeto
            frmVENPLANTA frm = new frmVENPLANTA();

            DialogResult res = frm.ShowDialog();  // aqui muestra la ventana
            // res = obtiene el valor de la ventana de consulta abierta
            // obtendra el valor de ok cuando cierre la ventana

            if (res == DialogResult.OK)           // aqui pregunta que si res es igual a ok ejecute el siguiente codigo
            {
                txtFabrica.Text = frm.varf1;       // txtdepartamento se le asignara el valor contenido en la variable varf1
                lblFabricaNombre.Text = frm.varf2; // txtdepartamento se le asignara el valor contenido en la variable varf2
            }
        }
    }
}
