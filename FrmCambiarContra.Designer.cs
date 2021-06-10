
namespace MyGymRoutineAdministrar
{
    partial class FrmCambiarContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambiarContra));
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.TxtConfirmarContra = new System.Windows.Forms.TextBox();
            this.LblConfirmarContra = new System.Windows.Forms.Label();
            this.BtnCambiarContrasena = new System.Windows.Forms.Button();
            this.toolTipContra = new System.Windows.Forms.ToolTip(this.components);
            this.TxtNuevaContra = new System.Windows.Forms.TextBox();
            this.LblNuevaContra = new System.Windows.Forms.Label();
            this.errorProviderContra = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.PcbBorde = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContrasena.Location = new System.Drawing.Point(66, 80);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(313, 24);
            this.TxtContrasena.TabIndex = 1;
            this.toolTipContra.SetToolTip(this.TxtContrasena, "Introduzca la contraseña antigua");
            this.TxtContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.TxtContrasena_Validating);
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblContrasena.Location = new System.Drawing.Point(66, 59);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(100, 18);
            this.LblContrasena.TabIndex = 0;
            this.LblContrasena.Text = "Contraseña:";
            this.toolTipContra.SetToolTip(this.LblContrasena, "Introduzca la nueva contraseña");
            // 
            // TxtConfirmarContra
            // 
            this.TxtConfirmarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmarContra.Location = new System.Drawing.Point(66, 202);
            this.TxtConfirmarContra.Name = "TxtConfirmarContra";
            this.TxtConfirmarContra.PasswordChar = '*';
            this.TxtConfirmarContra.Size = new System.Drawing.Size(313, 24);
            this.TxtConfirmarContra.TabIndex = 3;
            this.toolTipContra.SetToolTip(this.TxtConfirmarContra, "Vuelva a introducir la nueva contraseña");
            this.TxtConfirmarContra.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmarContra_Validating);
            // 
            // LblConfirmarContra
            // 
            this.LblConfirmarContra.AutoSize = true;
            this.LblConfirmarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmarContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblConfirmarContra.Location = new System.Drawing.Point(66, 181);
            this.LblConfirmarContra.Name = "LblConfirmarContra";
            this.LblConfirmarContra.Size = new System.Drawing.Size(177, 18);
            this.LblConfirmarContra.TabIndex = 0;
            this.LblConfirmarContra.Text = "Confirmar contraseña:";
            this.toolTipContra.SetToolTip(this.LblConfirmarContra, "Vuelva a introducir la nueva contraseña");
            // 
            // BtnCambiarContrasena
            // 
            this.BtnCambiarContrasena.BackColor = System.Drawing.Color.White;
            this.BtnCambiarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCambiarContrasena.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnCambiarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnCambiarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnCambiarContrasena.Location = new System.Drawing.Point(122, 252);
            this.BtnCambiarContrasena.Name = "BtnCambiarContrasena";
            this.BtnCambiarContrasena.Size = new System.Drawing.Size(196, 40);
            this.BtnCambiarContrasena.TabIndex = 4;
            this.BtnCambiarContrasena.Text = "Guardar contraseña";
            this.toolTipContra.SetToolTip(this.BtnCambiarContrasena, "Pulse para cambiar la contraseña");
            this.BtnCambiarContrasena.UseVisualStyleBackColor = false;
            this.BtnCambiarContrasena.Click += new System.EventHandler(this.BtnCambiarContrasena_Click);
            // 
            // TxtNuevaContra
            // 
            this.TxtNuevaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNuevaContra.Location = new System.Drawing.Point(66, 141);
            this.TxtNuevaContra.Name = "TxtNuevaContra";
            this.TxtNuevaContra.PasswordChar = '*';
            this.TxtNuevaContra.Size = new System.Drawing.Size(313, 24);
            this.TxtNuevaContra.TabIndex = 2;
            this.toolTipContra.SetToolTip(this.TxtNuevaContra, "Introduzca la nueva contraseña");
            this.TxtNuevaContra.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNuevaContra_Validating);
            // 
            // LblNuevaContra
            // 
            this.LblNuevaContra.AutoSize = true;
            this.LblNuevaContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNuevaContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNuevaContra.Location = new System.Drawing.Point(66, 120);
            this.LblNuevaContra.Name = "LblNuevaContra";
            this.LblNuevaContra.Size = new System.Drawing.Size(149, 18);
            this.LblNuevaContra.TabIndex = 0;
            this.LblNuevaContra.Text = "Nueva contraseña:";
            this.toolTipContra.SetToolTip(this.LblNuevaContra, "Introduzca la nueva contraseña");
            // 
            // errorProviderContra
            // 
            this.errorProviderContra.ContainerControl = this;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnCancelar.Location = new System.Drawing.Point(122, 314);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(196, 40);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // PcbBorde
            // 
            this.PcbBorde.BackColor = System.Drawing.Color.White;
            this.PcbBorde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbBorde.Location = new System.Drawing.Point(0, 0);
            this.PcbBorde.Name = "PcbBorde";
            this.PcbBorde.Size = new System.Drawing.Size(465, 37);
            this.PcbBorde.TabIndex = 7;
            this.PcbBorde.TabStop = false;
            this.PcbBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseDown);
            this.PcbBorde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseMove);
            this.PcbBorde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-12, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(465, 1);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 410);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(446, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 410);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
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
            this.BtnCerrar.Location = new System.Drawing.Point(412, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 50;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmCambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(447, 388);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PcbBorde);
            this.Controls.Add(this.TxtNuevaContra);
            this.Controls.Add(this.LblNuevaContra);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCambiarContrasena);
            this.Controls.Add(this.TxtConfirmarContra);
            this.Controls.Add(this.LblConfirmarContra);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.LblContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarContra";
            this.Text = "MyGymRoutine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCambiarContra_FormClosing);
            this.Load += new System.EventHandler(this.FrmCambiarContra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox TxtConfirmarContra;
        private System.Windows.Forms.Label LblConfirmarContra;
        private System.Windows.Forms.Button BtnCambiarContrasena;
        private System.Windows.Forms.ToolTip toolTipContra;
        private System.Windows.Forms.ErrorProvider errorProviderContra;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtNuevaContra;
        private System.Windows.Forms.Label LblNuevaContra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PcbBorde;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnCerrar;
    }
}