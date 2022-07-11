using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;

//Permite acceder a funciones que residen en bibliotecas compartidas subyacentes específicas 
//del sistema operativo (en Win32, estas son DLL). COM (Modelo de objetos componentes) es una 
//arquitectura de componentes heredada de Win32 que se usa en todas las aplicaciones de Windows.
using System.Runtime.InteropServices;

namespace Practica04
{
    public partial class frmStarts : Form
    {
        string xClave;
        public string pubUser;
        public string pubCargo;
        public string pubCorreo;

        // ============================================================
        // aqui se inicializan los componentes del programa
        // ------------------------------------------------------------
        public frmStarts()
        {
            InitializeComponent();
        }

        // ============================================================
        // cargamos la libreria a usar para mover el formulario
        // ------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]  // libreria usada para mover el formulario actual
        private extern static void ReleaseCapture();  // libreria usada para mover el formulario actual
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        // ========================================================================
        // aqui le envia la posision en la que mueve el mouse y mueve el formulario
        // ------------------------------------------------------------------------
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Altura de barra de título;


        // Una función que devuelve una llamada, que se define en la aplicación, procesa los mensajes enviados a una ventana. 
        // El tipo WNDPROC define un puntero a esta función de devolución de llamada. WndProc es un marcador de posición para el 
        // nombre de la función que define en la aplicación.
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84) {
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption) {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }


