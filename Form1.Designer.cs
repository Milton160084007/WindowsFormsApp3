namespace WindowsFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;

        // Empleados
        private System.Windows.Forms.TabPage tabEmpleados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;

        // Proyectos
        private System.Windows.Forms.TabPage tabProyectos;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.TextBox txtDescripcionProyecto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnGuardarProyecto;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.Label lblDescripcionProyecto;
        private System.Windows.Forms.Label lblFechaInicio;

        // Participaciones
        private System.Windows.Forms.TabPage tabParticipaciones;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.ComboBox cmbProyectos;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Button btnGuardarParticipacion;
        private System.Windows.Forms.Button btnEliminarParticipacion;
        private System.Windows.Forms.DataGridView dgvParticipaciones;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.Label lblRol;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmpleados = new System.Windows.Forms.TabPage();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tabProyectos = new System.Windows.Forms.TabPage();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.txtDescripcionProyecto = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarProyecto = new System.Windows.Forms.Button();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.lblDescripcionProyecto = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.tabParticipaciones = new System.Windows.Forms.TabPage();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.btnGuardarParticipacion = new System.Windows.Forms.Button();
            this.btnEliminarParticipacion = new System.Windows.Forms.Button();
            this.dgvParticipaciones = new System.Windows.Forms.DataGridView();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tabProyectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.tabParticipaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmpleados);
            this.tabControl1.Controls.Add(this.tabProyectos);
            this.tabControl1.Controls.Add(this.tabParticipaciones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabEmpleados.Controls.Add(this.txtNombre);
            this.tabEmpleados.Controls.Add(this.txtCedula);
            this.tabEmpleados.Controls.Add(this.txtCorreo);
            this.tabEmpleados.Controls.Add(this.txtTelefono);
            this.tabEmpleados.Controls.Add(this.btnGuardarEmpleado);
            this.tabEmpleados.Controls.Add(this.btnEliminarEmpleado);
            this.tabEmpleados.Controls.Add(this.dgvEmpleados);
            this.tabEmpleados.Controls.Add(this.lblNombre);
            this.tabEmpleados.Controls.Add(this.lblCedula);
            this.tabEmpleados.Controls.Add(this.lblCorreo);
            this.tabEmpleados.Controls.Add(this.lblTelefono);
            this.tabEmpleados.Location = new System.Drawing.Point(4, 22);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpleados.Size = new System.Drawing.Size(692, 474);
            this.tabEmpleados.TabIndex = 0;
            this.tabEmpleados.Text = "Empleados";
            this.tabEmpleados.Click += new System.EventHandler(this.tabEmpleados_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(100, 52);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(200, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(100, 87);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(100, 122);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(320, 15);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarEmpleado.TabIndex = 4;
            this.btnGuardarEmpleado.Text = "Guardar";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.btnGuardarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(320, 55);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarEmpleado.TabIndex = 5;
            this.btnEliminarEmpleado.Text = "Eliminar";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(15, 170);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(650, 280);
            this.dgvEmpleados.TabIndex = 6;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(23, 58);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 11;
            this.lblCedula.Text = "Cédula";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(23, 93);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(23, 128);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Teléfono";
            // 
            // tabProyectos
            // 
            this.tabProyectos.Controls.Add(this.txtNombreProyecto);
            this.tabProyectos.Controls.Add(this.txtDescripcionProyecto);
            this.tabProyectos.Controls.Add(this.dtpFechaInicio);
            this.tabProyectos.Controls.Add(this.btnGuardarProyecto);
            this.tabProyectos.Controls.Add(this.btnEliminarProyecto);
            this.tabProyectos.Controls.Add(this.dgvProyectos);
            this.tabProyectos.Controls.Add(this.lblNombreProyecto);
            this.tabProyectos.Controls.Add(this.lblDescripcionProyecto);
            this.tabProyectos.Controls.Add(this.lblFechaInicio);
            this.tabProyectos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabProyectos.Location = new System.Drawing.Point(4, 22);
            this.tabProyectos.Name = "tabProyectos";
            this.tabProyectos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProyectos.Size = new System.Drawing.Size(692, 474);
            this.tabProyectos.TabIndex = 1;
            this.tabProyectos.Text = "Proyectos";
            this.tabProyectos.UseVisualStyleBackColor = true;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(110, 17);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(200, 20);
            this.txtNombreProyecto.TabIndex = 3;
            // 
            // txtDescripcionProyecto
            // 
            this.txtDescripcionProyecto.Location = new System.Drawing.Point(110, 52);
            this.txtDescripcionProyecto.Multiline = true;
            this.txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            this.txtDescripcionProyecto.Size = new System.Drawing.Size(200, 60);
            this.txtDescripcionProyecto.TabIndex = 4;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(110, 87);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // btnGuardarProyecto
            // 
            this.btnGuardarProyecto.Location = new System.Drawing.Point(340, 15);
            this.btnGuardarProyecto.Name = "btnGuardarProyecto";
            this.btnGuardarProyecto.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarProyecto.TabIndex = 6;
            this.btnGuardarProyecto.Text = "Guardar";
            this.btnGuardarProyecto.UseVisualStyleBackColor = true;
            this.btnGuardarProyecto.Click += new System.EventHandler(this.btnGuardarProyecto_Click);
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.Location = new System.Drawing.Point(340, 60);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarProyecto.TabIndex = 7;
            this.btnEliminarProyecto.Text = "Eliminar";
            this.btnEliminarProyecto.UseVisualStyleBackColor = true;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(15, 170);
            this.dgvProyectos.MultiSelect = false;
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.ReadOnly = true;
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyectos.Size = new System.Drawing.Size(650, 280);
            this.dgvProyectos.TabIndex = 8;
            this.dgvProyectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellContentClick);
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Location = new System.Drawing.Point(23, 23);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProyecto.TabIndex = 0;
            this.lblNombreProyecto.Text = "Nombre";
            // 
            // lblDescripcionProyecto
            // 
            this.lblDescripcionProyecto.AutoSize = true;
            this.lblDescripcionProyecto.Location = new System.Drawing.Point(23, 58);
            this.lblDescripcionProyecto.Name = "lblDescripcionProyecto";
            this.lblDescripcionProyecto.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionProyecto.TabIndex = 1;
            this.lblDescripcionProyecto.Text = "Descripción";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(23, 93);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(65, 13);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // tabParticipaciones
            // 
            this.tabParticipaciones.Controls.Add(this.cmbEmpleados);
            this.tabParticipaciones.Controls.Add(this.cmbProyectos);
            this.tabParticipaciones.Controls.Add(this.txtRol);
            this.tabParticipaciones.Controls.Add(this.btnGuardarParticipacion);
            this.tabParticipaciones.Controls.Add(this.btnEliminarParticipacion);
            this.tabParticipaciones.Controls.Add(this.dgvParticipaciones);
            this.tabParticipaciones.Controls.Add(this.lblEmpleado);
            this.tabParticipaciones.Controls.Add(this.lblProyecto);
            this.tabParticipaciones.Controls.Add(this.lblRol);
            this.tabParticipaciones.Location = new System.Drawing.Point(4, 22);
            this.tabParticipaciones.Name = "tabParticipaciones";
            this.tabParticipaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabParticipaciones.Size = new System.Drawing.Size(692, 474);
            this.tabParticipaciones.TabIndex = 2;
            this.tabParticipaciones.Text = "Participaciones";
            this.tabParticipaciones.UseVisualStyleBackColor = true;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.Location = new System.Drawing.Point(100, 17);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(200, 21);
            this.cmbEmpleados.TabIndex = 3;
            this.cmbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleados_SelectedIndexChanged);
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyectos.Location = new System.Drawing.Point(100, 57);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(200, 21);
            this.cmbProyectos.TabIndex = 4;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(100, 97);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(200, 20);
            this.txtRol.TabIndex = 5;
            // 
            // btnGuardarParticipacion
            // 
            this.btnGuardarParticipacion.Location = new System.Drawing.Point(320, 15);
            this.btnGuardarParticipacion.Name = "btnGuardarParticipacion";
            this.btnGuardarParticipacion.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarParticipacion.TabIndex = 6;
            this.btnGuardarParticipacion.Text = "Guardar";
            this.btnGuardarParticipacion.UseVisualStyleBackColor = true;
            this.btnGuardarParticipacion.Click += new System.EventHandler(this.btnGuardarParticipacion_Click);
            // 
            // btnEliminarParticipacion
            // 
            this.btnEliminarParticipacion.Location = new System.Drawing.Point(320, 55);
            this.btnEliminarParticipacion.Name = "btnEliminarParticipacion";
            this.btnEliminarParticipacion.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarParticipacion.TabIndex = 7;
            this.btnEliminarParticipacion.Text = "Eliminar";
            this.btnEliminarParticipacion.UseVisualStyleBackColor = true;
            this.btnEliminarParticipacion.Click += new System.EventHandler(this.btnEliminarParticipacion_Click);
            // 
            // dgvParticipaciones
            // 
            this.dgvParticipaciones.AllowUserToAddRows = false;
            this.dgvParticipaciones.AllowUserToDeleteRows = false;
            this.dgvParticipaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipaciones.Location = new System.Drawing.Point(15, 140);
            this.dgvParticipaciones.MultiSelect = false;
            this.dgvParticipaciones.Name = "dgvParticipaciones";
            this.dgvParticipaciones.ReadOnly = true;
            this.dgvParticipaciones.RowHeadersWidth = 51;
            this.dgvParticipaciones.RowTemplate.Height = 24;
            this.dgvParticipaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParticipaciones.Size = new System.Drawing.Size(650, 310);
            this.dgvParticipaciones.TabIndex = 8;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(23, 23);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(23, 63);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(49, 13);
            this.lblProyecto.TabIndex = 1;
            this.lblProyecto.Text = "Proyecto";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(23, 103);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(23, 13);
            this.lblRol.TabIndex = 2;
            this.lblRol.Text = "Rol";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestión de Empleados y Proyectos";
            this.tabControl1.ResumeLayout(false);
            this.tabEmpleados.ResumeLayout(false);
            this.tabEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tabProyectos.ResumeLayout(false);
            this.tabProyectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.tabParticipaciones.ResumeLayout(false);
            this.tabParticipaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipaciones)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
