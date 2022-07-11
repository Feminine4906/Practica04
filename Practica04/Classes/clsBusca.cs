using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;  // permite hacer el llamado a la base de datos
using System.Data; // permite hacer el llamado a la base de datos

namespace Practica04
{
    public class cnn
    {
        // conexion string a la base de datos, le indica la ruta de conexion
        // public static string db = "Data Source=192.168.0.88;Initial Catalog=dbhdesk; user id = hd; password = hd685328@";
        // public static string db = "server=DESKTOP-79OSBGC\\SQLEXPRESS; database=DBpractica; integrated security = true";

        public static string db = "Server=localhost;Database=DBpractica;Trusted_Connection=True;";
    }

    public class HMenu
    {
        public static string nCia = "Nutriciosa";
        public static string cia = "QHDesk - Cesar Iglesias, S.A.   (  ";
        public static string pc = "  )   PC - " + System.Environment.MachineName;  

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

    // ------------------------------------
    // declaracion de clase publica Usuario
    // ------------------------------------
    public class Usuario
    {
        public static string nombre { get; set; }   // Componentes de la clase tipo string
        public static string correo { get; set; }   // Componentes de la clase tipo string
        public static string cargo { get; set; }    // Componentes de la clase tipo string
        public static int Id { get; set; }          // Componentes de la clase tipo string
    }

    public class Busco
    {
        public static string UsuarioSistema(string nameCliente)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); 
            cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT USUARIO.NUMEROEMPLEADO, USUARIO.POSICION, USUARIO.NOMBRECORTO, USUARIO.CORREO, USUARIO.CLAVE " +
                                              "  FROM USUARIO " +
                                              " WHERE ACTIVO = 'TRUE' " +
                                              "   AND NOMBRECORTO = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", nameCliente);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            {
                Usuario.cargo = Convert.ToString(rdr["POSICION"]);
                Usuario.nombre = Convert.ToString(rdr["NOMBRECORTO"]);
                Usuario.correo = Convert.ToString(rdr["CORREO"]);
                Usuario.Id = Convert.ToInt32(rdr["NUMEROEMPLEADO"]);

                return Convert.ToString(rdr["CLAVE"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string CargosPosiciones(string NumberPosicion)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT IDPOSICION, NOMBREDEPOSICION, FABRICA, DEPARTAMENTO " +
                                              "  FROM POSICIONES " +
                                              " WHERE IDPOSICION = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", NumberPosicion);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            {
                return Convert.ToString(rdr["NOMBREDEPOSICION"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Departamento(string NumberPosicion)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT IDdepartamento, NombreDepartamento, IDfabrica " +
                                              "  FROM DEPARTAMENTO " +
                                              " WHERE IDdepartamento = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", NumberPosicion);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            { 
                return Convert.ToString(rdr["NombreDepartamento"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }

        public static string Fabrica(string NumberFabrica)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();
            SqlCommand cmmnd = new SqlCommand("SELECT idfabrica, nombredefabrica, localidad " +
                                              "  FROM fabrica " +
                                              " WHERE idfabrica = @PV", cnxn);
            cmmnd.Parameters.AddWithValue("@PV", NumberFabrica);
            SqlDataReader rdr = cmmnd.ExecuteReader();

            if (rdr.Read())
            {
                return Convert.ToString(rdr["nombredefabrica"]);
            }

            cmmnd.Dispose();
            cnxn.Close();
            return null;
        }
    }
}