        // ============================================================
        // el evento load es donde inicia la primera carga del programa
        // ------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            string xtrConexion = cnn.db;  // llama la clase cnn con su metodo db
            lbl002.Text = "Practica 04 -  ITLA  - 809.738.4852 / 809.793.2557";
            label2.Text = HMenu.pc;
        }

        // ---------------------------------------------------
        // se usa el mismo procedimiento de evento para mover
        // Este truco nos servirá para mover un formulario al pulsar en cualquier parte del mismo, incluso en cualquier control que tenga dicho formulario.
        // el hecho de que el formulario tenga o no barra de títulos no es algo relevante, ya que lo que aquí te muestro (como siempre para VB y C#) 
        // funciona indistintamente de que el formulario tenga o no borde o barra de títulos, lo que que ocurre es que es más "evidente" usar este tipo de 
        // código cuando el formulario no tiene dónde agarrarse.
        // ---------------------------------------------------
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();  // función privada usada para mover el formulario actual
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // ============================================================
        // el evento tick le asigna la hora, minuto, segundo al lblHora
        // ------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHORA.Text = DateTime.Now.ToString("hh:mm:ss "); // asigna la hora en formato de hora, hora minutos segundos
            lblFECHA.Text = DateTime.Now.ToLongDateString();   // asigna la fecha en formato largo de fecha 
        }

        // ============================================================
        // este evento es para poder agarrar el formulario por medio del panel1
        // ------------------------------------------------------------
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();  // función privada usada para poder mover el formulario actual
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // ===================================================
        // textbox
        // ---------------------------------------------------

        // El siguiente código usa el evento Enter para cambiar los colores de primer plano y 
        // de fondo de un cuadro de texto en condiciones particulares.
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario") {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Blue;   // cuando el foco esta en el textbox este cuando escriba, escribira de color azul
                //txtuser.BackColor = Color.Aqua;
            }
        }

        // ----------------------------------------------------
        // Abandona la caja de texto
        // ----------------------------------------------------
        private void txtuser_Leave(object sender, EventArgs e) 
        {
            //.Trim() = comprime texto siempre y cuando tenga espacio vacio
            // "    1234    "
            // "1234"

            if (txtuser.Text.Trim() != string.Empty) {
                Cursor.Current = Cursors.WaitCursor;   // Cursors.WaitCursor cambia la forma de ver el cursor del mouse

                // va a la calse busco y me devuelve el password
                xClave = "" + Busco.UsuarioSistema(Convert.ToString(txtuser.Text));
                
                if (xClave.Trim() != string.Empty || xClave.Trim() != null)
                {

                    xClave = xClave.ToUpper();   // ToUpper() convierte el contenido de xClave de minuscula a mayuscula
                    txtpass.UseSystemPasswordChar = true;  // indica si el texto del control TextBox debe aparecer como el carácter de contraseña predeterminado.

                    Cursor.Current = Cursors.Default;  // Cursors.WaitCursor vuelve a su forma original
                }
            }
            else {
                txtuser.Text = "Usuario";
                txtpass.Text = "Contraseña";
                txtuser.ForeColor = Color.Black;
                txtpass.ForeColor = Color.Black;
            }
        }

        // ----------------------------------------------
        // evento verifica si se presiona la tecla enter
        // ----------------------------------------------
        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)  
        {
            if ((int)e.KeyChar == (int)Keys.Enter) {  // aqui pregunta si la tecla pulsada es Enter
                e.Handled = true;

                // Trim() elimina los espacios vacios que pueda tener txtUser.Text
                if (txtuser.Text.Trim() != string.Empty) {
                    txtpass.Focus();  // Focus mueve el el cursor al siguiente textbox
                }
            }
        }

        // El siguiente código usa el evento Enter para cambiar los colores de primer plano y 
        // de fondo de un cuadro de texto en condiciones particulares.
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contraseña") {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Blue;  // cuando el foco esta en el textbox este cuando escriba, escribira de color azul
                txtpass.UseSystemPasswordChar = true; // aqui si UseSystemPasswordChar es true, no permite que puedas leer lo que escribe en el txtPass
            }
        }

        // ---------------------------------------------------
        // Abandona la caja de texto
        // ---------------------------------------------------
        private void txtpass_Leave(object sender, EventArgs e) 
        {
            if (txtpass.Text.Trim() != string.Empty) {
                TextBoxUpperCase(); // cuando abandona o sale del textbox ejecuta esta funcion
                                    // que convierte el texto que tiene el txtPass.Text de minuscula a mayuscula
            }
            else { 
                txtpass.Text = "Contraseña";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true; // aqui si UseSystemPasswordChar es true, no permite que puedas leer lo que escribe en el txtPass
            }
        }

        // evento verifica si se presiona la tecla enter
        private void txtpass_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //btnlogin.PerformClick();

                e.Handled = true;
                if (txtpass.Text.Trim() != string.Empty)
                {
                    TextBoxUpperCase();

                    // Trim() elimina los espacios vacios que pueda tener txtpass.Text
                    if (txtpass.Text.Trim() == xClave)
                    {
                        AbrirCerrarForm();  // al presionar Enter llama la funcion AbrirCerrarForm() y la ejecuta
                    }
                    else
                    {
                        txtpass.UseSystemPasswordChar = true; // aqui si UseSystemPasswordChar es true, no permite que puedas leer lo que escribe en el txtPass
                        txtpass.Clear(); // Clear() limpia el txtPass

                        MessageBox.Show("Usuario o Clave, Incorrectas", "Practica 04",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
                }
            }
        }

        // ===================================================
        // btn
        // ---------------------------------------------------
        private void btncerrar_Click(object sender, EventArgs e)
        {
            // sale de la aplicacion
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            // minimiza el formulario
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() != string.Empty) {
                TextBoxUpperCase();
                if (txtpass.Text.Trim() == xClave) {
                    // llama la funcion AbrirCerrarForm() y la ejecuta
                    AbrirCerrarForm();
                }
                else {
                    txtpass.UseSystemPasswordChar = true;  // aqui no permite que puedas leer lo que escribe en el txtPass
                    txtpass.Clear();  // Clear() limpia el txtPass
                    MessageBox.Show("Usuario o Clave, Incorrectas", "QStation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        // ===================================================
        // funciones
        // ---------------------------------------------------
        void TextBoxUpperCase()
        {
            try {
                // convierte el texto que tiene el txtPass.Text de minuscula a mayuscula
                txtpass.Text = txtpass.Text.ToUpper();
                xClave = xClave.ToUpper();
            }
            catch { 
                //
            }
        }

        void AbrirCerrarForm()
        {
            Menu xMenu = new Menu();
            this.Hide();   // esconde el formulario frmStarts
            xMenu.ShowDialog();  // muestra el formulario Menu
            //this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmStarts_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}
