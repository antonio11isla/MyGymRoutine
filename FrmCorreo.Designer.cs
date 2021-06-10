
namespace MyGymRoutineAdministrar
{
    partial class FrmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorreo));
            this.LblColumna = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PcbBorde = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.BtnRecuperarDatos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorProviderCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblColumna
            // 
            this.LblColumna.AutoSize = true;
            this.LblColumna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblColumna.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblColumna.Location = new System.Drawing.Point(31, 65);
            this.LblColumna.Name = "LblColumna";
            this.LblColumna.Size = new System.Drawing.Size(279, 18);
            this.LblColumna.TabIndex = 0;
            this.LblColumna.Text = "Introduce tu correo electrónico para";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(19, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "recuperar tus datos de inicio de sesión:";
            // 
            // PcbBorde
            // 
            this.PcbBorde.BackColor = System.Drawing.Color.White;
            this.PcbBorde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PcbBorde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbBorde.Location = new System.Drawing.Point(0, 0);
            this.PcbBorde.Name = "PcbBorde";
            this.PcbBorde.Size = new System.Drawing.Size(378, 37);
            this.PcbBorde.TabIndex = 36;
            this.PcbBorde.TabStop = false;
            this.PcbBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseDown);
            this.PcbBorde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseMove);
            this.PcbBorde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseUp);
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
            this.BtnCerrar.Location = new System.Drawing.Point(338, 4);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(51, 121);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(274, 28);
            this.TxtCorreo.TabIndex = 1;
            // 
            // BtnRecuperarDatos
            // 
            this.BtnRecuperarDatos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRecuperarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRecuperarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnRecuperarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnRecuperarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecuperarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecuperarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnRecuperarDatos.Location = new System.Drawing.Point(106, 166);
            this.BtnRecuperarDatos.Name = "BtnRecuperarDatos";
            this.BtnRecuperarDatos.Size = new System.Drawing.Size(169, 34);
            this.BtnRecuperarDatos.TabIndex = 2;
            this.BtnRecuperarDatos.Text = "Recuperar datos";
            this.BtnRecuperarDatos.UseVisualStyleBackColor = false;
            this.BtnRecuperarDatos.Click += new System.EventHandler(this.BtnRecuperarDatos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 1);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(372, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 232);
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 232);
            this.pictureBox3.TabIndex = 111;
            this.pictureBox3.TabStop = false;
            // 
            // errorProviderCorreo
            // 
            this.errorProviderCorreo.ContainerControl = this;
            // 
            // FrmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(373, 232);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRecuperarDatos);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.PcbBorde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblColumna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCorreo";
            this.Text = "FrmCorreo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCorreo_FormClosing);
            this.Load += new System.EventHandler(this.FrmCorreo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCorreo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblColumna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PcbBorde;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Button BtnRecuperarDatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProviderCorreo;
    }
}