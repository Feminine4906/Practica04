using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace QBOne
{
    public class cnn
    {
    //  public static string db = "server=NUT-LP-24\\SQLEXPRESS; database=dbQBOne; integrated security = true";
        public static string db = "Data Source=192.168.0.88;Initial Catalog=dbhdesk; user id = hd; password = hd685328@";
        public static string sa = "Data Source=192.168.0.88;Initial Catalog=spn; user id = hd; password = hd685328@";
        public static string bd = "Data Source=192.168.0.143;Initial Catalog=Nutriciosa_Productiva1; user id = sa; password = Mikrotik28692";
    }

    public class HMenu
    {
        public static string nCia = "Nutriciosa";
        public static string cia = "QHDesk - La Nutriciosa   (  ";
        public static string pc = "  )   PC - " + System.Environment.MachineName;
        public static string SerialNumber = "No Tiene";
        public static string pathPicture = @"\Imagenes\nutriciosa.jpg";
    }

    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class Usuario
    {
        public static string nombre { get; set; }
        public static string correo { get; set; }
        public static string cargo { get; set; }
        public static int Id { get; set; }
    }

    public class OrdenColocacion
    {
        public static int numero { get; set; }
    }

    public class Busco
    {
        public static string OS(long numOS)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT SistemaOperativo FROM SistemaOperativo  WHERE IDOS = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numOS);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["SistemaOperativo"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string colaborador(string numEmp)
        {
            SqlConnection cnxn = new SqlConnection(cnn.sa);  cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT nombre + ' ' + apellido1 + ' ' + apellido2 AS NOMBRE FROM EMPLEADOS  WHERE codigo = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numEmp);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["NOMBRE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string correo(string numEmp)
        {
            SqlConnection cnxn = new SqlConnection(cnn.sa);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT email FROM OHEM  WHERE EXTEMPNO = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numEmp);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["EMAIL"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string App(string numEmp)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT appID, appNombre FROM App  WHERE appID = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numEmp);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["NOMBRE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string MesNombre(string numDelMes)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT ID, Mes FROM SendMailMes  WHERE ID = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", Convert.ToInt32(numDelMes));
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            {
                return Convert.ToString(rdr["Mes"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Equipos(string numEquipo)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT Nombre FROM ACTIVOS WHERE ACTIVO =@PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numEquipo);
            SqlDataReader recordn = cmmnd.ExecuteReader();

            if (recordn.Read()) {
                return Convert.ToString(recordn["NOMBRE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Issue(string numEquipo)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT issueNombre FROM Issue WHERE issueID =@PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numEquipo);
            SqlDataReader recordn = cmmnd.ExecuteReader();

            if (recordn.Read()) {
                return Convert.ToString(recordn["issueNombre"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Departamento(long numUbica)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT Department FROM Department  WHERE ID = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numUbica);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["Department"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Ubicacion(long numUbica)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT UBICACION FROM UBICACION  WHERE IDUBICA = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numUbica);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["UBICACION"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Areas(long numArea)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT NOMBRE FROM AREA  WHERE AREA = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numArea);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["NOMBRE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Categorias(long numCategoria)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT NOMBRE FROM CATEGORIA  WHERE CATEGORIA = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numCategoria);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["NOMBRE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Grupos(long numGrupo)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT NOMBRE FROM GRUPO  WHERE GRUPO = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numGrupo);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["NOMBRE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string marcas(long numMarca)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT MARCA  FROM TBL_MARCAS  WHERE ID = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numMarca);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["MARCA"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string UsuarioSistema(string numCliente)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);   cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT USUARIO.NUMEROEMPLEADO, USUARIO.CARGO, USUARIO.NOMBRECORTO, USUARIO.CORREO, USUARIO.CLAVE " +
                                              "  FROM USUARIO " +
                                              " WHERE ACTIVO = 'TRUE' " + 
                                              "   AND NOMBRECORTO = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numCliente);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                Usuario.cargo = Convert.ToString(rdr["CARGO"]);
                Usuario.nombre = Convert.ToString(rdr["NOMBRECORTO"]);
                Usuario.correo = Convert.ToString(rdr["CORREO"]);
                Usuario.Id = Convert.ToInt32(rdr["NUMEROEMPLEADO"]);

                return Convert.ToString(rdr["CLAVE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string SemanaEmpieza(int numDia)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT cDia  FROM  SendMailSemanaEmpieza  WHERE ID = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", numDia);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read()) {
                return Convert.ToString(rdr["cDia"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public String dayOfWeekLarge(DateTime? date)
        {
            return date.Value.ToString("dddd");
        }

        public String dayOfWeek(DateTime? date)
        {
            return date.Value.ToString("ddd"); //, new CultureInfo("es-ES"));
        }

    }
}
