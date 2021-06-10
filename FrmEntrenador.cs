﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyGymRoutineAdministrar
{

    public partial class FrmEntrenador : Form
    {
        Entrenador entrenador;
        Cliente cliente = new Cliente(0, "", "", "", 0, 0,"", "");
        MySqlConnection ctn;
        Ejercicio ejercicio = new Ejercicio(0, "", "", 0, "", "", "", "", null);
        Rutina rutina;
        int ultimoDia = 0;
        ArrayList rutinas = new ArrayList();
        ArrayList rutinasTodas = new ArrayList();
        ArrayList rutinasCliente = new ArrayList();
        int x, y;
        bool mover;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Altura de barra de título;

        public FrmEntrenador(Entrenador entrenador)
        {
            InitializeComponent();

            this.entrenador = entrenador;
        }

        private void FrmEntrenador_Load(object sender, EventArgs e)
        {
            BtnVentanaMax.Enabled = true;
            BtnVentanaMax.Visible = true;
            BtnVentanaMin.Enabled = false;
            BtnVentanaMin.Visible = false;
            
            LsbRutinasCliente.AllowDrop = true;

            //Ponemos el nombre, apellidos e imagen si la tuviera del usuario en el formulario
            LblNombre.Text = entrenador.Nombre + " " + entrenador.Apellidos;
            if (entrenador.Imagen != null)
            {
                MemoryStream ms = new MemoryStream(entrenador.Imagen);
                Bitmap bm = new Bitmap(ms);
                PcbImagen.Image = bm;
            }

            ctn = new MySqlConnection("Server=servergym.ddns.net; Port=9091; Database=db_gimnasio; Uid=usuarioGym; Password=usuario_Gym_2021;");
            try
            {
                ctn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }

            mostrarEjercicios();
        }

        private void BtnEjercicios_Click(object sender, EventArgs e)
        {
            mostrarEjercicios();
        }

        private void BtnRutinas_Click(object sender, EventArgs e)
        {
            mostrarRutinas();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {;
            this.Close();
        }

        //Método que abre el formulario frmPerfil que permite editar los datos del usuario que ha iniciado sesión.
        //Al cerrarse el formulario frmPerfil se actualiza nombre, apellidos e imagen del usuario.
        private void LblNombre_Click(object sender, EventArgs e)
        {
            //Abrimos el formulario frmPerfil y le pasamos el usuario que podrán editar sus datos
            FrmPerfil frm = new FrmPerfil(entrenador);
            frm.ShowDialog();
            //Actualizamos nombre, apellidos e imagen del usuario
            try
            {
                String sql = "SELECT nombre, apellidos, imagen FROM personal where idPersonal = " + entrenador.IdPersonal;
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    LblNombre.Text = lector[0].ToString() + " " + lector[1].ToString();
                    try
                    {
                        MemoryStream ms = new MemoryStream((byte[])lector[2]);
                        Bitmap bm = new Bitmap(ms);
                        PcbImagen.Image = bm;
                    }
                    catch { }
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }
        //Método que permite seleccionar una imagen para el ejercicio y la introduce en el pictureBox
        private void PcbImgEjerc_Click(object sender, EventArgs e)
        {
            openFileDialogEntrenador.Title = "Seleccione la imagen del ejercicio";
            openFileDialogEntrenador.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";

            if (openFileDialogEntrenador.ShowDialog() == DialogResult.OK)
                if (File.Exists(openFileDialogEntrenador.FileName))
                {
                    PcbImgEjerc.Image = Image.FromFile(openFileDialogEntrenador.FileName);
                }
        }

        private void LblNombre_MouseHover(object sender, EventArgs e)
        {
            LblNombre.ForeColor = Color.FromArgb(175, 105, 252);
        }

        private void LblNombre_MouseLeave(object sender, EventArgs e)
        {
            LblNombre.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnVentanaMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnVentanaMax.Enabled = true;
            BtnVentanaMax.Visible = true;
            BtnVentanaMin.Enabled = false;
            BtnVentanaMin.Visible = false;
        }

        private void BtnMiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnVentanaMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnVentanaMin.Enabled = true;
            BtnVentanaMin.Visible = true;
            BtnVentanaMax.Enabled = false;
            BtnVentanaMax.Visible = false;

        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmEntrenador_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            x = e.X;
            y = e.Y;
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmEntrenador_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmEntrenador_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void FrmEntrenador_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctn.Close();
        }

        //Método para cambiar de tamaño del formulario desde la esquina inferior derecha
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        //Método que cambia los elementos del formulario para poder gestionar los ejercicios y los muestra
        private void mostrarEjercicios()
        {
            refrescarEjercicios();

            LsvEjercicios.Visible = true;
            LsvEjercicios.Enabled = true;
            GrbEjercicio.Visible = true;
            GrbEjercicio.Enabled = true;
            GrbFiltroEjerc.Visible = true;
            GrbFiltroEjerc.Enabled = true;

            GrbFiltroRutinas.Visible = false;
            GrbFiltroRutinas.Enabled = false;
            LsbRutinas.Visible = false;
            LsbRutinas.Enabled = false;
            BtnAnadirRutina.Visible = false;
            BtnAnadirRutina.Enabled = false;
            BtnModificarRutina.Visible = false;
            BtnModificarRutina.Enabled = false;
            BtnEliminarRutina.Visible = false;
            BtnEliminarRutina.Enabled = false;
            LblRutinaDia.Visible = false;
            LblRutinaDia.Enabled = false;
            CmbDiaRutina.Visible = false;
            CmbDiaRutina.Enabled = false;
            LsvRutinasEjerc.Visible = false;
            LsvRutinasEjerc.Enabled = false;

            LblClientes.Visible = false;
            LblClientes.Enabled = false;
            LblRutinasClientes.Visible = false;
            LblRutinasClientes.Enabled = false;
            LblRutinasTodas.Visible = false;
            LblRutinasTodas.Enabled = false;
            LsvClientes.Visible = false;
            LsvClientes.Enabled = false;
            LsbRutinaTodas.Visible = false;
            LsbRutinaTodas.Enabled = false;
            LsbRutinasCliente.Visible = false;
            LsbRutinasCliente.Enabled = false;
            BtnMeterRutina.Visible = false;
            BtnMeterRutina.Enabled = false;
            BtnQuitarRutina.Visible = false;
            BtnQuitarRutina.Enabled = false;
            BtnModificarCliente.Visible = false;
            BtnModificarCliente.Enabled = false;
        }

        //Método que cambia los elementos del formulario para poder gestionar las rutinas y los muestra
        private void mostrarRutinas()
        {
            RefrescarRutinas();

            LsvEjercicios.Visible = false;
            LsvEjercicios.Enabled = false;
            GrbEjercicio.Visible = false;
            GrbEjercicio.Enabled = false;
            GrbFiltroEjerc.Visible = false;
            GrbFiltroEjerc.Enabled = false;

            GrbFiltroRutinas.Visible = true;
            GrbFiltroRutinas.Enabled = true;
            LsbRutinas.Visible = true;
            LsbRutinas.Enabled = true;
            BtnAnadirRutina.Visible = true;
            BtnAnadirRutina.Enabled = true;
            BtnModificarRutina.Visible = true;
            BtnModificarRutina.Enabled = true;
            BtnEliminarRutina.Visible = true;
            BtnEliminarRutina.Enabled = true;
            LblRutinaDia.Visible = true;
            LblRutinaDia.Enabled = true;
            CmbDiaRutina.Visible = true;
            CmbDiaRutina.Enabled = true;
            LsvRutinasEjerc.Visible = true;
            LsvRutinasEjerc.Enabled = true;

            LblClientes.Visible = false;
            LblClientes.Enabled = false;
            LblRutinasClientes.Visible = false;
            LblRutinasClientes.Enabled = false;
            LblRutinasTodas.Visible = false;
            LblRutinasTodas.Enabled = false;
            LsvClientes.Visible = false;
            LsvClientes.Enabled = false;
            LsbRutinaTodas.Visible = false;
            LsbRutinaTodas.Enabled = false;
            LsbRutinasCliente.Visible = false;
            LsbRutinasCliente.Enabled = false;
            BtnMeterRutina.Visible = false;
            BtnMeterRutina.Enabled = false;
            BtnQuitarRutina.Visible = false;
            BtnQuitarRutina.Enabled = false;
            BtnModificarCliente.Visible = false;
            BtnModificarCliente.Enabled = false;
        }

        //Método que cambia los elementos del formulario para poder gestionar a los clientes y los muestra
        private void mostrarClientes()
        {
            refrescarClientes();
            refrescarRutinasTodas();
            LsbRutinasCliente.Items.Clear();
            cliente = new Cliente(0, "", "", "", 0, 0, "", "");

            LsvEjercicios.Visible = false;
            LsvEjercicios.Enabled = false;
            GrbEjercicio.Visible = false;
            GrbEjercicio.Enabled = false;
            GrbFiltroEjerc.Visible = false;
            GrbFiltroEjerc.Enabled = false;

            GrbFiltroRutinas.Visible = false;
            GrbFiltroRutinas.Enabled = false;
            LsbRutinas.Visible = false;
            LsbRutinas.Enabled = false;
            BtnAnadirRutina.Visible = false;
            BtnAnadirRutina.Enabled = false;
            BtnModificarRutina.Visible = false;
            BtnModificarRutina.Enabled = false;
            BtnEliminarRutina.Visible = false;
            BtnEliminarRutina.Enabled = false;
            LblRutinaDia.Visible = false;
            LblRutinaDia.Enabled = false;
            CmbDiaRutina.Visible = false;
            CmbDiaRutina.Enabled = false;
            LsvRutinasEjerc.Visible = false;
            LsvRutinasEjerc.Enabled = false;

            LblClientes.Visible = true;
            LblClientes.Enabled = true;
            LblRutinasClientes.Visible = true;
            LblRutinasClientes.Enabled = true;
            LblRutinasTodas.Visible = true;
            LblRutinasTodas.Enabled = true;
            LsvClientes.Visible = true;
            LsvClientes.Enabled = true;
            LsbRutinaTodas.Visible = true;
            LsbRutinaTodas.Enabled = true;
            LsbRutinasCliente.Visible = true;
            LsbRutinasCliente.Enabled = true;
            BtnMeterRutina.Visible = true;
            BtnMeterRutina.Enabled = true;
            BtnQuitarRutina.Visible = true;
            BtnQuitarRutina.Enabled = true;
            BtnModificarCliente.Visible = true;
            BtnModificarCliente.Enabled = true;
        }

        //Método que refresca todos los ejercicios en el listBox y los guarda en objetos
        private void refrescarEjercicios()
        {
            try
            {
                limpiarEjercicio();
                LsvEjercicios.Items.Clear();
                String sql = "SELECT * FROM ejercicio";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    ListViewItem lvi = LsvEjercicios.Items.Add(lector[1].ToString());
                    lvi.SubItems.Add(lector[2].ToString());
                    lvi.SubItems.Add(lector[3].ToString());
                    lvi.SubItems.Add(lector[4].ToString());
                    lvi.SubItems.Add(lector[5].ToString());

                    Byte[] imagen = null;
                    try
                    {
                        imagen = (byte[])lector[8];
                        MemoryStream ms = new MemoryStream(imagen);
                    }
                    catch { }

                    Ejercicio a = new Ejercicio(Int32.Parse(lector[0].ToString()), lector[1].ToString(), 
                        lector[2].ToString(), Int32.Parse(lector[3].ToString()), lector[4].ToString(), 
                        lector[5].ToString(), lector[6].ToString(), lector[7].ToString(), imagen);
                    lvi.Tag = a;
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que refresca todos las rutinas en el listBox y las guarda en objetos
        private void RefrescarRutinas()
        {
            try
            {
                LsbRutinas.Items.Clear();
                rutinas.Clear();
                LsvRutinasEjerc.Items.Clear();
                CmbDiaRutina.Items.Clear();
                ChbRutinasPers.Checked = false;
                ChbRutinasPred.Checked = false;
                String sql = "SELECT * FROM rutina WHERE idPersonal = " + entrenador.IdPersonal + " OR tipoRutina != 'Personalizada'";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    LsbRutinas.Items.Add(lector[1].ToString());
                    rutinas.Add(new Rutina(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),
                        Int32.Parse(lector[5].ToString())));
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que refresca todos los clientes en el listBox para gestionar sus rutinas y los guarda en objetos
        private void refrescarClientes()
        {
            try
            {
                limpiarEjercicio();
                LsvClientes.Items.Clear();
                String sql = "SELECT IdCliente, nombre, apellidos, fechaNacimiento, peso, altura, frecuenciaDeporte, patologias " +
                    "FROM cliente WHERE idPersonal = " + entrenador.IdPersonal;
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    double peso = 0, altura = 0;
                    string frecuencia = "", patologias = "";

                    ListViewItem lvi = LsvClientes.Items.Add(lector[1].ToString());
                    lvi.SubItems.Add(lector[2].ToString());
                    try
                    {
                        peso = lector.GetDouble(4);
                        lvi.SubItems.Add(peso.ToString());
                    }
                    catch 
                    { 
                        lvi.SubItems.Add(""); 
                    }
                    try
                    {
                        altura = lector.GetDouble(5);
                        lvi.SubItems.Add(altura.ToString());
                    }
                    catch 
                    {
                        lvi.SubItems.Add("");
                    }
                    try
                    {
                        frecuencia = lector.GetString(6);
                        lvi.SubItems.Add(frecuencia);
                    }
                    catch 
                    {
                        lvi.SubItems.Add("");
                    }
                    string[] fecha = lector[3].ToString().Split(' ');
                    lvi.SubItems.Add(fecha[0]);
                    try
                    {
                        patologias = lector.GetString(7);
                        lvi.SubItems.Add(patologias);
                    }
                    catch 
                    {
                        lvi.SubItems.Add("");
                    }
                    Cliente a = new Cliente(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), 
                        fecha[0], peso, altura, frecuencia, patologias);
                    lvi.Tag = a;
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que refresca todas las rutinas en el listBox para asignarlas a clientes y las guarda en objetos
        private void refrescarRutinasTodas()
        {
            try
            {
                LsbRutinaTodas.Items.Clear();
                rutinasTodas.Clear();
                String sql = "SELECT * FROM rutina WHERE idPersonal = " + entrenador.IdPersonal + " OR tipoRutina != 'personalizada'";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    LsbRutinaTodas.Items.Add(lector[1].ToString());
                    rutinasTodas.Add(new Rutina(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),
                        Int32.Parse(lector[5].ToString())));
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método para añadir ejercicios
        private void BtnAnadirEjerc_Click(object sender, EventArgs e)
        {
            try
            {
                //Validamos la entrada de datos de todos los campos
                if (validarEjercicioCreado() && validarNombreEjercCrear() && validarGrupoMuscularEjerc() && validarMusculoEjerc() 
                    && validarRepesEjerc() && validarSeriesEjerc() && validarDescansoEjerc() && validarDescEjerc())
                {
                    //Convertimos la imagen en un array de bytes
                    MemoryStream ms = new MemoryStream();
                    PcbImgEjerc.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] imagen = ms.ToArray();

                    //Añadimos el ejercicio
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO ejercicio " +
                        "(nombre, repeticiones, series, descanso, grupoMuscular, musculo, descripcion, imagen)" +
                    " VALUES ('" + TxtNombreEjerc.Text + "', '" + TxtRepesEjerc.Text + "', " + TxtSeriesEjerc.Text + 
                    ", '" + TxtDescanso.Text + "', '" + CmbGrupoMuscularEjerc.Text +
                    "', '" + TxtMusculo.Text + "', '" + TxtDescEjerc.Text + "', @imagen)");
                    cmd.Parameters.AddWithValue("imagen", imagen);
                    cmd.Connection = ctn;
                    MessageBox.Show("Se añadido correctamente " + cmd.ExecuteNonQuery().ToString() + " ejercicio");
                    refrescarEjercicios();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        private void BtnModificarEjerc_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que haya algun ejercicio seleccionado
                if (ejercicio.IdEjercicio > 0)
                {
                    //Validamos la entrada de datos de todos los campos
                    if (validarNombreEjerc() && validarGrupoMuscularEjerc() && validarMusculoEjerc() && validarRepesEjerc()
                    && validarSeriesEjerc() && validarDescansoEjerc() && validarDescEjerc())
                    {
                        //Validamos la entrada de datos de todos los campos
                        MemoryStream ms = new MemoryStream();
                        PcbImgEjerc.Image.Save(ms, ImageFormat.Jpeg);
                        byte[] imagen = ms.ToArray();

                        //Modificamos el ejercicio
                        MySqlCommand cmd = new MySqlCommand("UPDATE ejercicio SET nombre = '" + TxtNombreEjerc.Text +
                            "', repeticiones = '" + TxtRepesEjerc.Text + "', series = " + TxtSeriesEjerc.Text +
                            ", descanso = '" + TxtDescanso.Text + "', grupoMuscular = '" + CmbGrupoMuscularEjerc.Text +
                            "', musculo = '" + TxtMusculo.Text + "', descripcion = '" + TxtDescEjerc.Text + "', imagen = @imagen " +
                            "WHERE idEjercicio = " + ejercicio.IdEjercicio);
                        cmd.Parameters.AddWithValue("imagen", imagen);
                        cmd.Connection = ctn;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado correctamente el ejercicio");
                        refrescarEjercicios();
                    }
                }
                else
                    MessageBox.Show("Seleccione el ejercicio para modificarlo.", "Información");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método para eliminar ejercicios
        private void BtnEliminarEjerc_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que haya seleccionado solo 1
                if (LsvEjercicios.SelectedItems != null && LsvEjercicios.SelectedItems.Count > 0)
                {
                    ejercicio = (Ejercicio)LsvEjercicios.SelectedItems[0].Tag;

                    //Utilizamos una ventana de dialogo para confirmar la operación
                    if (MessageBox.Show("¿Seguro(a) que desea eliminar el ejercicio " + ejercicio.Nombre + "?", "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            //Comprobamos que el ejercicio no esté siendo utilizado en ninguina rutina
                            String sql = "SELECT idEjercicio FROM rutinaEjercicio WHERE idEjercicio = " + ejercicio.IdEjercicio;
                            MySqlCommand cmd2 = new MySqlCommand(sql);
                            cmd2.Connection = ctn;
                            MySqlDataReader lector = cmd2.ExecuteReader();
                            Boolean entro = false;
                            while (lector.Read())
                            {
                                entro = true;
                            }
                            lector.Close();

                            //Si esta siendo utilizado no se eliminana
                            if (entro)
                                MessageBox.Show("No se puede eliminar el ejrcicio " + ejercicio.Nombre + 
                                    " ya que está siendo utilizado en una rutina.", "Información");
                            else
                            {
                                //Eliminamos el ejercicio
                                MySqlCommand cmd = new MySqlCommand("DELETE FROM ejercicio WHERE idEjercicio = " + ejercicio.IdEjercicio);
                                cmd.Connection = ctn;
                                MessageBox.Show("Se ha eliminado correctamente " + cmd.ExecuteNonQuery().ToString() + " ejercicio");
                                refrescarEjercicios();
                            }
                        }
                        catch (MySql.Data.MySqlClient.MySqlException)
                        {
                            MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Para eliminar un ejercicio seleccionelo en el listado", "Información");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método para añadir rutinas, abre un nuevo formulario para realizar la acción
        private void BtnAnadirRutina_Click(object sender, EventArgs e)
        {
            FrmDetallesRutinas frm = new FrmDetallesRutinas(entrenador.IdPersonal);

            frm.ShowDialog();

            RefrescarRutinas();
        }

        //Método que para modificar rutinas, abre un nuevo formulario para realizar la acción
        private void BtnModificarRutina_Click(object sender, EventArgs e)
        {
            //Comprobamos que haya seleccionado solo 1
            if (LsbRutinas.SelectedItems != null && LsbRutinas.SelectedItems.Count > 0)
            {
                //Se abre el nuevo formulario y le pasamos el cliente a modificar
                FrmDetallesRutinas frm = new FrmDetallesRutinas((Rutina)rutinas[LsbRutinas.SelectedIndex], entrenador.IdPersonal);

                frm.ShowDialog();

                RefrescarRutinas();
            }
            else MessageBox.Show("Para modificar una rutina seleccionela en la tabla", "Información");
        }

        //Método para eliminar rutinas
        private void BtnEliminarRutina_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que haya seleccionado solo 1
                if (LsbRutinas.SelectedItems != null && LsbRutinas.SelectedItems.Count > 0)
                {
                    rutina = (Rutina)rutinas[LsbRutinas.SelectedIndex];

                    //Utilizamos una ventana de dialogo para confirmar la operación
                    if (MessageBox.Show("¿Seguro(a) que desea eliminar la rutina " + rutina.Nombre + "?", "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Eliminamos la rutina y sus relaciones con los ejercicios y los clientes
                        MySqlCommand cmd2 = new MySqlCommand("DELETE FROM rutinaCliente WHERE idRutina = " + rutina.IdRutina);
                        cmd2.Connection = ctn;
                        cmd2.ExecuteNonQuery();
                        MySqlCommand cmd3 = new MySqlCommand("DELETE FROM rutinaEjercicio WHERE idRutina = " + rutina.IdRutina);
                        cmd3.Connection = ctn;
                        cmd3.ExecuteNonQuery();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM rutina WHERE idRutina = " + rutina.IdRutina);
                        cmd.Connection = ctn;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se ha eliminado correctamente la rutina");
                        RefrescarRutinas();
                    }
                }
                else
                {
                    MessageBox.Show("Para eliminar un ejercicio seleccionelo en el listado", "Información");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que modifica las rutinas que tiene un cliente asignadas
        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que haya algún cliente seleccionado
                if (cliente == null)
                    MessageBox.Show("Seleccione un cliente antes de modificar las rutinas.", "Información");
                else
                {
                    //Eliminamos las anteriores rutinas
                    MySqlCommand cmd2 = new MySqlCommand("DELETE FROM rutinaCliente WHERE idCliente = " + cliente.IdCliente);
                    cmd2.Connection = ctn;
                    cmd2.ExecuteNonQuery();

                    //Añadimos las nuevas rutinas
                    foreach (Rutina r in rutinasCliente)
                    {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO rutinaCliente (idRutina, idCliente)" +
                        " VALUES (" + r.IdRutina + ", " + cliente.IdCliente + ")");
                        cmd.Connection = ctn;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Se han modificado correctamente la rutinas de " + cliente.Nombre + ".", "Información");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Se ha intentado añadir una rutina repetida al cliente.", "Error");
            }
        }

        //Método que limpia todos los campos de ejercicio
        private void limpiarEjercicio()
        {
            TxtNombreEjerc.Text = "";
            CmbGrupoMuscularEjerc.Text = "";
            TxtMusculo.Text = "";
            TxtRepesEjerc.Text = "";
            TxtSeriesEjerc.Text = "";
            TxtDescanso.Text = "";
            TxtDescEjerc.Text = "";
            PcbImgEjerc.Image = PcbImagenPesa.Image;
            ejercicio.IdEjercicio = 0;
        }

        //Método que carga las rutinas del cliente seleccionado en el listbox
        private void LsvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comprobamos que haya seleccionado solo 1
            if (LsvClientes.SelectedItems != null && LsvClientes.SelectedItems.Count > 0)
            {
                cliente = (Cliente)LsvClientes.SelectedItems[0].Tag;

                try
                {
                    //Limpiamos las anteriores rutinas
                    LsbRutinasCliente.Items.Clear();
                    rutinasCliente.Clear();
                    String sql = "SELECT rutina.idRutina, rutina.nombre, rutina.descripcion, rutina.tipoRutina, rutina.idPersonal " +
                    "FROM rutina " +
                    "INNER JOIN rutinaCliente ON rutina.idRutina = rutinaCliente.idRutina " +
                    "WHERE rutinaCliente.idCliente = " + cliente.IdCliente;
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    //Cargamos las rutinas del cliente
                    while (lector.Read())
                    {
                        LsbRutinasCliente.Items.Add(lector[1].ToString());
                        rutinasCliente.Add(new Rutina(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),
                            Int32.Parse(lector[4].ToString())));
                    }
                    lector.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                }
            }
        }

        //Método que quita la rutina seleccionada en el listbox
        private void BtnQuitarRutina_Click(object sender, EventArgs e)
        {
            if (LsbRutinasCliente.SelectedItems != null && LsbRutinasCliente.SelectedItems.Count > 0)
            {
                rutinasCliente.RemoveAt(LsbRutinasCliente.SelectedIndex);
                LsbRutinasCliente.Items.RemoveAt(LsbRutinasCliente.SelectedIndex);
            }
            else MessageBox.Show("Seleccione una rutina en el listado para eliminarla", "Información");
        }

        //Método que mete la rutina seleccionada en el listbox
        private void BtnMeterRutina_Click(object sender, EventArgs e)
        {
            if (LsbRutinaTodas.SelectedItems != null && LsbRutinaTodas.SelectedItems.Count > 0)
            {
                if (cliente.IdCliente < 1)
                {
                    MessageBox.Show("Seleccione antes un cliente al que asignarle rutinas.", "Información");
                }
                else
                {
                    Rutina rutinaAux = (Rutina)rutinasTodas[LsbRutinaTodas.SelectedIndex];

                    //Comprobamos que la rutina no esté ya añadida
                    bool coincide = false;
                    for (int i = 0; i < LsbRutinasCliente.Items.Count; i++)
                    {
                        if (LsbRutinasCliente.Items[i].ToString().Equals(rutinaAux.Nombre))
                        {
                            coincide = true;
                            break;
                        }
                    }

                    //Si no esta dentro se añade
                    if (coincide == false)
                    {
                        rutinasCliente.Add(rutinaAux);
                        LsbRutinasCliente.Items.Add(rutinaAux.Nombre);
                    }
                }
            }
            else MessageBox.Show("Seleccione una rutina en el listado para añadirla", "Información");
        }

        //Método para hacer Drag de la rutina en el listBox
        private void LsbRutinaTodas_MouseDown(object sender, MouseEventArgs e)
        {
            //Comprobamos que haya una rutina seleccionada
            if (LsbRutinaTodas.SelectedItems != null && LsbRutinaTodas.SelectedItems.Count > 0)
            {
                //Comprobamos que haya un cliente seleccionado y hacemos el Drag
                if (cliente.IdCliente < 1)
                {
                    MessageBox.Show("Seleccione antes un cliente al que asignarle rutinas.", "Información");
                }
                else if (e.Button == MouseButtons.Left)
                {
                    DragDropEffects res = this.LsbRutinaTodas.DoDragDrop(this.LsbRutinaTodas.SelectedItem, DragDropEffects.Move);
                }
            }
        }

        //Método que no permite hacer Drop en el resto del formulario
        private void FrmEntrenador_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        //Método que quita la rutina seleccionada en el listbox con un Drop
        private void LsbRutinasCliente_DragDrop(object sender, DragEventArgs e)
        {
            Rutina rutinaAux = (Rutina)rutinasTodas[LsbRutinaTodas.SelectedIndex];

            //Comprobamos que la rutina no está ya dentro
            bool coincide = false;
            for (int i = 0; i < LsbRutinasCliente.Items.Count; i++)
            {
                if (LsbRutinasCliente.Items[i].ToString().Equals(rutinaAux.Nombre))
                {
                    coincide = true;
                    break;
                }
            }

            //Si no lo esta la añadimos
            if (coincide == false)
            {
                rutinasCliente.Add(rutinaAux);
                LsbRutinasCliente.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
            }
        }

        //Método que permite hacer Drop en el listbox
        private void LsbRutinasCliente_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        //Método que carga los datos del ejercicio seleccionado en los campos
        private void LsvEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderEntrenador.Clear();
            if (LsvEjercicios.SelectedItems != null && LsvEjercicios.SelectedItems.Count > 0)
            {
                ejercicio = (Ejercicio)LsvEjercicios.SelectedItems[0].Tag;
                TxtNombreEjerc.Text = ejercicio.Nombre;
                CmbGrupoMuscularEjerc.Text = ejercicio.GrupoMuscular;
                TxtMusculo.Text = ejercicio.Musculo;
                TxtRepesEjerc.Text = ejercicio.Repeticiones;
                TxtSeriesEjerc.Text = ejercicio.Series.ToString();
                TxtDescanso.Text = ejercicio.Descanso;
                TxtDescEjerc.Text = ejercicio.Descripcion;
                if (ejercicio.Imagen != null)
                {
                    MemoryStream ms = new MemoryStream(ejercicio.Imagen);
                    Bitmap bm = new Bitmap(ms);
                    PcbImgEjerc.Image = bm;
                }
                else
                    PcbImgEjerc.Image = PcbImagenPesa.Image;
            }
        }

        //Método que permiter modifificar una rutina en un nuevo formulario haciendo doble clieck sobre ella
        private void LsbRutinas_DoubleClick(object sender, EventArgs e)
        {
            //Comprobamos que la rutina pertenezca al entrenador que las está gestionando en ese momento
            if (rutina.IdEntrenador == entrenador.IdPersonal)
                if (LsbRutinas.SelectedItems != null && LsbRutinas.SelectedItems.Count > 0)
                {
                    FrmDetallesRutinas frm = new FrmDetallesRutinas((Rutina)rutinas[LsbRutinas.SelectedIndex], entrenador.IdPersonal);

                    frm.ShowDialog();

                    RefrescarRutinas();
                }
                else MessageBox.Show("Para modificar una rutina seleccionela en la tabla", "Información");
        }

        //Método que al seleccionar una rutina en el listBox carga su número de días en el comboBox
        private void LsbRutinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsbRutinas.SelectedItems != null && LsbRutinas.SelectedItems.Count > 0)
            {
                rutina = (Rutina)rutinas[LsbRutinas.SelectedIndex];

                if (rutina.IdEntrenador == entrenador.IdPersonal)
                {
                    BtnModificarRutina.Enabled = true;
                    BtnEliminarRutina.Enabled = true;
                }  
                else
                {
                    BtnModificarRutina.Enabled = false;
                    BtnEliminarRutina.Enabled = false;
                }

                try
                {
                    CmbDiaRutina.Items.Clear();
                    String sql = "SELECT DISTINCT dia " +
                        "FROM rutinaEjercicio " +
                        "WHERE idRutina = " + rutina.IdRutina;
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        CmbDiaRutina.Items.Add(lector[0].ToString());
                        ultimoDia = lector.GetInt32(0);
                    }
                    lector.Close();

                    CmbDiaRutina.Text = CmbDiaRutina.Items[0].ToString();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                }
                catch { }
            }
        }

        //Método que al seleccionar una rutina en el listBox carga los ejercicios de ese día de la rutina selecciona en el listBox
        private void CmbDiaRutina_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Comprueba el valor del día seleccionado
            if (Regex.IsMatch(CmbDiaRutina.Text,
                            "^([1-" + ultimoDia + "])?"))
            {
                try
                {
                    LsvRutinasEjerc.Items.Clear();
                    String sql = "SELECT ejercicio.nombre, ejercicio.repeticiones, ejercicio.series, ejercicio.descanso, ejercicio.musculo " +
                        "FROM rutinaEjercicio " +
                        "INNER JOIN ejercicio ON rutinaEjercicio.idEjercicio = ejercicio.idEjercicio " +
                        "WHERE rutinaEjercicio.dia = " + CmbDiaRutina.Text + " AND rutinaEjercicio.idRutina = " + rutina.IdRutina;
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        ListViewItem lvi = LsvRutinasEjerc.Items.Add(lector[0].ToString());
                        lvi.SubItems.Add(lector[1].ToString());
                        lvi.SubItems.Add(lector[2].ToString());
                        lvi.SubItems.Add(lector[3].ToString());
                        lvi.SubItems.Add(lector[4].ToString());
                    }
                    lector.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                }
            }
            else
                MessageBox.Show("El día seleccionado no es correcto");
        }

        //Método que comprueba la entrada de datos del filtro para evitar la inyección de datos de sql
        //y devuelvo true or false en función si es correcto o no
        private bool comprobarFiltroTxt(TextBox txt)
        {
            if (Regex.IsMatch(txt.Text, "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])"))
            {
                MessageBox.Show("El filtro tiene algún carácter no válido", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Método que comprueba la entrada de datos del filtro para evitar la inyección de datos de sql
        //y devuelvo true or false en función si es correcto o no
        private bool comprobarFiltroCmb(ComboBox cmb)
        {
            if (Regex.IsMatch(cmb.Text, "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])"))
            {
                MessageBox.Show("El filtro tiene algún carácter no válido", "Error");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Método que filtra los ejercicios y los muestra
        private void BtnFiltrarEjerc_Click(object sender, EventArgs e)
        {
            //Comprobamos los filtros
            if (comprobarFiltroTxt(TxtFiltroEjerc) && comprobarFiltroCmb(CmbFiltroEjerc))
            {
                //Asignamos una petición según el filtro seleccionado
                String sql = "";
                switch (CmbFiltroEjerc.Text)
                {
                    case "Nombre":
                        sql = "SELECT * FROM ejercicio WHERE nombre LIKE '%" + TxtFiltroEjerc.Text + "%'";
                        break;
                    case "Grupos musculares":
                        sql = "SELECT * FROM ejercicio WHERE grupoMuscular LIKE '%" + TxtFiltroEjerc.Text + "%'";
                        break;
                }
                try
                {
                    LsvEjercicios.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    //Mostramos los ejercicios filtrados
                    while (lector.Read())
                    {
                        ListViewItem lvi = LsvEjercicios.Items.Add(lector[1].ToString());
                        lvi.SubItems.Add(lector[2].ToString());
                        lvi.SubItems.Add(lector[3].ToString());
                        lvi.SubItems.Add(lector[4].ToString());
                        lvi.SubItems.Add(lector[5].ToString());

                        Byte[] imagen = null;
                        try
                        {
                            imagen = (byte[])lector[8];
                            MemoryStream ms = new MemoryStream(imagen);
                        }
                        catch { }

                        Ejercicio a = new Ejercicio(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), Int32.Parse(lector[3].ToString()),
                            lector[4].ToString(), lector[5].ToString(), lector[6].ToString(), lector[7].ToString(), imagen);
                        lvi.Tag = a;
                    }
                    lector.Close();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Filtro incorrecto", "Error");
                    refrescarEjercicios();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                }
            }
        }

        private void BtnMostrarEjerc_Click(object sender, EventArgs e)
        {
            refrescarEjercicios();
        }

        private void ChbRutinasPred_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbRutinasPred.Checked == true)
            {
                ChbRutinasPers.Checked = false;
                ChbRutinasPred.Checked = true;
            }
        }

        private void ChbRutinasPers_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbRutinasPers.Checked == true)
            {
                ChbRutinasPers.Checked = true;
                ChbRutinasPred.Checked = false;
            }
        }

        private void BtnMostrarRutina_Click(object sender, EventArgs e)
        {
            RefrescarRutinas();
        }

        //Mostramos los ejercicios filtrados
        private void BtnFiltrarRutina_Click(object sender, EventArgs e)
        {
            //Comprobamos los filtros
            if (comprobarFiltroTxt(TxtFiltroRutina))
            {
                //Asignamos una petición según el filtro seleccionado
                String sql = "";
                if (ChbRutinasPers.Checked == true)
                    sql = "SELECT * FROM rutina " +
                    "WHERE nombre LIKE '%" + TxtFiltroRutina.Text + "%' AND idPersonal = " + entrenador.IdPersonal + " AND tipoRutina = 'personalizada'";
                else if (ChbRutinasPred.Checked == true)
                    sql = "SELECT * FROM rutina " +
                    "WHERE nombre LIKE '%" + TxtFiltroRutina.Text + "%' AND tipoRutina != 'personalizada' AND (idPersonal = " + entrenador.IdPersonal + " OR idPersonal = 1)";
                else
                    sql = "SELECT * FROM rutina " +
                    "WHERE nombre LIKE '%" + TxtFiltroRutina.Text + "%' AND (idPersonal = " + entrenador.IdPersonal + " OR idPersonal = 1)";

                try
                {
                    limpiarEjercicio();
                    LsbRutinas.Items.Clear();
                    rutinas.Clear();
                    LsvRutinasEjerc.Items.Clear();
                    CmbDiaRutina.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    //Mostramos las rutinas filtradas
                    while (lector.Read())
                    {
                        LsbRutinas.Items.Add(lector[1].ToString());
                        rutinas.Add(new Rutina(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),
                            Int32.Parse(lector[5].ToString())));
                    }
                    lector.Close();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Filtro incorrecto", "Error");
                    RefrescarRutinas();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                }
            }
        }

        //Método que valida el campo de nombre al ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarNombreEjercCrear()
        {
            if (TxtNombreEjerc.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(TxtNombreEjerc, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtNombreEjerc.Text.Equals(ejercicio.Nombre))
            {
                errorProviderEntrenador.SetError(TxtNombreEjerc, "");
                return true;
            }
            else if (Regex.IsMatch(TxtNombreEjerc.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtNombreEjerc.Text.Length > 45)
            {
                errorProviderEntrenador.SetError(TxtNombreEjerc,
                    "El nombre tiene algún caracter que no es válido\n" +
                    "45 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                try
                {
                    String sql = "SELECT nombre FROM ejercicio WHERE nombre = '" + TxtNombreEjerc.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    Boolean entro = false;
                    while (lector.Read())
                    {
                        entro = true;
                    }
                    lector.Close();
                    if (entro)
                    {
                        errorProviderEntrenador.SetError(TxtNombreEjerc, "El nombre ya esá en uso");
                        return false;
                    }
                    else
                    {
                        errorProviderEntrenador.SetError(TxtNombreEjerc, "");
                        return true;
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    return false;
                }
            }
        }

        //Método que valida el campo de nombre del ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarNombreEjerc()
        {
            if (TxtNombreEjerc.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(TxtNombreEjerc, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtNombreEjerc.Text.Equals(ejercicio.Nombre))
            {
                errorProviderEntrenador.SetError(TxtNombreEjerc, "");
                return true;
            }
            else if (Regex.IsMatch(TxtNombreEjerc.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtNombreEjerc.Text.Length > 45)
            {
                errorProviderEntrenador.SetError(TxtNombreEjerc,
                    "El nombre tiene algún caracter que no es válido\n" +
                    "45 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                try
                {
                    String sql = "SELECT nombre FROM ejercicio WHERE nombre = '" + TxtNombreEjerc.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    Boolean entro = false;
                    while (lector.Read())
                    {
                        entro = true;
                    }
                    lector.Close();
                    if (entro && !TxtNombreEjerc.Text.Equals(ejercicio.Nombre))
                    {
                        errorProviderEntrenador.SetError(TxtNombreEjerc, "El nombre ya esá en uso");
                        return false;
                    }
                    else
                    {
                        errorProviderEntrenador.SetError(TxtNombreEjerc, "");
                        return true;
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    return false;
                }
            }
        }

        //Método que valida el campo de repeticiones del ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarRepesEjerc()
        {
            if (TxtRepesEjerc.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(TxtRepesEjerc, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtRepesEjerc.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtRepesEjerc.Text.Length > 15)
            {
                errorProviderEntrenador.SetError(TxtRepesEjerc,
                    "El campo tiene algún caracter que no es válido\n" +
                    "15 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                errorProviderEntrenador.SetError(TxtRepesEjerc, "");
                return true;
            }
        }

        //Método que valida el campo de series del ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarSeriesEjerc()
        {
            if (TxtSeriesEjerc.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(TxtSeriesEjerc, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtSeriesEjerc.Text,
                            "^([0-9]{1,2})$"))
            {
                errorProviderEntrenador.SetError(TxtSeriesEjerc, "");
                return true;
            }
            else
            {
                errorProviderEntrenador.SetError(TxtSeriesEjerc,
                    "El número de series es muy elevado o tiene algún carácter no válido");
                
                return false;
            }
        }

        //Método que valida el campo de descripción del ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarDescEjerc()
        {
            if (TxtDescEjerc.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(TxtDescEjerc, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtDescEjerc.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])"))
            {
                errorProviderEntrenador.SetError(TxtDescEjerc,
                    "La descripción tiene algún caracter que no es válido\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                errorProviderEntrenador.SetError(TxtDescEjerc, "");
                return true;
            }
        }

        //Método que valida el campo del grupo musuclar del ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarGrupoMuscularEjerc()
        {
            if (CmbGrupoMuscularEjerc.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(CmbGrupoMuscularEjerc, "El campo no puede quedar vacio");
                return false;
            }
            else if (CmbGrupoMuscularEjerc.Text.Equals("Brazo") || CmbGrupoMuscularEjerc.Text.Equals("Pecho") ||
                CmbGrupoMuscularEjerc.Text.Equals("Pierna") || CmbGrupoMuscularEjerc.Text.Equals("Espalda") || 
                CmbGrupoMuscularEjerc.Text.Equals("Hombros") || CmbGrupoMuscularEjerc.Text.Equals("Abdominales") ||
                CmbGrupoMuscularEjerc.Text.Equals("Cardio"))
            {
                errorProviderEntrenador.SetError(CmbGrupoMuscularEjerc, "");
                return true;
            }
            else
            {
                errorProviderEntrenador.SetError(CmbGrupoMuscularEjerc, "El campo tiene un valor incorrecto");
                return false;
            }
        }

        //Método que valida el campo del músculo del ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarMusculoEjerc()
        {
            if (TxtMusculo.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(TxtMusculo, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtMusculo.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtMusculo.Text.Length > 45)
            {
                errorProviderEntrenador.SetError(TxtMusculo,
                    "El campo tiene algún caracter que no es válido\n" +
                    "15 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                errorProviderEntrenador.SetError(TxtMusculo, "");
                return true;
            }
        }

        //Método que valida el campo de descanso del ejercicio y devuelvo true or false en función si es correcto o no
        private bool validarDescansoEjerc()
        {
            if (TxtDescanso.Text.Equals(""))
            {
                errorProviderEntrenador.SetError(TxtDescanso, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtDescanso.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtDescanso.Text.Length > 15)
            {
                errorProviderEntrenador.SetError(TxtDescanso,
                    "El campo tiene algún caracter que no es válido\n" +
                    "15 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                errorProviderEntrenador.SetError(TxtDescanso, "");
                return true;
            }
        }

        //Método que comprueba si el ejercicio ya existe y devuelvo true or false en función si es correcto o no
        private bool validarEjercicioCreado()
        {
            try
            {
                String sql = "SELECT nombre FROM ejercicio WHERE nombre = '" + TxtNombreEjerc.Text + "'";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                Boolean entro = false;
                while (lector.Read())
                {
                    entro = true;
                }
                lector.Close();
                if (entro)
                {
                    MessageBox.Show("El ejercicio ya existe.", "Información");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                return false;
            }
        }

        private void TxtNombreEjerc_Validating(object sender, CancelEventArgs e)
        {
            validarNombreEjerc();
        }

        private void TxtDescEjerc_Validating(object sender, CancelEventArgs e)
        {
            validarDescEjerc();
        }

        private void CmbMusculosEjerc_Validating(object sender, CancelEventArgs e)
        {
            validarGrupoMuscularEjerc();
        }

        private void TxtRepesEjerc_Validating(object sender, CancelEventArgs e)
        {
            validarRepesEjerc();
        }

        private void TxtSeriesEjerc_Validating(object sender, CancelEventArgs e)
        {
            validarSeriesEjerc();
        }

        private void TxtMusculo_Validating(object sender, CancelEventArgs e)
        {
            validarMusculoEjerc();
        }

        private void TxtDescanso_Validating(object sender, CancelEventArgs e)
        {
            validarDescansoEjerc();
        }
    }
}
