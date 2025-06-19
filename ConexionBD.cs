using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    internal class ConexionBD
    {
        private string cadena = "Server=localhost;Database=gestion_empleados_proyectos;Uid=root;Pwd=;";
        private MySqlConnection conexion;

        public ConexionBD()
        {
            conexion = new MySqlConnection(cadena);
        }

        public MySqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
