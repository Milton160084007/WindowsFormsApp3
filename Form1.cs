using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private ConexionBD conexion = new ConexionBD();

        public Form1()
        {
            InitializeComponent();
            CargarEmpleados();
            CargarProyectos();
            CargarCombosParticipaciones();
            CargarParticipaciones();
        }

        //Empleados 

        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO empleados (nombre, cedula, correo, telefono) VALUES (@nombre, @cedula, @correo, @telefono)";
                var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show("Empleado guardado correctamente");
                LimpiarCamposEmpleado();
                CargarEmpleados();
                CargarCombosParticipaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar empleado: " + ex.Message);
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["id"].Value);
                    string sql = "DELETE FROM empleados WHERE id = @id";
                    var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    MessageBox.Show("Empleado eliminado");
                    CargarEmpleados();
                    CargarCombosParticipaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar empleado: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un empleado para eliminar");
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM empleados";
                var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conexion.CerrarConexion();

                dgvEmpleados.DataSource = dt;
                dgvEmpleados.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private void LimpiarCamposEmpleado()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }

        // Proyectos

        private void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO proyectos (nombre, descripcion, fecha_inicio) VALUES (@nombre, @descripcion, @fechaInicio)";
                var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@nombre", txtNombreProyecto.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcionProyecto.Text);
                cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show("Proyecto guardado correctamente");
                LimpiarCamposProyecto();
                CargarProyectos();
                CargarCombosParticipaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proyecto: " + ex.Message);
            }
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                try
                {
                    int id = Convert.ToInt32(dgvProyectos.SelectedRows[0].Cells["id"].Value);
                    string sql = "DELETE FROM proyectos WHERE id = @id";
                    var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    MessageBox.Show("Proyecto eliminado");
                    CargarProyectos();
                    CargarCombosParticipaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar proyecto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un proyecto para eliminar");
            }
        }

        private void CargarProyectos()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM proyectos";
                var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conexion.CerrarConexion();

                dgvProyectos.DataSource = dt;
                dgvProyectos.Columns["id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message);
            }
        }

        private void LimpiarCamposProyecto()
        {
            txtNombreProyecto.Clear();
            txtDescripcionProyecto.Clear();
            dtpFechaInicio.Value = DateTime.Today;
        }

        //Participaciones

        private void btnGuardarParticipacion_Click(object sender, EventArgs e)
        {
            if (cmbEmpleados.SelectedValue == null || cmbProyectos.SelectedValue == null)
            {
                MessageBox.Show("Selecciona empleado y proyecto");
                return;
            }

            try
            {
                int idEmpleado = Convert.ToInt32(cmbEmpleados.SelectedValue);
                int idProyecto = Convert.ToInt32(cmbProyectos.SelectedValue);
                string rol = txtRol.Text;

                string sql = "INSERT INTO participaciones (id_empleado, id_proyecto, rol) VALUES (@idEmpleado, @idProyecto, @rol)";
                var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.ExecuteNonQuery();
                conexion.CerrarConexion();

                MessageBox.Show("Participación guardada");
                LimpiarCamposParticipacion();
                CargarParticipaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar participación: " + ex.Message);
            }
        }

        private void btnEliminarParticipacion_Click(object sender, EventArgs e)
        {
            if (dgvParticipaciones.SelectedRows.Count > 0)
            {
                try
                {
                    var fila = dgvParticipaciones.SelectedRows[0];
                    int idEmpleado = Convert.ToInt32(fila.Cells["id_empleado"].Value);
                    int idProyecto = Convert.ToInt32(fila.Cells["id_proyecto"].Value);

                    string sql = "DELETE FROM participaciones WHERE id_empleado = @idEmpleado AND id_proyecto = @idProyecto";
                    var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@idProyecto", idProyecto);
                    cmd.ExecuteNonQuery();
                    conexion.CerrarConexion();

                    MessageBox.Show("Participación eliminada");
                    CargarParticipaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar participación: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una participación para eliminar");
            }
        }

        private void CargarParticipaciones()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = @"
                    SELECT p.id_empleado, e.nombre AS empleado, p.id_proyecto, pr.nombre AS proyecto, p.rol
                    FROM participaciones p
                    JOIN empleados e ON p.id_empleado = e.id
                    JOIN proyectos pr ON p.id_proyecto = pr.id";
                var cmd = new MySqlCommand(sql, conexion.AbrirConexion());
                var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conexion.CerrarConexion();

                dgvParticipaciones.DataSource = dt;

                dgvParticipaciones.Columns["id_empleado"].Visible = false;
                dgvParticipaciones.Columns["id_proyecto"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar participaciones: " + ex.Message);
            }
        }

        private void LimpiarCamposParticipacion()
        {
            txtRol.Clear();
            cmbEmpleados.SelectedIndex = -1;
            cmbProyectos.SelectedIndex = -1;
        }

        private void CargarCombosParticipaciones()
        {
            try
            {
                // Cargar empleados
                DataTable dtEmpleados = new DataTable();
                string sqlEmpleados = "SELECT id, nombre FROM empleados";
                var cmdEmp = new MySqlCommand(sqlEmpleados, conexion.AbrirConexion());
                var adapterEmp = new MySqlDataAdapter(cmdEmp);
                adapterEmp.Fill(dtEmpleados);

                cmbEmpleados.DisplayMember = "nombre";
                cmbEmpleados.ValueMember = "id";
                cmbEmpleados.DataSource = dtEmpleados;

                conexion.CerrarConexion();

                // Cargar proyectos
                DataTable dtProyectos = new DataTable();
                string sqlProy = "SELECT id, nombre FROM proyectos";
                var cmdProy = new MySqlCommand(sqlProy, conexion.AbrirConexion());
                var adapterProy = new MySqlDataAdapter(cmdProy);
                adapterProy.Fill(dtProyectos);

                cmbProyectos.DisplayMember = "nombre";
                cmbProyectos.ValueMember = "id";
                cmbProyectos.DataSource = dtProyectos;

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message);
            }
        }

        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProyectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabEmpleados_Click(object sender, EventArgs e)
        {

        }
    }
}
