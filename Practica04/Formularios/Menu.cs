using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Practica04
{
    public partial class Menu : Form
    {
        bool tf = false;
        bool ft = false;
        string xtrConexion = cnn.db;

        public Menu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (ft == false) {
                btnActivos.BackColor = Color.FromArgb(0, 122, 204);
                btnECorreo.BackColor = Color.FromArgb(0, 122, 204);
                treeView1.Visible = false;
                MenuVertical.Width = 70;
                ft = true;
            }
            else {
                btnActivos.BackColor = Color.FromArgb(0, 122, 204);
                btnECorreo.BackColor = Color.FromArgb(0, 122, 204);
                treeView1.Visible = false;
                MenuVertical.Width = 250;
                ft = false;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            btnECorreo.Visible = true;
            btnActivos.Visible = true;
            btnSap.Visible = true;

            // formulario que va a llamar, Descripcion o nombre del formulario, numero de icono a llamar
            TreeNode nodo = new TreeNode("Registro");
            nodo.Nodes.Add("frmACT002", "Departamento", 9);
            nodo.Nodes.Add("frmACT006", "Ubicación", 9);
            nodo.Nodes.Add("frmACT003", "Areas", 9);
            nodo.Nodes.Add("frmACT004", "Grupos", 9);
            nodo.Nodes.Add("frmACT001", "Equipos", 9);
            nodo.Nodes.Add("frmACT008", "Aplicaciones", 9);
            nodo.Nodes.Add("frmACT009", "Problemas", 9);
            nodo.Nodes.Add("HD002", "Tickets", 9);
            treeView1.Nodes.Add(nodo);

            TreeNode nods = new TreeNode("Consulta");
            nods.Nodes.Add("frmACTC01", "Ubicación", 9);
            nods.Nodes.Add("frmACTC02", "Areas", 9);
            nods.Nodes.Add("frmACTC03", "Categorias", 9);
            nods.Nodes.Add("frmACTC04", "Grupos", 9);
            nods.Nodes.Add("frmACTC05", "Equipos", 9);
            treeView1.Nodes.Add(nods);

            treeView1.BackColor = Color.FromArgb(0, 122, 204);
            btnActivos.BackColor = Color.FromArgb(0, 122, 204);
            treeView1.ImageList = imageList1;

            treeView1.ExpandAll();

            if (tf == false) {
                btnActivos.Visible = true;
                btnECorreo.Visible = false;
                btnSap.Visible = false;

                btnActivos.BackColor = Color.FromArgb(28, 100, 187);
                treeView1.Visible = true;
                treeView1.Location = new System.Drawing.Point(3, 147);
                treeView1.BackColor = Color.FromArgb(28, 100, 187);
                treeView1.Size = new System.Drawing.Size(239, 281);
                tf = true;
            }
            else {
                PosicionAnterior();
                treeView1.Visible = false;
                treeView1.Location = new System.Drawing.Point(3, 147);
                treeView1.BackColor = Color.FromArgb(0, 122, 204);
                tf = false;
            }
        }

        private void btnECorreos_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            btnActivos.Visible = true;
            btnECorreo.Visible = true;
            btnSap.Visible = true;

            TreeNode noda = new TreeNode("Correo");
            noda.Nodes.Add("frmEnviarCorreo", "Enviar Reportes", 9);
            noda.Nodes.Add("frmEnviarPagos", "Enviar Notificación Pagos", 9);
            treeView1.Nodes.Add(noda);

            treeView1.BackColor = Color.FromArgb(0, 122, 204);
            btnECorreo.BackColor = Color.FromArgb(0, 122, 204);
            treeView1.ImageList = imageList1;

            treeView1.ExpandAll();

            if (tf == false)
            {
                btnECorreo.Visible = true;
                btnActivos.Visible = true;
                btnSap.Visible = false;

                btnECorreo.BackColor = Color.FromArgb(28, 100, 187);
                treeView1.Visible = true;
                treeView1.Location = new System.Drawing.Point(3, 193);
                treeView1.BackColor = Color.FromArgb(28, 100, 187);
                treeView1.Size = new System.Drawing.Size(239, 281);
                tf = true;
            }
            else
            {
                PosicionAnterior();
                treeView1.Visible = false;
                treeView1.Location = new System.Drawing.Point(3, 193);
                treeView1.BackColor = Color.FromArgb(0, 122, 204);
                tf = false;
            }
        }

        private void btnSap_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            btnECorreo.Visible = true;
            btnActivos.Visible = true;
            btnSap.Visible = true;

            TreeNode noda = new TreeNode("Ventas");
            noda.Nodes.Add("frmSC001", "Pedidos efectivos", 9);
            noda.Nodes.Add("frmSC002", "Pedidos Canal Moderno", 9);
            treeView1.Nodes.Add(noda);

            TreeNode nods = new TreeNode("Almacen");
            nods.Nodes.Add("frmSC003", "Transferencia Almacenes", 9);
            nods.Nodes.Add("frmSC004", "Canasto Entregados", 9);
            nods.Nodes.Add("frmSC005", "Canasto Devueltos", 9);
            treeView1.Nodes.Add(nods);

            treeView1.BackColor = Color.FromArgb(0, 122, 204);
            btnSap.BackColor = Color.FromArgb(0, 122, 204);
            treeView1.ImageList = imageList1;

            treeView1.ExpandAll();

            if (tf == false) {
                btnECorreo.Visible = true;
                btnActivos.Visible = true;
                btnSap.Visible = true;

                btnSap.BackColor = Color.FromArgb(28, 100, 187);
                treeView1.Visible = true;
                treeView1.Location = new System.Drawing.Point(3, 239);
                treeView1.BackColor = Color.FromArgb(28, 100, 187);
                treeView1.Size = new System.Drawing.Size(239, 281);
                tf = true;
            }
            else {
                PosicionAnterior();
                treeView1.Visible = false;
                treeView1.Location = new System.Drawing.Point(3, 239);
                treeView1.BackColor = Color.FromArgb(0, 122, 204);
                tf = false;
            }
        }


        //void BuscaElMenu(int itemMenu)
        //{
        //    SqlConnection cnxn = new SqlConnection(cnn.db);  cnxn.Open();
        //    SqlCommand cmmnd = new SqlCommand("SELECT MENU_ITEMS.* FROM MENU_ITEMS  WHERE IDMENU = @P1", cnxn);
        //    cmmnd.Parameters.AddWithValue("@P1", itemMenu);
        //    SqlDataReader dr = cmmnd.ExecuteReader();

        //    DataTable table = new DataTable();
        //    table.Columns.Add("Level");
        //    table.Columns.Add("Data");
        //    table.Columns.Add("Indice");

        //    while (dr.Read()) {
        //        table.Rows.Add(dr["DIVISION"].ToString(), dr["NOMBRE"].ToString(), dr["SECUENCIA"].ToString());
        //    }

        //    cmmnd.Dispose();
        //    cnxn.Close();

        //    TreeNode lastNode = new TreeNode();

        //    for (int i = 0; i < table.Rows.Count; i++) {
        //        TreeNode newNode = new TreeNode((string)table.Rows[i]["Data"]);

        //        if (i == 0)
        //            treeView1.Nodes.Add(newNode);
        //        else {
        //            int currentLevel = Convert.ToInt32(table.Rows[i]["Level"]);
        //            int lastLevel = Convert.ToInt32(table.Rows[i - 1]["Level"]);

        //            if (currentLevel < lastLevel) {
        //                if (currentLevel == 1)
        //                    treeView1.Nodes.Add(newNode);
        //                else {
        //                    TreeNode currentNode = lastNode.Parent;
        //                    for (int j = 0; j < lastLevel - currentLevel; j++)
        //                        currentNode = currentNode.Parent;

        //                    currentNode.Nodes.Add(newNode);
        //                }
        //            }
        //            else if (currentLevel == lastLevel) {
        //                if (lastLevel == 1)
        //                    treeView1.Nodes.Add(newNode);
        //                else
        //                    lastNode.Parent.Nodes.Add(newNode);
        //            }
        //            else {
        //                lastNode.Nodes.Add(newNode);
        //            }
        //        }
        //        lastNode = newNode;
        //    }
        //}

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
           //AbrirFormInPanel(new InicioResumen());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnlogoInicio_Click(null, e);
            treeView1.Visible = false;

            lblcorreo.Text = Usuario.correo;
            lbluser.Text = Usuario.cargo;
            lblusuario.Text = Usuario.nombre;
            lblID.Text = Convert.ToString(Usuario.Id);

            // UsuarioFoto(Convert.ToInt32(lblID.Text));
        }

        private void UsuarioFoto(int NumEmp)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT USUARIO.FOTO FROM USUARIO  WHERE ACTIVO = 'TRUE' AND NUMEROEMPLEADO = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", NumEmp);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            try {
                if (rdr.Read()) {
                    pictureBox2.Image = ConvertImage.ByteArrayToImage((byte[])rdr["FOTO"]);
                }
            }  catch { }

            cmmnd.Dispose();
            cnxn.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            //TreeNode node = treeView1.SelectedNode;
            //int tw = node.Level;
            //string pdsc = node.Text;
            //string pgms = node.Name;
        }

        private void MenuVertical_Click(object sender, EventArgs e)
        {
            PosicionAnterior();
        }

        private void panelContenedor_Click(object sender, EventArgs e)
        {
            PosicionAnterior();
        }

        void PosicionAnterior()
        {
            btnActivos.BackColor = Color.FromArgb(0, 122, 204);
            btnECorreo.Visible = true;
            btnActivos.Visible = true;
            treeView1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string imagen = openFileDialog1.FileName;
                pictureBox2.Image = Image.FromFile(imagen);
            }
            ActualizaFoto();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            TreeViewHitTestInfo info = treeView1.HitTest(treeView1.PointToClient(Cursor.Position));
            string pdsc = info.Node.Text;
            string pgms = info.Node.Name;

            //if (pgms == "frmACT001") { frmACT001 ShowForm = new frmACT001(); ShowForm.Show(); } //ShowForm.TopMost = true;
            //if (pgms == "frmACT002") { frmACT002 ShowForm = new frmACT002(); ShowForm.Show(); } 
            //if (pgms == "frmACT003") { frmACT003 ShowForm = new frmACT003(); ShowForm.Show(); } 
            //if (pgms == "frmACT004") { frmACT004 ShowForm = new frmACT004(); ShowForm.Show(); }
            //if (pgms == "frmACT005") { frmACT005 ShowForm = new frmACT005(); ShowForm.Show(); } 
            //if (pgms == "frmACT006") { frmACT006 ShowForm = new frmACT006(); ShowForm.Show(); } 
            //if (pgms == "frmACTC01") { frmACTC01 ShowForm = new frmACTC01(); ShowForm.Show(); } 
            //if (pgms == "frmACTC02") { frmACTC02 ShowForm = new frmACTC02(); ShowForm.Show(); } 
            //if (pgms == "frmACTC03") { frmACTC03 ShowForm = new frmACTC03(); ShowForm.Show(); } 
            //if (pgms == "frmACTC04") { frmACTC04 ShowForm = new frmACTC04(); ShowForm.Show(); } 
            //if (pgms == "frmACTC05") { frmACTC05 ShowForm = new frmACTC05(); ShowForm.Show(); } 

            //if (pgms == "frmEnviarCorreo") { frmEnviarCorreo ShowForm = new frmEnviarCorreo(); ShowForm.Show(); }
            //if (pgms == "frmEnviarPagos") { frmEnviarPagos ShowForm = new frmEnviarPagos(); ShowForm.Show(); }
            //if (pgms == "frmBarCode") { frmBarCode ShowForm = new frmBarCode(); ShowForm.Show(); }

            //if (pgms == "frmSC001") { frmSC001 ShowForm = new frmSC001(); ShowForm.Show(); }

            this.WindowState = FormWindowState.Minimized;
        }

        void ActualizaFoto()
        {
            byte[] byteArrayImagen = ConvertImage.ImageToByteArray(pictureBox2.Image);

            Cursor.Current = Cursors.WaitCursor;
            SqlConnection upconexion = new SqlConnection(cnn.db);  upconexion.Open();
            SqlCommand upQuery = new SqlCommand("UPDATE USUARIO SET FOTO = @C1  WHERE NUMEROEMPLEADO = @PV;", upconexion);

            upQuery.Parameters.AddWithValue("@PV", Int32.Parse(lblID.Text));
            upQuery.Parameters.AddWithValue("@C1", byteArrayImagen);

            upQuery.ExecuteNonQuery();
            upconexion.Close();

            Cursor.Current = Cursors.Default;
        }
    }
}
