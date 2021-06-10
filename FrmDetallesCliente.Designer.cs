
namespace MyGymRoutineAdministrar
{
    partial class FrmDetallesCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallesCliente));
            this.TxtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.LblCorreoElectronico = new System.Windows.Forms.Label();
            this.BtnUserAleatorio = new System.Windows.Forms.Button();
            this.BtnContraAleatoria = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnAnadir = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblPeso = new System.Windows.Forms.Label();
            this.LblFrecuencia = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblTlf = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.CmbFrecuencia = new System.Windows.Forms.ComboBox();
            this.MtbTlf = new System.Windows.Forms.MaskedTextBox();
            this.MtbFechaNac = new System.Windows.Forms.MaskedTextBox();
            this.CmbEntrenador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderDetallesClientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipDetallesClientes = new System.Windows.Forms.ToolTip(this.components);
            this.TxtPatologias = new System.Windows.Forms.TextBox();
            this.LblPatologías = new System.Windows.Forms.Label();
            this.TxtAltura = new System.Windows.Forms.TextBox();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.PcbBorde = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChbNotificar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetallesClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCorreoElectronico
            // 
            this.TxtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoElectronico.Location = new System.Drawing.Point(66, 202);
            this.TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            this.TxtCorreoElectronico.Size = new System.Drawing.Size(313, 24);
            this.TxtCorreoElectronico.TabIndex = 3;
            this.toolTipDetallesClientes.SetToolTip(this.TxtCorreoElectronico, "Introduzca el correo electrónico del cliente");
            this.TxtCorreoElectronico.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreoElectronico_Validating);
            // 
            // LblCorreoElectronico
            // 
            this.LblCorreoElectronico.AutoSize = true;
            this.LblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreoElectronico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCorreoElectronico.Location = new System.Drawing.Point(66, 181);
            this.LblCorreoElectronico.Name = "LblCorreoElectronico";
            this.LblCorreoElectronico.Size = new System.Drawing.Size(155, 18);
            this.LblCorreoElectronico.TabIndex = 0;
            this.LblCorreoElectronico.Text = "Correo electrónico:";
            this.toolTipDetallesClientes.SetToolTip(this.LblCorreoElectronico, "Introduzca el correo electrónico del cliente");
            // 
            // BtnUserAleatorio
            // 
            this.BtnUserAleatorio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUserAleatorio.FlatAppearance.BorderSize = 0;
            this.BtnUserAleatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnUserAleatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnUserAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserAleatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnUserAleatorio.Location = new System.Drawing.Point(66, 354);
            this.BtnUserAleatorio.Name = "BtnUserAleatorio";
            this.BtnUserAleatorio.Size = new System.Drawing.Size(313, 24);
            this.BtnUserAleatorio.TabIndex = 6;
            this.BtnUserAleatorio.Text = "Generar usuario aleatorio";
            this.toolTipDetallesClientes.SetToolTip(this.BtnUserAleatorio, "Pulse para generar un usuario aleatorio");
            this.BtnUserAleatorio.UseVisualStyleBackColor = false;
            this.BtnUserAleatorio.Click += new System.EventHandler(this.BtnUserAleatorio_Click);
            // 
            // BtnContraAleatoria
            // 
            this.BtnContraAleatoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnContraAleatoria.FlatAppearance.BorderSize = 0;
            this.BtnContraAleatoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnContraAleatoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnContraAleatoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContraAleatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContraAleatoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnContraAleatoria.Location = new System.Drawing.Point(66, 445);
            this.BtnContraAleatoria.Name = "BtnContraAleatoria";
            this.BtnContraAleatoria.Size = new System.Drawing.Size(313, 24);
            this.BtnContraAleatoria.TabIndex = 8;
            this.BtnContraAleatoria.Text = "Generar contraseña aleatoria";
            this.toolTipDetallesClientes.SetToolTip(this.BtnContraAleatoria, "Pulse para generar una contraseña aleatoria");
            this.BtnContraAleatoria.UseVisualStyleBackColor = false;
            this.BtnContraAleatoria.Click += new System.EventHandler(this.BtnContraAleatoria_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnCancelar.Location = new System.Drawing.Point(132, 485);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(173, 40);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.toolTipDetallesClientes.SetToolTip(this.BtnCancelar, "Pulse para cancelar la operación");
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(66, 415);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(313, 24);
            this.TxtContrasena.TabIndex = 7;
            this.toolTipDetallesClientes.SetToolTip(this.TxtContrasena, "Introduzca la contraseña del cliente");
            this.TxtContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.TxtContrasena_Validating);
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblContrasena.Location = new System.Drawing.Point(66, 394);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(100, 18);
            this.LblContrasena.TabIndex = 0;
            this.LblContrasena.Text = "Contraseña:";
            this.toolTipDetallesClientes.SetToolTip(this.LblContrasena, "Introduzca la contraseña del cliente");
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(66, 324);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(313, 24);
            this.TxtUsuario.TabIndex = 5;
            this.toolTipDetallesClientes.SetToolTip(this.TxtUsuario, "Introduzca el usuario del cliente");
            this.TxtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsuario_Validating);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Location = new System.Drawing.Point(66, 303);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 18);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario:";
            this.toolTipDetallesClientes.SetToolTip(this.LblUsuario, "Introduzca el usuario del cliente");
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(66, 141);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(313, 24);
            this.TxtApellidos.TabIndex = 2;
            this.toolTipDetallesClientes.SetToolTip(this.TxtApellidos, "Introduzca los apellidos del cliente");
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.TxtApellidos_Validating);
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblApellidos.Location = new System.Drawing.Point(66, 120);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(81, 18);
            this.LblApellidos.TabIndex = 0;
            this.LblApellidos.Text = "Apellidos:";
            this.toolTipDetallesClientes.SetToolTip(this.LblApellidos, "Introduzca los apellidos del cliente");
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(66, 80);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(313, 24);
            this.TxtNombre.TabIndex = 1;
            this.toolTipDetallesClientes.SetToolTip(this.TxtNombre, "Introduzca el nombre del cliente");
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombre.Location = new System.Drawing.Point(66, 59);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(73, 18);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            this.toolTipDetallesClientes.SetToolTip(this.LblNombre, "Introduzca el nombre del cliente");
            // 
            // BtnAnadir
            // 
            this.BtnAnadir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAnadir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAnadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnAnadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnAnadir.Location = new System.Drawing.Point(511, 485);
            this.BtnAnadir.Name = "BtnAnadir";
            this.BtnAnadir.Size = new System.Drawing.Size(173, 40);
            this.BtnAnadir.TabIndex = 16;
            this.BtnAnadir.Text = "Añadir";
            this.toolTipDetallesClientes.SetToolTip(this.BtnAnadir, "Pulse para añadir al cliente");
            this.BtnAnadir.UseVisualStyleBackColor = false;
            this.BtnAnadir.Click += new System.EventHandler(this.BtnAnadir_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnModificar.Location = new System.Drawing.Point(511, 485);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(173, 40);
            this.BtnModificar.TabIndex = 16;
            this.BtnModificar.Text = "Modificar";
            this.toolTipDetallesClientes.SetToolTip(this.BtnModificar, "Pulse para modificar al cliente");
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPeso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPeso.Location = new System.Drawing.Point(445, 120);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(47, 18);
            this.LblPeso.TabIndex = 0;
            this.LblPeso.Text = "Peso";
            // 
            // LblFrecuencia
            // 
            this.LblFrecuencia.AutoSize = true;
            this.LblFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFrecuencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFrecuencia.Location = new System.Drawing.Point(445, 303);
            this.LblFrecuencia.Name = "LblFrecuencia";
            this.LblFrecuencia.Size = new System.Drawing.Size(282, 18);
            this.LblFrecuencia.TabIndex = 0;
            this.LblFrecuencia.Text = "Frecuencia con la que hace deporte:";
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAltura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAltura.Location = new System.Drawing.Point(445, 181);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(56, 18);
            this.LblAltura.TabIndex = 0;
            this.LblAltura.Text = "Altura:";
            // 
            // LblTlf
            // 
            this.LblTlf.AutoSize = true;
            this.LblTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTlf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTlf.Location = new System.Drawing.Point(445, 59);
            this.LblTlf.Name = "LblTlf";
            this.LblTlf.Size = new System.Drawing.Size(124, 18);
            this.LblTlf.TabIndex = 0;
            this.LblTlf.Text = "Teléfono móvil:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFecha.Location = new System.Drawing.Point(66, 242);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(169, 18);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha de nacimiento:";
            // 
            // CmbFrecuencia
            // 
            this.CmbFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFrecuencia.FormattingEnabled = true;
            this.CmbFrecuencia.Items.AddRange(new object[] {
            "nunca",
            "menos de 2 días",
            "entre 2 y 5 días",
            "más de 5 días"});
            this.CmbFrecuencia.Location = new System.Drawing.Point(445, 324);
            this.CmbFrecuencia.Name = "CmbFrecuencia";
            this.CmbFrecuencia.Size = new System.Drawing.Size(313, 26);
            this.CmbFrecuencia.TabIndex = 13;
            this.toolTipDetallesClientes.SetToolTip(this.CmbFrecuencia, "Introduzca la frecuencia con la que entrena el cliente(opcional)");
            this.CmbFrecuencia.Validating += new System.ComponentModel.CancelEventHandler(this.CmbFrecuencia_Validating);
            // 
            // MtbTlf
            // 
            this.MtbTlf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTlf.Location = new System.Drawing.Point(445, 80);
            this.MtbTlf.Mask = "000 000 000";
            this.MtbTlf.Name = "MtbTlf";
            this.MtbTlf.Size = new System.Drawing.Size(313, 24);
            this.MtbTlf.TabIndex = 9;
            this.toolTipDetallesClientes.SetToolTip(this.MtbTlf, "Introduzca el teléfono del cliente(opcional)");
            this.MtbTlf.Validating += new System.ComponentModel.CancelEventHandler(this.MtbTlf_Validating);
            // 
            // MtbFechaNac
            // 
            this.MtbFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbFechaNac.Location = new System.Drawing.Point(66, 263);
            this.MtbFechaNac.Mask = "00-00-0000";
            this.MtbFechaNac.Name = "MtbFechaNac";
            this.MtbFechaNac.Size = new System.Drawing.Size(313, 24);
            this.MtbFechaNac.TabIndex = 4;
            this.toolTipDetallesClientes.SetToolTip(this.MtbFechaNac, "Introduzca la fecha de nacimiento del cliente");
            this.MtbFechaNac.Validating += new System.ComponentModel.CancelEventHandler(this.MtbFechaNac_Validating);
            // 
            // CmbEntrenador
            // 
            this.CmbEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEntrenador.FormattingEnabled = true;
            this.CmbEntrenador.Location = new System.Drawing.Point(445, 385);
            this.CmbEntrenador.Name = "CmbEntrenador";
            this.CmbEntrenador.Size = new System.Drawing.Size(313, 26);
            this.CmbEntrenador.TabIndex = 14;
            this.toolTipDetallesClientes.SetToolTip(this.CmbEntrenador, "Introduzca el entrenador del cliente");
            this.CmbEntrenador.Validating += new System.ComponentModel.CancelEventHandler(this.CmbEntrenador_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(445, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrenador:";
            // 
            // errorProviderDetallesClientes
            // 
            this.errorProviderDetallesClientes.ContainerControl = this;
            // 
            // TxtPatologias
            // 
            this.TxtPatologias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPatologias.Location = new System.Drawing.Point(445, 263);
            this.TxtPatologias.Name = "TxtPatologias";
            this.TxtPatologias.Size = new System.Drawing.Size(313, 24);
            this.TxtPatologias.TabIndex = 12;
            this.toolTipDetallesClientes.SetToolTip(this.TxtPatologias, "Introduzca el nombre del cliente");
            this.TxtPatologias.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPatologias_Validating);
            // 
            // LblPatologías
            // 
            this.LblPatologías.AutoSize = true;
            this.LblPatologías.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatologías.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPatologías.Location = new System.Drawing.Point(445, 242);
            this.LblPatologías.Name = "LblPatologías";
            this.LblPatologías.Size = new System.Drawing.Size(93, 18);
            this.LblPatologías.TabIndex = 16;
            this.LblPatologías.Text = "Patologías:";
            this.toolTipDetallesClientes.SetToolTip(this.LblPatologías, "Introduzca el nombre del cliente");
            // 
            // TxtAltura
            // 
            this.TxtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAltura.Location = new System.Drawing.Point(445, 202);
            this.TxtAltura.Name = "TxtAltura";
            this.TxtAltura.Size = new System.Drawing.Size(313, 24);
            this.TxtAltura.TabIndex = 11;
            this.toolTipDetallesClientes.SetToolTip(this.TxtAltura, "Introduzca el nombre del cliente");
            this.TxtAltura.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAltura_Validating);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPeso.Location = new System.Drawing.Point(445, 141);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(313, 24);
            this.TxtPeso.TabIndex = 10;
            this.toolTipDetallesClientes.SetToolTip(this.TxtPeso, "Introduzca el nombre del cliente");
            this.TxtPeso.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPeso_Validating);
            // 
            // PcbBorde
            // 
            this.PcbBorde.BackColor = System.Drawing.Color.White;
            this.PcbBorde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbBorde.Location = new System.Drawing.Point(0, 0);
            this.PcbBorde.Name = "PcbBorde";
            this.PcbBorde.Size = new System.Drawing.Size(891, 37);
            this.PcbBorde.TabIndex = 34;
            this.PcbBorde.TabStop = false;
            this.PcbBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseDown);
            this.PcbBorde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseMove);
            this.PcbBorde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 577);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(0, 584);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(891, 1);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(791, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 50;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(824, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1, 585);
            this.pictureBox5.TabIndex = 108;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1, 577);
            this.pictureBox6.TabIndex = 109;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(445, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Notificar usuario:";
            // 
            // ChbNotificar
            // 
            this.ChbNotificar.AutoSize = true;
            this.ChbNotificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbNotificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChbNotificar.Location = new System.Drawing.Point(740, 449);
            this.ChbNotificar.Name = "ChbNotificar";
            this.ChbNotificar.Size = new System.Drawing.Size(18, 17);
            this.ChbNotificar.TabIndex = 15;
            this.ChbNotificar.UseVisualStyleBackColor = true;
            // 
            // FrmDetallesCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(825, 585);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.TxtAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChbNotificar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PcbBorde);
            this.Controls.Add(this.TxtPatologias);
            this.Controls.Add(this.LblPatologías);
            this.Controls.Add(this.CmbEntrenador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MtbFechaNac);
            this.Controls.Add(this.MtbTlf);
            this.Controls.Add(this.CmbFrecuencia);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.LblFrecuencia);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblTlf);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtCorreoElectronico);
            this.Controls.Add(this.LblCorreoElectronico);
            this.Controls.Add(this.BtnUserAleatorio);
            this.Controls.Add(this.BtnContraAleatoria);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnAnadir);
            this.Controls.Add(this.BtnModificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetallesCliente";
            this.Text = "FrmDetallesCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetallesCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmDetallesCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetallesClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCorreoElectronico;
        private System.Windows.Forms.Label LblCorreoElectronico;
        private System.Windows.Forms.Button BtnUserAleatorio;
        private System.Windows.Forms.Button BtnContraAleatoria;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnAnadir;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label LblFrecuencia;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblTlf;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.ComboBox CmbFrecuencia;
        private System.Windows.Forms.MaskedTextBox MtbTlf;
        private System.Windows.Forms.MaskedTextBox MtbFechaNac;
        private System.Windows.Forms.ComboBox CmbEntrenador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderDetallesClientes;
        private System.Windows.Forms.ToolTip toolTipDetallesClientes;
        private System.Windows.Forms.TextBox TxtPatologias;
        private System.Windows.Forms.Label LblPatologías;
        private System.Windows.Forms.PictureBox PcbBorde;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChbNotificar;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtAltura;
    }
}