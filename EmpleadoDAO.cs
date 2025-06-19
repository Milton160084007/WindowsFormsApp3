using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp3
{
    internal class EmpleadoDAO
    {
        private ConexionBD conexion = new ConexionBD();

        // Insertar empleado
        public void InsertarEmpleado(string nombre, string cedula, string correo, string telefono)
        {
            string sql = "INSERT INTO empleados (nombre, cedula, correo, telefono) VALUES (@nombre, @cedula, @correo, @telefono)";
            MySqlCommand comando = new MySqlCommand(sql, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@telefono", telefono);

            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        // Obtener empleados para mostrar en DataGridView
        public DataTable ObtenerEmpleados()
        {
            DataTable tabla = new DataTable();
            string sql = "SELECT * FROM empleados";

            MySqlCommand comando = new MySqlCommand(sql, conexion.AbrirConexion());
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

            adaptador.Fill(tabla);
            conexion.CerrarConexion();

            return tabla;
        }

        // Eliminar empleado por ID
        public void EliminarEmpleado(int id)
        {
            string sql = "DELETE FROM empleados WHERE id = @id";
            MySqlCommand comando = new MySqlCommand(sql, conexion.AbrirConexion());

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
