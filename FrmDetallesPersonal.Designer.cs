
namespace MyGymRoutineAdministrar
{
    partial class FrmDetallesPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallesPersonal));
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAnadir = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnContraAleatoria = new System.Windows.Forms.Button();
            this.BtnUserAleatorio = new System.Windows.Forms.Button();
            this.errorProviderDetallesPersonal = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipDetallesPersonal = new System.Windows.Forms.ToolTip(this.components);
            this.TxtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.LblCorreoElectronico = new System.Windows.Forms.Label();
            this.PcbBorde = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.ChbNotificar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetallesPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.BtnModificar.Location = new System.Drawing.Point(246, 464);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(133, 40);
            this.BtnModificar.TabIndex = 9;
            this.BtnModificar.Text = "Modificar";
            this.toolTipDetallesPersonal.SetToolTip(this.BtnModificar, "Pulse para modificar al personal");
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
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
            this.BtnAnadir.Location = new System.Drawing.Point(246, 464);
            this.BtnAnadir.Name = "BtnAnadir";
            this.BtnAnadir.Size = new System.Drawing.Size(133, 40);
            this.BtnAnadir.TabIndex = 9;
            this.BtnAnadir.Text = "Añadir";
            this.toolTipDetallesPersonal.SetToolTip(this.BtnAnadir, "Pulse para añadir al personal");
            this.BtnAnadir.UseVisualStyleBackColor = false;
            this.BtnAnadir.Click += new System.EventHandler(this.BtnAnadir_Click);
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
            this.toolTipDetallesPersonal.SetToolTip(this.LblNombre, "Introduzca el nombre del personal");
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(66, 80);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(313, 24);
            this.TxtNombre.TabIndex = 1;
            this.toolTipDetallesPersonal.SetToolTip(this.TxtNombre, "Introduzca el nombre del personal");
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(66, 141);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(313, 24);
            this.TxtApellidos.TabIndex = 2;
            this.toolTipDetallesPersonal.SetToolTip(this.TxtApellidos, "Introduzca los apellidos del personal");
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
            this.toolTipDetallesPersonal.SetToolTip(this.LblApellidos, "Introduzca los apellidos del personal");
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(66, 354);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(313, 24);
            this.TxtContrasena.TabIndex = 6;
            this.toolTipDetallesPersonal.SetToolTip(this.TxtContrasena, "Introduzca la contraseña del personal");
            this.TxtContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.TxtContrasena_Validating);
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblContrasena.Location = new System.Drawing.Point(66, 333);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(100, 18);
            this.LblContrasena.TabIndex = 0;
            this.LblContrasena.Text = "Contraseña:";
            this.toolTipDetallesPersonal.SetToolTip(this.LblContrasena, "Introduzca la contraseña del personal");
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(66, 263);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(313, 24);
            this.TxtUsuario.TabIndex = 4;
            this.toolTipDetallesPersonal.SetToolTip(this.TxtUsuario, "Introduzca el usuario del personal");
            this.TxtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsuario_Validating);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUsuario.Location = new System.Drawing.Point(66, 242);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(72, 18);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario:";
            this.toolTipDetallesPersonal.SetToolTip(this.LblUsuario, "Introduzca el usuario del personal");
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
            this.BtnCancelar.Location = new System.Drawing.Point(64, 464);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(133, 40);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.toolTipDetallesPersonal.SetToolTip(this.BtnCancelar, "Pulse para cancelar la operación");
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnContraAleatoria
            // 
            this.BtnContraAleatoria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnContraAleatoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnContraAleatoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnContraAleatoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnContraAleatoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContraAleatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContraAleatoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnContraAleatoria.Location = new System.Drawing.Point(66, 384);
            this.BtnContraAleatoria.Name = "BtnContraAleatoria";
            this.BtnContraAleatoria.Size = new System.Drawing.Size(313, 24);
            this.BtnContraAleatoria.TabIndex = 7;
            this.BtnContraAleatoria.Text = "Generar contraseña aleatoria";
            this.toolTipDetallesPersonal.SetToolTip(this.BtnContraAleatoria, "Pulse para generar una contraseña aleatoria");
            this.BtnContraAleatoria.UseVisualStyleBackColor = false;
            this.BtnContraAleatoria.Click += new System.EventHandler(this.BtnContraAleatoria_Click);
            // 
            // BtnUserAleatorio
            // 
            this.BtnUserAleatorio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUserAleatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUserAleatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnUserAleatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnUserAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserAleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserAleatorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnUserAleatorio.Location = new System.Drawing.Point(66, 293);
            this.BtnUserAleatorio.Name = "BtnUserAleatorio";
            this.BtnUserAleatorio.Size = new System.Drawing.Size(313, 24);
            this.BtnUserAleatorio.TabIndex = 5;
            this.BtnUserAleatorio.Text = "Generar usuario aleatorio";
            this.toolTipDetallesPersonal.SetToolTip(this.BtnUserAleatorio, "Pulse para generar un usuario aleatorio");
            this.BtnUserAleatorio.UseVisualStyleBackColor = false;
            this.BtnUserAleatorio.Click += new System.EventHandler(this.BtnUserAleatorio_Click);
            // 
            // errorProviderDetallesPersonal
            // 
            this.errorProviderDetallesPersonal.ContainerControl = this;
            // 
            // TxtCorreoElectronico
            // 
            this.TxtCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreoElectronico.Location = new System.Drawing.Point(66, 202);
            this.TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            this.TxtCorreoElectronico.Size = new System.Drawing.Size(313, 24);
            this.TxtCorreoElectronico.TabIndex = 3;
            this.toolTipDetallesPersonal.SetToolTip(this.TxtCorreoElectronico, "Introduzca el correo electrónico del personal");
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
            this.toolTipDetallesPersonal.SetToolTip(this.LblCorreoElectronico, "Introduzca el correo electrónico del personal");
            // 
            // PcbBorde
            // 
            this.PcbBorde.BackColor = System.Drawing.Color.White;
            this.PcbBorde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PcbBorde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbBorde.Location = new System.Drawing.Point(0, 0);
            this.PcbBorde.Name = "PcbBorde";
            this.PcbBorde.Size = new System.Drawing.Size(447, 37);
            this.PcbBorde.TabIndex = 35;
            this.PcbBorde.TabStop = false;
            this.PcbBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseDown);
            this.PcbBorde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseMove);
            this.PcbBorde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 544);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 1);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(446, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 577);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(413, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 50;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // ChbNotificar
            // 
            this.ChbNotificar.AutoSize = true;
            this.ChbNotificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbNotificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChbNotificar.Location = new System.Drawing.Point(361, 426);
            this.ChbNotificar.Name = "ChbNotificar";
            this.ChbNotificar.Size = new System.Drawing.Size(18, 17);
            this.ChbNotificar.TabIndex = 8;
            this.ChbNotificar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(64, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notificar usuario:";
            // 
            // FrmDetallesPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(447, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChbNotificar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PcbBorde);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetallesPersonal";
            this.Text = "MyGymRoutine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetallesPersonal_FormClosing);
            this.Load += new System.EventHandler(this.FrmDetallesPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetallesPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAnadir;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnContraAleatoria;
        private System.Windows.Forms.Button BtnUserAleatorio;
        private System.Windows.Forms.ToolTip toolTipDetallesPersonal;
        private System.Windows.Forms.ErrorProvider errorProviderDetallesPersonal;
        private System.Windows.Forms.TextBox TxtCorreoElectronico;
        private System.Windows.Forms.Label LblCorreoElectronico;
        private System.Windows.Forms.PictureBox PcbBorde;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChbNotificar;
    }
}