namespace MyGymRoutineAdministrar
{
    partial class FrmLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.toolTipLogin = new System.Windows.Forms.ToolTip(this.components);
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.errorProviderLogIn = new System.Windows.Forms.ErrorProvider(this.components);
            this.PcbBorde = new System.Windows.Forms.PictureBox();
            this.PcbFondo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnMiminizar = new System.Windows.Forms.Button();
            this.LnkCorreo = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(90, 367);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(349, 28);
            this.TxtUsuario.TabIndex = 1;
            this.toolTipLogin.SetToolTip(this.TxtUsuario, "Introduzca su usuario");
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(90, 440);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(349, 28);
            this.TxtContrasena.TabIndex = 2;
            this.toolTipLogin.SetToolTip(this.TxtContrasena, "Introduzca su contraseña");
            this.TxtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContrasena_KeyPress);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.LblUsuario.Location = new System.Drawing.Point(90, 344);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(80, 20);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario:";
            this.toolTipLogin.SetToolTip(this.LblUsuario, "Introduzca su usuario");
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.BackColor = System.Drawing.Color.Transparent;
            this.LblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.LblContrasena.Location = new System.Drawing.Point(90, 417);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(111, 20);
            this.LblContrasena.TabIndex = 0;
            this.LblContrasena.Text = "Contraseña:";
            this.toolTipLogin.SetToolTip(this.LblContrasena, "Introduzca su contraseña");
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(193, 490);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(142, 39);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Iniciar sesión";
            this.toolTipLogin.SetToolTip(this.BtnLogin, "Pulse para iniciar sesión depues de haber introducido su usuario y contraseña");
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // errorProviderLogIn
            // 
            this.errorProviderLogIn.ContainerControl = this;
            // 
            // PcbBorde
            // 
            this.PcbBorde.BackColor = System.Drawing.Color.White;
            this.PcbBorde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbBorde.Location = new System.Drawing.Point(0, 0);
            this.PcbBorde.Margin = new System.Windows.Forms.Padding(0);
            this.PcbBorde.Name = "PcbBorde";
            this.PcbBorde.Size = new System.Drawing.Size(530, 37);
            this.PcbBorde.TabIndex = 30;
            this.PcbBorde.TabStop = false;
            this.PcbBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseDown);
            this.PcbBorde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseMove);
            this.PcbBorde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseUp);
            // 
            // PcbFondo
            // 
            this.PcbFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.PcbFondo.Image = ((System.Drawing.Image)(resources.GetObject("PcbFondo.Image")));
            this.PcbFondo.Location = new System.Drawing.Point(25, 40);
            this.PcbFondo.Name = "PcbFondo";
            this.PcbFondo.Size = new System.Drawing.Size(478, 327);
            this.PcbFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbFondo.TabIndex = 7;
            this.PcbFondo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 1);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(528, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 660);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 660);
            this.pictureBox3.TabIndex = 33;
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
            this.BtnCerrar.Location = new System.Drawing.Point(489, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(35, 30);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            this.BtnMiminizar.Location = new System.Drawing.Point(445, 4);
            this.BtnMiminizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMiminizar.Name = "BtnMiminizar";
            this.BtnMiminizar.Size = new System.Drawing.Size(35, 30);
            this.BtnMiminizar.TabIndex = 0;
            this.BtnMiminizar.UseVisualStyleBackColor = false;
            this.BtnMiminizar.Click += new System.EventHandler(this.BtnMiminizar_Click);
            // 
            // LnkCorreo
            // 
            this.LnkCorreo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.LnkCorreo.AutoSize = true;
            this.LnkCorreo.DisabledLinkColor = System.Drawing.Color.Red;
            this.LnkCorreo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(250)))), ((int)(((byte)(178)))));
            this.LnkCorreo.Location = new System.Drawing.Point(388, 560);
            this.LnkCorreo.Name = "LnkCorreo";
            this.LnkCorreo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LnkCorreo.Size = new System.Drawing.Size(126, 17);
            this.LnkCorreo.TabIndex = 4;
            this.LnkCorreo.TabStop = true;
            this.LnkCorreo.Text = "Recuperar usuario";
            this.LnkCorreo.Click += new System.EventHandler(this.LnkCorreo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(529, 601);
            this.Controls.Add(this.LnkCorreo);
            this.Controls.Add(this.BtnMiminizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PcbBorde);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PcbFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogIn";
            this.Text = "MyGymRoutine";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipLogin;
        private System.Windows.Forms.ErrorProvider errorProviderLogIn;
        private System.Windows.Forms.PictureBox PcbBorde;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.PictureBox PcbFondo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnMiminizar;
        private System.Windows.Forms.LinkLabel LnkCorreo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

