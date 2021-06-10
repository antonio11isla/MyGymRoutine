namespace MyGymRoutineAdministrar
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.LsvClientes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblNombre = new System.Windows.Forms.Label();
            this.GrbFiltro = new System.Windows.Forms.GroupBox();
            this.CmbColumnaClientes = new System.Windows.Forms.ComboBox();
            this.BtnMostrarEntrenadores = new System.Windows.Forms.Button();
            this.BtnFiltrarEntrenadores = new System.Windows.Forms.Button();
            this.BtnMostrarClientes = new System.Windows.Forms.Button();
            this.BtnFiltrarClientes = new System.Windows.Forms.Button();
            this.LblContenido = new System.Windows.Forms.Label();
            this.TxtFiltro = new System.Windows.Forms.TextBox();
            this.LblColumna = new System.Windows.Forms.Label();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.BtnEntrenadores = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipAdmin = new System.Windows.Forms.ToolTip(this.components);
            this.BTnModificarEntrenador = new System.Windows.Forms.Button();
            this.BtnEliminarClientes = new System.Windows.Forms.Button();
            this.BtnEliminarEntrenador = new System.Windows.Forms.Button();
            this.BtnAnadirClientes = new System.Windows.Forms.Button();
            this.BtnAnadirEntenador = new System.Windows.Forms.Button();
            this.LsvEntrenadores = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnVentanaMin = new System.Windows.Forms.Button();
            this.BtnVentanaMax = new System.Windows.Forms.Button();
            this.BtnMiminizar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.openFileDialogAdministrador = new System.Windows.Forms.OpenFileDialog();
            this.PcbImagen = new MyGymRoutineAdministrar.CircularPictureBox();
            this.GrbFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnModificarCliente.Location = new System.Drawing.Point(935, 696);
            this.BtnModificarCliente.Margin = new System.Windows.Forms.Padding(10);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(126, 35);
            this.BtnModificarCliente.TabIndex = 7;
            this.BtnModificarCliente.Text = "Modificar";
            this.toolTipAdmin.SetToolTip(this.BtnModificarCliente, "Seleccione con un click en la tabla el cliente y posteriormente pulse modificar p" +
        "ara poder modificarlo");
            this.BtnModificarCliente.UseVisualStyleBackColor = true;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // LsvClientes
            // 
            this.LsvClientes.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.LsvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.LsvClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvClientes.FullRowSelect = true;
            this.LsvClientes.HideSelection = false;
            this.LsvClientes.Location = new System.Drawing.Point(626, 126);
            this.LsvClientes.MultiSelect = false;
            this.LsvClientes.Name = "LsvClientes";
            this.LsvClientes.Size = new System.Drawing.Size(581, 530);
            this.LsvClientes.TabIndex = 5;
            this.toolTipAdmin.SetToolTip(this.LsvClientes, "Haga doble click en el cliente para poder modificarlo");
            this.LsvClientes.UseCompatibleStateImageBehavior = false;
            this.LsvClientes.View = System.Windows.Forms.View.Details;
            this.LsvClientes.DoubleClick += new System.EventHandler(this.LsvClientes_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellidos";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Usuario";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Correo Electronico";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fecha de nacimeinto";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Entrenador";
            this.columnHeader7.Width = 150;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombre.Location = new System.Drawing.Point(626, 73);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblNombre.Size = new System.Drawing.Size(515, 24);
            this.LblNombre.TabIndex = 48;
            this.LblNombre.Text = "Nombre Apellido1 Apellido2";
            this.toolTipAdmin.SetToolTip(this.LblNombre, "Pulse para abrir su perfil");
            this.LblNombre.Click += new System.EventHandler(this.LblNombre_Click);
            this.LblNombre.MouseLeave += new System.EventHandler(this.LblNombre_MouseLeave);
            this.LblNombre.MouseHover += new System.EventHandler(this.LblNombre_MouseHover);
            // 
            // GrbFiltro
            // 
            this.GrbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.GrbFiltro.Controls.Add(this.CmbColumnaClientes);
            this.GrbFiltro.Controls.Add(this.BtnMostrarEntrenadores);
            this.GrbFiltro.Controls.Add(this.BtnFiltrarEntrenadores);
            this.GrbFiltro.Controls.Add(this.BtnMostrarClientes);
            this.GrbFiltro.Controls.Add(this.BtnFiltrarClientes);
            this.GrbFiltro.Controls.Add(this.LblContenido);
            this.GrbFiltro.Controls.Add(this.TxtFiltro);
            this.GrbFiltro.Controls.Add(this.LblColumna);
            this.GrbFiltro.Controls.Add(this.CmbFiltro);
            this.GrbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrbFiltro.Location = new System.Drawing.Point(249, 126);
            this.GrbFiltro.Name = "GrbFiltro";
            this.GrbFiltro.Size = new System.Drawing.Size(340, 224);
            this.GrbFiltro.TabIndex = 0;
            this.GrbFiltro.TabStop = false;
            this.GrbFiltro.Text = "Filtro";
            // 
            // CmbColumnaClientes
            // 
            this.CmbColumnaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbColumnaClientes.FormattingEnabled = true;
            this.CmbColumnaClientes.Items.AddRange(new object[] {
            "Nombre",
            "Apellidos",
            "Usuario",
            "Correo electrónico",
            "Fecha nacimiento",
            "Teléfono",
            "Entrenador"});
            this.CmbColumnaClientes.Location = new System.Drawing.Point(135, 38);
            this.CmbColumnaClientes.Name = "CmbColumnaClientes";
            this.CmbColumnaClientes.Size = new System.Drawing.Size(187, 26);
            this.CmbColumnaClientes.TabIndex = 9;
            this.toolTipAdmin.SetToolTip(this.CmbColumnaClientes, "Seleccione la columna por la que filtrar");
            // 
            // BtnMostrarEntrenadores
            // 
            this.BtnMostrarEntrenadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMostrarEntrenadores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMostrarEntrenadores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMostrarEntrenadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnMostrarEntrenadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnMostrarEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarEntrenadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnMostrarEntrenadores.Location = new System.Drawing.Point(180, 158);
            this.BtnMostrarEntrenadores.Margin = new System.Windows.Forms.Padding(10);
            this.BtnMostrarEntrenadores.Name = "BtnMostrarEntrenadores";
            this.BtnMostrarEntrenadores.Size = new System.Drawing.Size(132, 35);
            this.BtnMostrarEntrenadores.TabIndex = 12;
            this.BtnMostrarEntrenadores.Text = "Quitar filtro";
            this.toolTipAdmin.SetToolTip(this.BtnMostrarEntrenadores, "Pulse para volver a mostrar todos los entrenadores");
            this.BtnMostrarEntrenadores.UseVisualStyleBackColor = false;
            this.BtnMostrarEntrenadores.Click += new System.EventHandler(this.BtnMostrarEntrenadores_Click);
            // 
            // BtnFiltrarEntrenadores
            // 
            this.BtnFiltrarEntrenadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFiltrarEntrenadores.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFiltrarEntrenadores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFiltrarEntrenadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnFiltrarEntrenadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnFiltrarEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrarEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrarEntrenadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnFiltrarEntrenadores.Location = new System.Drawing.Point(28, 158);
            this.BtnFiltrarEntrenadores.Margin = new System.Windows.Forms.Padding(10);
            this.BtnFiltrarEntrenadores.Name = "BtnFiltrarEntrenadores";
            this.BtnFiltrarEntrenadores.Size = new System.Drawing.Size(132, 35);
            this.BtnFiltrarEntrenadores.TabIndex = 11;
            this.BtnFiltrarEntrenadores.Text = "Filtrar";
            this.toolTipAdmin.SetToolTip(this.BtnFiltrarEntrenadores, "Pulse para filtrar entrenadores");
            this.BtnFiltrarEntrenadores.UseVisualStyleBackColor = false;
            this.BtnFiltrarEntrenadores.Click += new System.EventHandler(this.BtnFiltrarEntrenadores_Click);
            // 
            // BtnMostrarClientes
            // 
            this.BtnMostrarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMostrarClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMostrarClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMostrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnMostrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnMostrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnMostrarClientes.Location = new System.Drawing.Point(180, 158);
            this.BtnMostrarClientes.Margin = new System.Windows.Forms.Padding(10);
            this.BtnMostrarClientes.Name = "BtnMostrarClientes";
            this.BtnMostrarClientes.Size = new System.Drawing.Size(132, 35);
            this.BtnMostrarClientes.TabIndex = 12;
            this.BtnMostrarClientes.Text = "Quitar filtro";
            this.toolTipAdmin.SetToolTip(this.BtnMostrarClientes, "Pulse para volver a mostrar todos los clientes");
            this.BtnMostrarClientes.UseVisualStyleBackColor = false;
            this.BtnMostrarClientes.Click += new System.EventHandler(this.BtnMostrarClientes_Click);
            // 
            // BtnFiltrarClientes
            // 
            this.BtnFiltrarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFiltrarClientes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFiltrarClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnFiltrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnFiltrarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnFiltrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnFiltrarClientes.Location = new System.Drawing.Point(28, 158);
            this.BtnFiltrarClientes.Margin = new System.Windows.Forms.Padding(10);
            this.BtnFiltrarClientes.Name = "BtnFiltrarClientes";
            this.BtnFiltrarClientes.Size = new System.Drawing.Size(132, 35);
            this.BtnFiltrarClientes.TabIndex = 11;
            this.BtnFiltrarClientes.Text = "Filtrar";
            this.toolTipAdmin.SetToolTip(this.BtnFiltrarClientes, "Pulse para filtrar clientes");
            this.BtnFiltrarClientes.UseVisualStyleBackColor = false;
            this.BtnFiltrarClientes.Click += new System.EventHandler(this.BtnFiltrarClientes_Click);
            // 
            // LblContenido
            // 
            this.LblContenido.AutoSize = true;
            this.LblContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContenido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblContenido.Location = new System.Drawing.Point(15, 93);
            this.LblContenido.Name = "LblContenido";
            this.LblContenido.Size = new System.Drawing.Size(90, 18);
            this.LblContenido.TabIndex = 0;
            this.LblContenido.Text = "Contenido:";
            // 
            // TxtFiltro
            // 
            this.TxtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltro.Location = new System.Drawing.Point(135, 90);
            this.TxtFiltro.Name = "TxtFiltro";
            this.TxtFiltro.Size = new System.Drawing.Size(187, 24);
            this.TxtFiltro.TabIndex = 10;
            this.toolTipAdmin.SetToolTip(this.TxtFiltro, "Introduzca el contenido del filtro");
            // 
            // LblColumna
            // 
            this.LblColumna.AutoSize = true;
            this.LblColumna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColumna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblColumna.Location = new System.Drawing.Point(15, 41);
            this.LblColumna.Name = "LblColumna";
            this.LblColumna.Size = new System.Drawing.Size(80, 18);
            this.LblColumna.TabIndex = 0;
            this.LblColumna.Text = "Columna:";
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Nombre",
            "Apellidos",
            "Usuario",
            "Correo electrónico"});
            this.CmbFiltro.Location = new System.Drawing.Point(135, 38);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(187, 26);
            this.CmbFiltro.TabIndex = 9;
            this.toolTipAdmin.SetToolTip(this.CmbFiltro, "Seleccione la columna por la que filtrar");
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnLogOut.Location = new System.Drawing.Point(15, 751);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(184, 35);
            this.BtnLogOut.TabIndex = 49;
            this.BtnLogOut.Text = "Cerrar sesión";
            this.toolTipAdmin.SetToolTip(this.BtnLogOut, "Pulse para cerrar sesión y volver al menú de inicio de sesión");
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnSalir.Location = new System.Drawing.Point(15, 710);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(184, 35);
            this.BtnSalir.TabIndex = 50;
            this.BtnSalir.Text = "Salir";
            this.toolTipAdmin.SetToolTip(this.BtnSalir, "Pulse para salir de la aplicación");
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PcbLogo
            // 
            this.PcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.PcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PcbLogo.Image")));
            this.PcbLogo.Location = new System.Drawing.Point(15, 37);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(184, 119);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbLogo.TabIndex = 35;
            this.PcbLogo.TabStop = false;
            // 
            // BtnEntrenadores
            // 
            this.BtnEntrenadores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEntrenadores.FlatAppearance.BorderSize = 0;
            this.BtnEntrenadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnEntrenadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnEntrenadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrenadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnEntrenadores.Location = new System.Drawing.Point(15, 187);
            this.BtnEntrenadores.Name = "BtnEntrenadores";
            this.BtnEntrenadores.Size = new System.Drawing.Size(184, 35);
            this.BtnEntrenadores.TabIndex = 1;
            this.BtnEntrenadores.Text = "Entrenadores";
            this.toolTipAdmin.SetToolTip(this.BtnEntrenadores, "Pulse para administrar los entrenadores");
            this.BtnEntrenadores.UseVisualStyleBackColor = true;
            this.BtnEntrenadores.Click += new System.EventHandler(this.BtnEntrenadores_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnClientes.Location = new System.Drawing.Point(15, 228);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(184, 35);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.toolTipAdmin.SetToolTip(this.BtnClientes, "Pulse para administar los clientes");
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.pictureBox1.Location = new System.Drawing.Point(214, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 749);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BTnModificarEntrenador
            // 
            this.BTnModificarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTnModificarEntrenador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTnModificarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BTnModificarEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BTnModificarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTnModificarEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnModificarEntrenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BTnModificarEntrenador.Location = new System.Drawing.Point(935, 696);
            this.BTnModificarEntrenador.Margin = new System.Windows.Forms.Padding(10);
            this.BTnModificarEntrenador.Name = "BTnModificarEntrenador";
            this.BTnModificarEntrenador.Size = new System.Drawing.Size(126, 35);
            this.BTnModificarEntrenador.TabIndex = 7;
            this.BTnModificarEntrenador.Text = "Modificar";
            this.toolTipAdmin.SetToolTip(this.BTnModificarEntrenador, "Seleccione con un click en la tabla el entrenador y posteriormente pulse modifica" +
        "r para poder modificarlo");
            this.BTnModificarEntrenador.UseVisualStyleBackColor = true;
            this.BTnModificarEntrenador.Click += new System.EventHandler(this.BTnModificarEntrenador_Click);
            // 
            // BtnEliminarClientes
            // 
            this.BtnEliminarClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnEliminarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnEliminarClientes.Location = new System.Drawing.Point(1081, 696);
            this.BtnEliminarClientes.Margin = new System.Windows.Forms.Padding(10);
            this.BtnEliminarClientes.Name = "BtnEliminarClientes";
            this.BtnEliminarClientes.Size = new System.Drawing.Size(126, 35);
            this.BtnEliminarClientes.TabIndex = 8;
            this.BtnEliminarClientes.Text = "Eliminar";
            this.toolTipAdmin.SetToolTip(this.BtnEliminarClientes, "Seleccione con un click en la tabla el cliente y posteriormente pulse eliminarlar" +
        " para eliminarlo");
            this.BtnEliminarClientes.UseVisualStyleBackColor = true;
            this.BtnEliminarClientes.Click += new System.EventHandler(this.BtnEliminarClientes_Click);
            // 
            // BtnEliminarEntrenador
            // 
            this.BtnEliminarEntrenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarEntrenador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEliminarEntrenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnEliminarEntrenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnEliminarEntrenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarEntrenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnEliminarEntrenador.Location = new System.Drawing.Point(1081, 696);
            this.BtnEliminarEntrenador.Margin = new System.Windows.Forms.Padding(10);
            this.BtnEliminarEntrenador.Name = "BtnEliminarEntrenador";
            this.BtnEliminarEntrenador.Size = new System.Drawing.Size(126, 35);
            this.BtnEliminarEntrenador.TabIndex = 8;
            this.BtnEliminarEntrenador.Text = "Eliminar";
            this.toolTipAdmin.SetToolTip(this.BtnEliminarEntrenador, "Seleccione con un click en la tabla el entrenador y posteriormente pulse eliminar" +
        "lar para eliminarlo");
            this.BtnEliminarEntrenador.UseVisualStyleBackColor = true;
            this.BtnEliminarEntrenador.Click += new System.EventHandler(this.BtnEliminarEntrenador_Click);
            // 
            // BtnAnadirClientes
            // 
            this.BtnAnadirClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAnadirClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnadirClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnAnadirClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnAnadirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnadirClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnadirClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnAnadirClientes.Location = new System.Drawing.Point(789, 696);
            this.BtnAnadirClientes.Margin = new System.Windows.Forms.Padding(10);
            this.BtnAnadirClientes.Name = "BtnAnadirClientes";
            this.BtnAnadirClientes.Size = new System.Drawing.Size(126, 35);
            this.BtnAnadirClientes.TabIndex = 6;
            this.BtnAnadirClientes.Text = "Añadir";
            this.toolTipAdmin.SetToolTip(this.BtnAnadirClientes, "Pulsar para añadir un nuevo cliente");
            this.BtnAnadirClientes.UseVisualStyleBackColor = true;
            this.BtnAnadirClientes.Click += new System.EventHandler(this.BtnAnadirClientes_Click);
            // 
            // BtnAnadirEntenador
            // 
            this.BtnAnadirEntenador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAnadirEntenador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnadirEntenador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnAnadirEntenador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnAnadirEntenador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnadirEntenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnadirEntenador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnAnadirEntenador.Location = new System.Drawing.Point(789, 696);
            this.BtnAnadirEntenador.Margin = new System.Windows.Forms.Padding(10);
            this.BtnAnadirEntenador.Name = "BtnAnadirEntenador";
            this.BtnAnadirEntenador.Size = new System.Drawing.Size(126, 35);
            this.BtnAnadirEntenador.TabIndex = 6;
            this.BtnAnadirEntenador.Text = "Añadir";
            this.toolTipAdmin.SetToolTip(this.BtnAnadirEntenador, "Pulsar para añadir un nuevo entrenador");
            this.BtnAnadirEntenador.UseVisualStyleBackColor = true;
            this.BtnAnadirEntenador.Click += new System.EventHandler(this.BtnAnadirEntenador_Click);
            // 
            // LsvEntrenadores
            // 
            this.LsvEntrenadores.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.LsvEntrenadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LsvEntrenadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.LsvEntrenadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsvEntrenadores.FullRowSelect = true;
            this.LsvEntrenadores.HideSelection = false;
            this.LsvEntrenadores.Location = new System.Drawing.Point(626, 126);
            this.LsvEntrenadores.MultiSelect = false;
            this.LsvEntrenadores.Name = "LsvEntrenadores";
            this.LsvEntrenadores.Size = new System.Drawing.Size(581, 530);
            this.LsvEntrenadores.TabIndex = 3;
            this.toolTipAdmin.SetToolTip(this.LsvEntrenadores, "Haga doble click en el entrenador para poder modificarlo");
            this.LsvEntrenadores.UseCompatibleStateImageBehavior = false;
            this.LsvEntrenadores.View = System.Windows.Forms.View.Details;
            this.LsvEntrenadores.DoubleClick += new System.EventHandler(this.LsvEntrenadores_DoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nombre";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Apellidos";
            this.columnHeader11.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Usuario";
            this.columnHeader12.Width = 150;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Correo Electronico";
            this.columnHeader13.Width = 150;
            // 
            // BtnVentanaMin
            // 
            this.BtnVentanaMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVentanaMin.BackColor = System.Drawing.Color.White;
            this.BtnVentanaMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVentanaMin.BackgroundImage")));
            this.BtnVentanaMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVentanaMin.FlatAppearance.BorderSize = 0;
            this.BtnVentanaMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(251)))));
            this.BtnVentanaMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnVentanaMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentanaMin.Location = new System.Drawing.Point(1201, 4);
            this.BtnVentanaMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentanaMin.Name = "BtnVentanaMin";
            this.BtnVentanaMin.Size = new System.Drawing.Size(30, 30);
            this.BtnVentanaMin.TabIndex = 52;
            this.BtnVentanaMin.UseVisualStyleBackColor = false;
            this.BtnVentanaMin.Click += new System.EventHandler(this.BtnVentanaMin_Click);
            // 
            // BtnVentanaMax
            // 
            this.BtnVentanaMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVentanaMax.BackColor = System.Drawing.Color.White;
            this.BtnVentanaMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVentanaMax.BackgroundImage")));
            this.BtnVentanaMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVentanaMax.FlatAppearance.BorderSize = 0;
            this.BtnVentanaMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(251)))));
            this.BtnVentanaMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnVentanaMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentanaMax.Location = new System.Drawing.Point(1201, 4);
            this.BtnVentanaMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnVentanaMax.Name = "BtnVentanaMax";
            this.BtnVentanaMax.Size = new System.Drawing.Size(30, 30);
            this.BtnVentanaMax.TabIndex = 91;
            this.BtnVentanaMax.UseVisualStyleBackColor = false;
            this.BtnVentanaMax.Click += new System.EventHandler(this.BtnVentanaMax_Click);
            // 
            // BtnMiminizar
            // 
            this.BtnMiminizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMiminizar.BackColor = System.Drawing.Color.White;
            this.BtnMiminizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMiminizar.BackgroundImage")));
            this.BtnMiminizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMiminizar.FlatAppearance.BorderSize = 0;
            this.BtnMiminizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(251)))));
            this.BtnMiminizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnMiminizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMiminizar.Location = new System.Drawing.Point(1156, 4);
            this.BtnMiminizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMiminizar.Name = "BtnMiminizar";
            this.BtnMiminizar.Size = new System.Drawing.Size(30, 30);
            this.BtnMiminizar.TabIndex = 51;
            this.BtnMiminizar.UseVisualStyleBackColor = false;
            this.BtnMiminizar.Click += new System.EventHandler(this.BtnMiminizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackColor = System.Drawing.Color.White;
            this.BtnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.BackgroundImage")));
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(45)))), ((int)(((byte)(251)))));
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Location = new System.Drawing.Point(1246, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 93;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1279, 1);
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 820);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1279, 1);
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 821);
            this.pictureBox4.TabIndex = 98;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(1278, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1, 821);
            this.pictureBox5.TabIndex = 99;
            this.pictureBox5.TabStop = false;
            // 
            // openFileDialogAdministrador
            // 
            this.openFileDialogAdministrador.FileName = "openFileDialog1";
            // 
            // PcbImagen
            // 
            this.PcbImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PcbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.PcbImagen.Image = ((System.Drawing.Image)(resources.GetObject("PcbImagen.Image")));
            this.PcbImagen.Location = new System.Drawing.Point(1147, 53);
            this.PcbImagen.Name = "PcbImagen";
            this.PcbImagen.Size = new System.Drawing.Size(60, 55);
            this.PcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbImagen.TabIndex = 111;
            this.PcbImagen.TabStop = false;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1279, 821);
            this.Controls.Add(this.PcbImagen);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtnVentanaMin);
            this.Controls.Add(this.BtnVentanaMax);
            this.Controls.Add(this.BtnMiminizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.LsvEntrenadores);
            this.Controls.Add(this.BtnEliminarEntrenador);
            this.Controls.Add(this.BtnEliminarClientes);
            this.Controls.Add(this.BTnModificarEntrenador);
            this.Controls.Add(this.BtnModificarCliente);
            this.Controls.Add(this.BtnAnadirClientes);
            this.Controls.Add(this.BtnAnadirEntenador);
            this.Controls.Add(this.LsvClientes);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.GrbFiltro);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.BtnEntrenadores);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1279, 821);
            this.Name = "FrmAdministrador";
            this.Text = "MyGymRoutine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdministrador_FormClosing);
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAdministrador_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmAdministrador_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmAdministrador_MouseUp);
            this.GrbFiltro.ResumeLayout(false);
            this.GrbFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.ListView LsvClientes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox GrbFiltro;
        private System.Windows.Forms.ComboBox CmbColumnaClientes;
        private System.Windows.Forms.Button BtnMostrarClientes;
        private System.Windows.Forms.Button BtnMostrarEntrenadores;
        private System.Windows.Forms.Button BtnFiltrarClientes;
        private System.Windows.Forms.Label LblContenido;
        private System.Windows.Forms.Label LblColumna;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Button BtnEntrenadores;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTipAdmin;
        private System.Windows.Forms.Button BtnFiltrarEntrenadores;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Button BTnModificarEntrenador;
        private System.Windows.Forms.Button BtnEliminarClientes;
        private System.Windows.Forms.Button BtnEliminarEntrenador;
        private System.Windows.Forms.Button BtnAnadirClientes;
        private System.Windows.Forms.Button BtnAnadirEntenador;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView LsvEntrenadores;
        private System.Windows.Forms.TextBox TxtFiltro;
        private System.Windows.Forms.Button BtnVentanaMin;
        private System.Windows.Forms.Button BtnVentanaMax;
        private System.Windows.Forms.Button BtnMiminizar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.OpenFileDialog openFileDialogAdministrador;
        private CircularPictureBox PcbImagen;
    }
}