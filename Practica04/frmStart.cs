using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Adert
{
    public partial class frmStart : Form
    {
        string xClave;

        public frmStart()
        {
            InitializeComponent();
            string creado = DateTime.Now.ToString("yyyyMMdd");
            lblFECHA.Text = creado.Substring(6, 2) + "/" +
                            creado.Substring(4, 2) + "/" +
                            creado.Substring(0, 4);

            string horaAmPm = DateTime.Now.ToString("hh:mm tt");
            lblHORA.Text = horaAmPm;
            
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            string xtrConexion = cnn.db;
            this.Text = HMenu.cia + "   Entrada al Sistema   " + HMenu.pc;
            lbl002.Text = "QSt. - R.Acosta - 829.750.2173";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() != string.Empty)
            {
                txUpperCase();
                if (txtClave.Text.Trim() == xClave)
                {
                    AbrirCerrarForm();
                }
                else
                {
                    MessageBox.Show("Usuario o Clave, Incorrectas", "MSJ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --------------------------------------------------------
        // USUARIO
        // --------------------------------------------------------
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)
            {
                Cursor.Current = Cursors.WaitCursor;
                xClave = Busco.UsuarioSistema(Convert.ToString(txtUsuario.Text));
                xClave = xClave.ToUpper();
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            xClave = "";
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtUsuario.Text.Trim() != string.Empty)
                {
                   txtClave.Focus();
                }
            }
        }

        // --------------------------------------------------------
        // CLAVE
        // --------------------------------------------------------
        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() != string.Empty)
            {
                txUpperCase();
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            //btnGuardar.Enabled = false;
            //btnBorrar.Enabled = false;
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtClave.Text.Trim() != string.Empty)
                {
                    txUpperCase();

                    if (txtClave.Text.Trim() == xClave)
                    {
                        AbrirCerrarForm();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Clave, Incorrectas", "MSJ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        void txUpperCase()
        {
            //txtClave.CharacterCasing = CharacterCasing.Upper;
            txtClave.Text = txtClave.Text.ToUpper();
            xClave = xClave.ToUpper();
        }

        void AbrirCerrarForm()
        {
            frmMenu frmMenu = new frmMenu();
            this.Hide();
            frmMenu.ShowDialog();
            this.Close();
        }
    }
}
