using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;  

namespace Practica04
{
    public partial class frmVENPLANTA : Form
    {
        public string varf1;  // variable publica usada para transporta la data asignada en ella hacia el formulario padre
        public string varf2;  // variable publica usada para transporta la data asignada en ella hacia el formulario padre

        public frmVENPLANTA()
        {
            InitializeComponent();
        }

        private void frmVENPLANTA_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;     // puedo presionar la tecla escape
            this.Text = HMenu.cia + "   Consulta Fabricas";

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "ID Depto");
            this.dgv.Columns.Add("Col01", "Nombre de la Fabrica");

            DataGridViewColumn
            column = dgv.Columns[0]; column.Width = 150;  // le esta indicando el ancho de la columna en pixel
            column = dgv.Columns[1]; column.Width = 500;  // le esta indicando el ancho de la columna en pixel

            Estilodgv();  // hace un llamado a esta funcion
        }

        private void Estilodgv()
        {
            // dgv es el nombre de la grilla
            this.dgv.BorderStyle = BorderStyle.None;                                 // el data grid view no tendra border en los lados
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Aqua;         //Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // le indica que tendra una linea simple horizontal entre las filas
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;      // le cambia el color al background de la linea cuando esta es seleccionada
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;         // le cambia el color a las letras de la linea cuando esta es seleccionada
            this.dgv.BackgroundColor = Color.LightGray;                              // cambia el color de fondo del data grid view

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;    // el header no tendra borde
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);  // le indica el ancho de la fila de la cabecera
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;   // el color que tendra la cabecera o header
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;            // el color de la letras en la cabecera o header
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (txtBuscar.Text.Trim() != string.Empty)
                {
                    btnBuscar.PerformClick(); // ejecuta el codigo contenido en el evento Click del boton btnSeleccion
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();    // hace un llamado a esta funcion
        }

        private void BuscarDatos()
        {
            // dgv es el nombre de la grilla
            this.dgv.Rows.Clear();  // Limpia la grilla
            this.dgv.Refresh();     // actualiza la grilla

            SqlConnection conexion = new SqlConnection(cnn.db);
            conexion.Open();   // abre la conexion a la Base de Datos
            SqlCommand sqCmd = new SqlCommand("SELECT IDFabrica, NombreDeFabrica "
                                            + "  FROM Fabrica "
                                            + " WHERE NombreDeFabrica LIKE '%" + txtBuscar.Text + "%'"
                                            + " ORDER BY NombreDeFabrica ASC", conexion);
            SqlDataReader recordset = sqCmd.ExecuteReader();

            try
            {
                while (recordset.Read())
                {  // no es fin de archivo true false
                    dgv.Rows.Add();                                                       // aqui le suma 1 a la fila, es decir x = x + 1 
                    int xRows = dgv.Rows.Count - 1;                                       // aqui le resto 1 para me indique la fila correcta en donde estoy
                    dgv[0, xRows].Value = Convert.ToString(recordset["IDFabrica"]);       // escribe en la grilla, en la celda 0 y en la fila (x), el contenido del campo IDDEPARTAMENTO     de la tabla DEPARTAMENTO
                    dgv[1, xRows].Value = Convert.ToString(recordset["NombreDeFabrica"]); // escribe en la grilla, en la celda 1 y en la fila (x), el contenido del campo NOMBREDEPARTAMENTO de la tabla DEPARTAMENTO
                }
            }
            catch
            {
                //
            }

            sqCmd.Dispose();    // libera el espacio de memoria ocupado con la data recopilada
            conexion.Close();   // cierra la conexion a la base de datos
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            try
            {   // dgv significa Data grid View 
                varf1 = dgv.CurrentRow.Cells[0].Value.ToString();  // selecciona el valor contenido en la celda actual de la columna 0 de la fila seleccionada
                varf2 = dgv.CurrentRow.Cells[1].Value.ToString();  // selecciona el valor contenido en la celda actual de la columna 1 de la fila seleccionada

                this.Close();  // cierra la ventana
            }
            catch
            {
                //
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra la ventana
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccion.PerformClick();  // ejecuta el codigo contenido en el evento Click del boton btnSeleccion
        }
    }
}
