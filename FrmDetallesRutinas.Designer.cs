
namespace MyGymRoutineAdministrar
{
    partial class FrmDetallesRutinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetallesRutinas));
            this.GrbFiltroEjerc = new System.Windows.Forms.GroupBox();
            this.CmbFiltroEjerc = new System.Windows.Forms.ComboBox();
            this.TxtFiltroEjerc = new System.Windows.Forms.TextBox();
            this.BtnMostrarEjerc = new System.Windows.Forms.Button();
            this.LblTipoFiltro = new System.Windows.Forms.Label();
            this.BtnFiltrarEjerc = new System.Windows.Forms.Button();
            this.LblContenidoEjerc = new System.Windows.Forms.Label();
            this.LsbEjercicios = new System.Windows.Forms.ListBox();
            this.TxtNombreRutina = new System.Windows.Forms.TextBox();
            this.LblNombreRutina = new System.Windows.Forms.Label();
            this.LblNumDiasRutina = new System.Windows.Forms.Label();
            this.CmbDiasRutina = new System.Windows.Forms.ComboBox();
            this.LsbEjerciciosRutina = new System.Windows.Forms.ListBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.LblRutinaDia = new System.Windows.Forms.Label();
            this.CmbDiaEjercicios = new System.Windows.Forms.ComboBox();
            this.BtnMeterEjerc = new System.Windows.Forms.Button();
            this.BtnQuitarEjerc = new System.Windows.Forms.Button();
            this.errorProviderDetallesRutina = new System.Windows.Forms.ErrorProvider(this.components);
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblTipoRutina = new System.Windows.Forms.Label();
            this.PcbBorde = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.CmbTipoRutina = new System.Windows.Forms.ComboBox();
            this.BtnAnadir = new System.Windows.Forms.Button();
            this.GrbFiltroEjerc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetallesRutina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbFiltroEjerc
            // 
            this.GrbFiltroEjerc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GrbFiltroEjerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.GrbFiltroEjerc.Controls.Add(this.CmbFiltroEjerc);
            this.GrbFiltroEjerc.Controls.Add(this.TxtFiltroEjerc);
            this.GrbFiltroEjerc.Controls.Add(this.BtnMostrarEjerc);
            this.GrbFiltroEjerc.Controls.Add(this.LblTipoFiltro);
            this.GrbFiltroEjerc.Controls.Add(this.BtnFiltrarEjerc);
            this.GrbFiltroEjerc.Controls.Add(this.LblContenidoEjerc);
            this.GrbFiltroEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbFiltroEjerc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrbFiltroEjerc.Location = new System.Drawing.Point(518, 39);
            this.GrbFiltroEjerc.Name = "GrbFiltroEjerc";
            this.GrbFiltroEjerc.Size = new System.Drawing.Size(413, 164);
            this.GrbFiltroEjerc.TabIndex = 17;
            this.GrbFiltroEjerc.TabStop = false;
            this.GrbFiltroEjerc.Text = "Filtro";
            // 
            // CmbFiltroEjerc
            // 
            this.CmbFiltroEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFiltroEjerc.FormattingEnabled = true;
            this.CmbFiltroEjerc.Items.AddRange(new object[] {
            "Nombre",
            "Grupos musculares",
            "Músculo"});
            this.CmbFiltroEjerc.Location = new System.Drawing.Point(152, 33);
            this.CmbFiltroEjerc.Name = "CmbFiltroEjerc";
            this.CmbFiltroEjerc.Size = new System.Drawing.Size(231, 26);
            this.CmbFiltroEjerc.TabIndex = 10;
            // 
            // TxtFiltroEjerc
            // 
            this.TxtFiltroEjerc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFiltroEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFiltroEjerc.Location = new System.Drawing.Point(152, 74);
            this.TxtFiltroEjerc.Name = "TxtFiltroEjerc";
            this.TxtFiltroEjerc.Size = new System.Drawing.Size(231, 24);
            this.TxtFiltroEjerc.TabIndex = 11;
            // 
            // BtnMostrarEjerc
            // 
            this.BtnMostrarEjerc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnMostrarEjerc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMostrarEjerc.FlatAppearance.BorderSize = 0;
            this.BtnMostrarEjerc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnMostrarEjerc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnMostrarEjerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarEjerc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnMostrarEjerc.Location = new System.Drawing.Point(224, 115);
            this.BtnMostrarEjerc.Margin = new System.Windows.Forms.Padding(10);
            this.BtnMostrarEjerc.Name = "BtnMostrarEjerc";
            this.BtnMostrarEjerc.Size = new System.Drawing.Size(121, 32);
            this.BtnMostrarEjerc.TabIndex = 13;
            this.BtnMostrarEjerc.Text = "Quitar filtro";
            this.BtnMostrarEjerc.UseVisualStyleBackColor = false;
            this.BtnMostrarEjerc.Click += new System.EventHandler(this.BtnMostrarEjerc_Click);
            // 
            // LblTipoFiltro
            // 
            this.LblTipoFiltro.AutoSize = true;
            this.LblTipoFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblTipoFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoFiltro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTipoFiltro.Location = new System.Drawing.Point(31, 36);
            this.LblTipoFiltro.Name = "LblTipoFiltro";
            this.LblTipoFiltro.Size = new System.Drawing.Size(108, 18);
            this.LblTipoFiltro.TabIndex = 0;
            this.LblTipoFiltro.Text = "Tipo de filtro:";
            // 
            // BtnFiltrarEjerc
            // 
            this.BtnFiltrarEjerc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnFiltrarEjerc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFiltrarEjerc.FlatAppearance.BorderSize = 0;
            this.BtnFiltrarEjerc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnFiltrarEjerc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnFiltrarEjerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrarEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiltrarEjerc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.BtnFiltrarEjerc.Location = new System.Drawing.Point(63, 115);
            this.BtnFiltrarEjerc.Margin = new System.Windows.Forms.Padding(10);
            this.BtnFiltrarEjerc.Name = "BtnFiltrarEjerc";
            this.BtnFiltrarEjerc.Size = new System.Drawing.Size(121, 32);
            this.BtnFiltrarEjerc.TabIndex = 12;
            this.BtnFiltrarEjerc.Text = "Filtrar";
            this.BtnFiltrarEjerc.UseVisualStyleBackColor = false;
            this.BtnFiltrarEjerc.Click += new System.EventHandler(this.BtnFiltrarEjerc_Click);
            // 
            // LblContenidoEjerc
            // 
            this.LblContenidoEjerc.AutoSize = true;
            this.LblContenidoEjerc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblContenidoEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContenidoEjerc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblContenidoEjerc.Location = new System.Drawing.Point(31, 77);
            this.LblContenidoEjerc.Name = "LblContenidoEjerc";
            this.LblContenidoEjerc.Size = new System.Drawing.Size(90, 18);
            this.LblContenidoEjerc.TabIndex = 0;
            this.LblContenidoEjerc.Text = "Contenido:";
            // 
            // LsbEjercicios
            // 
            this.LsbEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbEjercicios.FormattingEnabled = true;
            this.LsbEjercicios.ItemHeight = 18;
            this.LsbEjercicios.Location = new System.Drawing.Point(518, 209);
            this.LsbEjercicios.Name = "LsbEjercicios";
            this.LsbEjercicios.Size = new System.Drawing.Size(413, 400);
            this.LsbEjercicios.TabIndex = 7;
            this.LsbEjercicios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LsbEjercicios_MouseDown);
            // 
            // TxtNombreRutina
            // 
            this.TxtNombreRutina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreRutina.Location = new System.Drawing.Point(232, 56);
            this.TxtNombreRutina.Name = "TxtNombreRutina";
            this.TxtNombreRutina.Size = new System.Drawing.Size(238, 24);
            this.TxtNombreRutina.TabIndex = 1;
            this.TxtNombreRutina.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombreRutina_Validating);
            // 
            // LblNombreRutina
            // 
            this.LblNombreRutina.AutoSize = true;
            this.LblNombreRutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblNombreRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombreRutina.Location = new System.Drawing.Point(54, 59);
            this.LblNombreRutina.Name = "LblNombreRutina";
            this.LblNombreRutina.Size = new System.Drawing.Size(161, 18);
            this.LblNombreRutina.TabIndex = 0;
            this.LblNombreRutina.Text = "Nombre de la rutina:";
            // 
            // LblNumDiasRutina
            // 
            this.LblNumDiasRutina.AutoSize = true;
            this.LblNumDiasRutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblNumDiasRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumDiasRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNumDiasRutina.Location = new System.Drawing.Point(54, 103);
            this.LblNumDiasRutina.Name = "LblNumDiasRutina";
            this.LblNumDiasRutina.Size = new System.Drawing.Size(132, 18);
            this.LblNumDiasRutina.TabIndex = 0;
            this.LblNumDiasRutina.Text = "Número de días:";
            // 
            // CmbDiasRutina
            // 
            this.CmbDiasRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDiasRutina.FormattingEnabled = true;
            this.CmbDiasRutina.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CmbDiasRutina.Location = new System.Drawing.Point(428, 100);
            this.CmbDiasRutina.MaxLength = 1;
            this.CmbDiasRutina.Name = "CmbDiasRutina";
            this.CmbDiasRutina.Size = new System.Drawing.Size(41, 26);
            this.CmbDiasRutina.TabIndex = 2;
            this.CmbDiasRutina.Text = "1";
            this.CmbDiasRutina.SelectedIndexChanged += new System.EventHandler(this.CmbDiasRutina_SelectedIndexChanged);
            this.CmbDiasRutina.Validating += new System.ComponentModel.CancelEventHandler(this.CmbDiasRutina_Validating);
            // 
            // LsbEjerciciosRutina
            // 
            this.LsbEjerciciosRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsbEjerciciosRutina.FormattingEnabled = true;
            this.LsbEjerciciosRutina.ItemHeight = 18;
            this.LsbEjerciciosRutina.Location = new System.Drawing.Point(58, 335);
            this.LsbEjerciciosRutina.Name = "LsbEjerciciosRutina";
            this.LsbEjerciciosRutina.Size = new System.Drawing.Size(413, 274);
            this.LsbEjerciciosRutina.TabIndex = 6;
            this.LsbEjerciciosRutina.DragDrop += new System.Windows.Forms.DragEventHandler(this.LsbEjerciciosRutina_DragDrop);
            this.LsbEjerciciosRutina.DragOver += new System.Windows.Forms.DragEventHandler(this.LsbEjerciciosRutina_DragOver);
            this.LsbEjerciciosRutina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LsbEjerciciosRutina_MouseDown);
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
            this.BtnCancelar.Location = new System.Drawing.Point(813, 675);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(133, 40);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BtnModificar.Location = new System.Drawing.Point(657, 675);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(133, 40);
            this.BtnModificar.TabIndex = 23;
            this.BtnModificar.Text = "Guardar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // LblRutinaDia
            // 
            this.LblRutinaDia.AutoSize = true;
            this.LblRutinaDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblRutinaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRutinaDia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblRutinaDia.Location = new System.Drawing.Point(54, 314);
            this.LblRutinaDia.Name = "LblRutinaDia";
            this.LblRutinaDia.Size = new System.Drawing.Size(126, 18);
            this.LblRutinaDia.TabIndex = 0;
            this.LblRutinaDia.Text = "Día de la rutina:";
            // 
            // CmbDiaEjercicios
            // 
            this.CmbDiaEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDiaEjercicios.FormattingEnabled = true;
            this.CmbDiaEjercicios.Items.AddRange(new object[] {
            "1"});
            this.CmbDiaEjercicios.Location = new System.Drawing.Point(429, 303);
            this.CmbDiaEjercicios.MaxLength = 1;
            this.CmbDiaEjercicios.Name = "CmbDiaEjercicios";
            this.CmbDiaEjercicios.Size = new System.Drawing.Size(42, 26);
            this.CmbDiaEjercicios.TabIndex = 5;
            this.CmbDiaEjercicios.Text = "1";
            this.CmbDiaEjercicios.SelectedIndexChanged += new System.EventHandler(this.CmbDiaEjercicios_SelectedIndexChanged);
            this.CmbDiaEjercicios.Validating += new System.ComponentModel.CancelEventHandler(this.CmbDiaEjercicios_Validating);
            // 
            // BtnMeterEjerc
            // 
            this.BtnMeterEjerc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnMeterEjerc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMeterEjerc.BackgroundImage")));
            this.BtnMeterEjerc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMeterEjerc.FlatAppearance.BorderSize = 2;
            this.BtnMeterEjerc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnMeterEjerc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnMeterEjerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMeterEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMeterEjerc.ForeColor = System.Drawing.Color.Black;
            this.BtnMeterEjerc.Location = new System.Drawing.Point(679, 617);
            this.BtnMeterEjerc.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMeterEjerc.Name = "BtnMeterEjerc";
            this.BtnMeterEjerc.Size = new System.Drawing.Size(89, 40);
            this.BtnMeterEjerc.TabIndex = 9;
            this.BtnMeterEjerc.UseVisualStyleBackColor = false;
            this.BtnMeterEjerc.Click += new System.EventHandler(this.BtnMeterEjerc_Click);
            // 
            // BtnQuitarEjerc
            // 
            this.BtnQuitarEjerc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnQuitarEjerc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnQuitarEjerc.BackgroundImage")));
            this.BtnQuitarEjerc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnQuitarEjerc.FlatAppearance.BorderSize = 2;
            this.BtnQuitarEjerc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(105)))), ((int)(((byte)(252)))));
            this.BtnQuitarEjerc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(130)))), ((int)(((byte)(253)))));
            this.BtnQuitarEjerc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitarEjerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitarEjerc.ForeColor = System.Drawing.Color.Black;
            this.BtnQuitarEjerc.Location = new System.Drawing.Point(216, 617);
            this.BtnQuitarEjerc.Margin = new System.Windows.Forms.Padding(0);
            this.BtnQuitarEjerc.Name = "BtnQuitarEjerc";
            this.BtnQuitarEjerc.Size = new System.Drawing.Size(89, 40);
            this.BtnQuitarEjerc.TabIndex = 8;
            this.BtnQuitarEjerc.UseVisualStyleBackColor = false;
            this.BtnQuitarEjerc.Click += new System.EventHandler(this.BtnQuitarEjerc_Click);
            // 
            // errorProviderDetallesRutina
            // 
            this.errorProviderDetallesRutina.ContainerControl = this;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblDescripcion.Location = new System.Drawing.Point(55, 188);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(103, 18);
            this.LblDescripcion.TabIndex = 0;
            this.LblDescripcion.Text = "Descripción:";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(58, 209);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescripcion.Size = new System.Drawing.Size(413, 80);
            this.TxtDescripcion.TabIndex = 4;
            this.TxtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescripcion_Validating);
            // 
            // LblTipoRutina
            // 
            this.LblTipoRutina.AutoSize = true;
            this.LblTipoRutina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.LblTipoRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoRutina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTipoRutina.Location = new System.Drawing.Point(54, 147);
            this.LblTipoRutina.Name = "LblTipoRutina";
            this.LblTipoRutina.Size = new System.Drawing.Size(93, 18);
            this.LblTipoRutina.TabIndex = 0;
            this.LblTipoRutina.Text = "Tipo rutina:";
            // 
            // PcbBorde
            // 
            this.PcbBorde.BackColor = System.Drawing.Color.White;
            this.PcbBorde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PcbBorde.Location = new System.Drawing.Point(0, 0);
            this.PcbBorde.Name = "PcbBorde";
            this.PcbBorde.Size = new System.Drawing.Size(990, 37);
            this.PcbBorde.TabIndex = 33;
            this.PcbBorde.TabStop = false;
            this.PcbBorde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseDown);
            this.PcbBorde.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseMove);
            this.PcbBorde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PcbBorde_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 746);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(990, 1);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(988, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 747);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 747);
            this.pictureBox3.TabIndex = 37;
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
            this.BtnCerrar.Location = new System.Drawing.Point(956, 3);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 50;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // CmbTipoRutina
            // 
            this.CmbTipoRutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTipoRutina.FormattingEnabled = true;
            this.CmbTipoRutina.Items.AddRange(new object[] {
            "Personalizada",
            "Básica",
            "Perder peso",
            "Ganar masa",
            "Definir"});
            this.CmbTipoRutina.Location = new System.Drawing.Point(234, 144);
            this.CmbTipoRutina.MaxLength = 20;
            this.CmbTipoRutina.Name = "CmbTipoRutina";
            this.CmbTipoRutina.Size = new System.Drawing.Size(237, 26);
            this.CmbTipoRutina.TabIndex = 3;
            this.CmbTipoRutina.Validating += new System.ComponentModel.CancelEventHandler(this.CmbTipoRutina_Validating);
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
            this.BtnAnadir.Location = new System.Drawing.Point(657, 675);
            this.BtnAnadir.Name = "BtnAnadir";
            this.BtnAnadir.Size = new System.Drawing.Size(133, 40);
            this.BtnAnadir.TabIndex = 14;
            this.BtnAnadir.Text = "Añadir";
            this.BtnAnadir.UseVisualStyleBackColor = false;
            this.BtnAnadir.Click += new System.EventHandler(this.BtnAnadir_Click);
            // 
            // FrmDetallesRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(990, 747);
            this.Controls.Add(this.CmbTipoRutina);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PcbBorde);
            this.Controls.Add(this.LblTipoRutina);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.BtnMeterEjerc);
            this.Controls.Add(this.BtnQuitarEjerc);
            this.Controls.Add(this.LblRutinaDia);
            this.Controls.Add(this.CmbDiaEjercicios);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAnadir);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.LsbEjerciciosRutina);
            this.Controls.Add(this.CmbDiasRutina);
            this.Controls.Add(this.LblNumDiasRutina);
            this.Controls.Add(this.TxtNombreRutina);
            this.Controls.Add(this.LsbEjercicios);
            this.Controls.Add(this.LblNombreRutina);
            this.Controls.Add(this.GrbFiltroEjerc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetallesRutinas";
            this.Text = "FrmDetallesRutinas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDetallesRutinas_FormClosing);
            this.Load += new System.EventHandler(this.FrmDetallesRutinas_Load);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.FrmDetallesRutinas_DragOver);
            this.GrbFiltroEjerc.ResumeLayout(false);
            this.GrbFiltroEjerc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetallesRutina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrbFiltroEjerc;
        private System.Windows.Forms.ComboBox CmbFiltroEjerc;
        private System.Windows.Forms.TextBox TxtFiltroEjerc;
        private System.Windows.Forms.Button BtnMostrarEjerc;
        private System.Windows.Forms.Label LblTipoFiltro;
        private System.Windows.Forms.Button BtnFiltrarEjerc;
        private System.Windows.Forms.Label LblContenidoEjerc;
        private System.Windows.Forms.ListBox LsbEjercicios;
        private System.Windows.Forms.TextBox TxtNombreRutina;
        private System.Windows.Forms.Label LblNombreRutina;
        private System.Windows.Forms.Label LblNumDiasRutina;
        private System.Windows.Forms.ComboBox CmbDiasRutina;
        private System.Windows.Forms.ListBox LsbEjerciciosRutina;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Label LblRutinaDia;
        private System.Windows.Forms.ComboBox CmbDiaEjercicios;
        private System.Windows.Forms.Button BtnMeterEjerc;
        private System.Windows.Forms.Button BtnQuitarEjerc;
        private System.Windows.Forms.ErrorProvider errorProviderDetallesRutina;
        private System.Windows.Forms.Label LblTipoRutina;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.PictureBox PcbBorde;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ComboBox CmbTipoRutina;
        private System.Windows.Forms.Button BtnAnadir;
    }
}