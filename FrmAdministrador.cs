using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGymRoutineAdministrar
{
    public partial class FrmAdministrador : Form
    {
        MySqlConnection ctn;
        Administrador administrador;
        int x, y;
        bool mover;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Altura de barra de título;

        public FrmAdministrador(Administrador administrador)
        {
            InitializeComponent();
            this.administrador = administrador;
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            BtnVentanaMax.Enabled = true;
            BtnVentanaMax.Visible = true;
            BtnVentanaMin.Enabled = false;
            BtnVentanaMin.Visible = false;

            //Ponemos el nombre, apellidos e imagen si la tuviera del usuario en el formulario
            LblNombre.Text = administrador.Nombre + " " + administrador.Apellidos;
            if (administrador.Imagen != null)
            {
                MemoryStream ms = new MemoryStream(administrador.Imagen);
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

            mostrarEntrenadores();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        private void BtnEntrenadores_Click(object sender, EventArgs e)
        {
            mostrarEntrenadores();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que abre el formulario frmPerfil que permite editar los datos del usuario que ha iniciado sesión.
        //Al cerrarse el formulario frmPerfil se actualiza nombre, apellidos e imagen del usuario.
        private void LblNombre_Click(object sender, EventArgs e)
        {
            //Abrimos el formulario frmPerfil y le pasamos el usuario que podrán editar sus datos
            FrmPerfil frm = new FrmPerfil(administrador);
            frm.ShowDialog();
            //Actualizamos nombre, apellidos e imagen del usuario
            try
            {
                String sql = "SELECT nombre, apellidos, imagen FROM personal where idPersonal = " + administrador.IdPersonal;
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

        private void BtnVentanaMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnVentanaMin.Enabled = true;
            BtnVentanaMin.Visible = true;
            BtnVentanaMax.Enabled = false;
            BtnVentanaMax.Visible = false;

        }

        private void BtnMiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            x = e.X;
            y = e.Y;
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmAdministrador_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmAdministrador_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        private void FrmAdministrador_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnMostrarEntrenadores_Click(object sender, EventArgs e)
        {
            refrescarEntrenadores();
        }

        private void BtnMostrarClientes_Click(object sender, EventArgs e)
        {
            refrescarClientes();
        }

        //Método que cambia los elementos del formulario para poder gestionar a los entrenadores y los muestra
        private void mostrarEntrenadores()
        {
            refrescarEntrenadores();
            LsvEntrenadores.Visible = true;
            LsvEntrenadores.Enabled = true;
            LsvClientes.Visible = false;
            LsvClientes.Enabled = false;

            CmbFiltro.Visible = true;
            CmbFiltro.Enabled = true;
            BtnFiltrarEntrenadores.Visible = true;
            BtnFiltrarEntrenadores.Enabled = true;
            BtnMostrarEntrenadores.Visible = true;
            BtnMostrarEntrenadores.Enabled = true;
            BtnFiltrarClientes.Visible = false;
            BtnFiltrarClientes.Enabled = false;
            BtnMostrarClientes.Visible = false;
            BtnMostrarClientes.Enabled = false;
            CmbColumnaClientes.Visible = false;
            CmbColumnaClientes.Enabled = false;

            BtnAnadirEntenador.Visible = true;
            BtnAnadirEntenador.Enabled = true;
            BTnModificarEntrenador.Visible = true;
            BTnModificarEntrenador.Enabled = true;
            BtnEliminarEntrenador.Visible = true;
            BtnEliminarEntrenador.Enabled = true;
            BtnAnadirClientes.Visible = false;
            BtnAnadirClientes.Enabled = false;
            BtnModificarCliente.Visible = false;
            BtnModificarCliente.Enabled = false;
            BtnEliminarClientes.Visible = false;
            BtnEliminarClientes.Enabled = false;
        }

        //Método que cambia los elementos del formulario para poder gestionar a los clientes y los muestra
        private void mostrarClientes()
        {
            refrescarClientes();

            LsvEntrenadores.Visible = false;
            LsvEntrenadores.Enabled = false;
            LsvClientes.Visible = true;
            LsvClientes.Enabled = true;

            CmbFiltro.Visible = false;
            CmbFiltro.Enabled = false;
            BtnFiltrarEntrenadores.Visible = false;
            BtnFiltrarEntrenadores.Enabled = false;
            BtnMostrarEntrenadores.Visible = false;
            BtnMostrarEntrenadores.Enabled = false;
            BtnFiltrarClientes.Visible = true;
            BtnFiltrarClientes.Enabled = true;
            BtnMostrarClientes.Visible = true;
            BtnMostrarClientes.Enabled = true;
            CmbColumnaClientes.Visible = true;
            CmbColumnaClientes.Enabled = true;

            BtnAnadirEntenador.Visible = false;
            BtnAnadirEntenador.Enabled = false;
            BTnModificarEntrenador.Visible = false;
            BTnModificarEntrenador.Enabled = false;
            BtnEliminarEntrenador.Visible = false;
            BtnEliminarEntrenador.Enabled = false;
            BtnAnadirClientes.Visible = true;
            BtnAnadirClientes.Enabled = true;
            BtnModificarCliente.Visible = true;
            BtnModificarCliente.Enabled = true;
            BtnEliminarClientes.Visible = true;
            BtnEliminarClientes.Enabled = true;
        }

        //Método que refresca todos los entrenadores en el listView y los guarda en objetos
        private void refrescarEntrenadores()
        {
            try
            {
                LsvEntrenadores.Items.Clear();
                String sql = "SELECT * FROM personal";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    if (lector[7].ToString().Equals("Entrenador"))
                    {
                        ListViewItem lvi = LsvEntrenadores.Items.Add(lector[1].ToString());
                        lvi.SubItems.Add(lector[2].ToString());
                        lvi.SubItems.Add(lector[3].ToString());
                        lvi.SubItems.Add(lector[5].ToString());
                        try
                        {
                            Entrenador a = new Entrenador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), 
                                lector[3].ToString(), lector[4].ToString(), lector[5].ToString(), (byte[])lector[6]);
                            lvi.Tag = a;
                        }
                        catch
                        {
                            Entrenador a = new Entrenador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), 
                                lector[3].ToString(), lector[4].ToString(), lector[5].ToString());
                            lvi.Tag = a;
                        }
                    }
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que refresca todos los clientes en el listView y los guarda en objetos
        private void refrescarClientes()
        {
            try
            {
                LsvClientes.Items.Clear();
                String sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, c.fechaNacimiento, " +
                    "c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                    "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    double peso = 0, altura = 0;
                    string frecuencia = "", idPersonal = "0";

                    ListViewItem lvi = LsvClientes.Items.Add(lector[1].ToString());
                    lvi.SubItems.Add(lector[2].ToString());
                    lvi.SubItems.Add(lector[3].ToString());
                    lvi.SubItems.Add(lector[5].ToString());
                    string[] fecha = lector[6].ToString().Split(' ');
                    lvi.SubItems.Add(fecha[0]);
                    lvi.SubItems.Add(lector[13].ToString());

                    try
                    {
                        peso = lector.GetDouble(8);
                    }
                    catch { }
                    try
                    {
                        altura = lector.GetDouble(9);
                    }
                    catch { }
                    try
                    {
                        frecuencia = lector.GetString(10);
                    }
                    catch { }
                    try
                    {
                        idPersonal = lector.GetString(12);
                    }
                    catch 
                    {
                        idPersonal = "0";
                    }
                    Cliente a = new Cliente(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), 
                        lector[4].ToString(), lector[5].ToString(), lector[6].ToString(), lector[7].ToString(), peso, altura, frecuencia, 
                        lector[11].ToString(), Int32.Parse(idPersonal));
                    lvi.Tag = a;
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método para eliminar a entrenadores
        private void BtnEliminarEntrenador_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que haya seleccionado solo 1
                if (LsvEntrenadores.SelectedItems != null && LsvEntrenadores.SelectedItems.Count > 0)
                {
                    Entrenador a = (Entrenador)LsvEntrenadores.SelectedItems[0].Tag;

                    //Utilizamos una ventana de dialogo para confirmar la operación
                    if (MessageBox.Show("¿Seguro(a) que desea eliminar a " + a.Nombre + " " + a.Apellidos + "?", "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Eliminamos el entrenador
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM personal WHERE idPersonal = " + a.IdPersonal);
                        cmd.Connection = ctn;
                        MessageBox.Show("Se ha eliminado correctamente " + cmd.ExecuteNonQuery().ToString() + " personal");
                        refrescarEntrenadores();
                    }
                }
                else
                {
                    MessageBox.Show("Para eliminar un entrenador seleccionelo en la tabla", "Información");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método para eliminar a clientes
        private void BtnEliminarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que haya seleccionado solo 1
                if (LsvClientes.SelectedItems != null && LsvClientes.SelectedItems.Count > 0)
                {
                    Cliente a = (Cliente)LsvClientes.SelectedItems[0].Tag;

                    //Utilizamos una ventana de dialogo para confirmar la operación
                    if (MessageBox.Show("¿Seguro(a) que desea eliminar a " + a.Nombre + " " + a.Apellidos + "?", "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //Eliminamos el cliente
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM cliente WHERE idCliente = " + a.IdCliente);
                        cmd.Connection = ctn;
                        MessageBox.Show("Se ha eliminado correctamente" + cmd.ExecuteNonQuery().ToString() + " cliente");
                        refrescarClientes();
                    }
                }
                else
                {
                    MessageBox.Show("Para eliminar un cliente seleccionelo en la tabla", "Información");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método para añadir a entrenadores, abre un nuevo formulario para realizar la acción
        private void BtnAnadirEntenador_Click(object sender, EventArgs e)
        {
            //Se le pasa como argumento el tipo de personal a crear
            FrmDetallesPersonal frm = new FrmDetallesPersonal("Entrenador");

            frm.ShowDialog();

            refrescarEntrenadores();
        }

        //Método para añadir a clientes, abre un nuevo formulario para realizar la acción
        private void BtnAnadirClientes_Click(object sender, EventArgs e)
        {
            FrmDetallesCliente frm = new FrmDetallesCliente();

            frm.ShowDialog();

            refrescarClientes();
        }

        private void LsvEntrenadores_DoubleClick(object sender, EventArgs e)
        {
            modificarEntrenadores();
        }

        private void BTnModificarEntrenador_Click(object sender, EventArgs e)
        {
            modificarEntrenadores();
        }

        private void LsvClientes_DoubleClick(object sender, EventArgs e)
        {
            modificarClientes();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            modificarClientes();
        }

        //Método que para modificar entrenadores, abre un nuevo formulario para realizar la acción
        private void modificarEntrenadores()
        {
            //Comprobamos que haya seleccionado solo 1
            if (LsvEntrenadores.SelectedItems != null && LsvEntrenadores.SelectedItems.Count > 0)
            {
                //Se abre el nuevo formulario y le pasamos el entrenador a modificar
                FrmDetallesPersonal frm = new FrmDetallesPersonal((Entrenador)LsvEntrenadores.SelectedItems[0].Tag);

                frm.ShowDialog();

                refrescarEntrenadores();
            }
            else MessageBox.Show("Para modificar un entrenador seleccionelo en la tabla", "Información");
        }

        //Método que para modificar clientes, abre un nuevo formulario para realizar la acción
        private void modificarClientes()
        {
            //Comprobamos que haya seleccionado solo 1
            if (LsvClientes.SelectedItems != null && LsvClientes.SelectedItems.Count > 0)
            {
                //Se abre el nuevo formulario y le pasamos el cliente a modificar
                FrmDetallesCliente frm = new FrmDetallesCliente((Cliente)LsvClientes.SelectedItems[0].Tag);

                frm.ShowDialog();

                refrescarClientes();
            }
            else MessageBox.Show("Para modificar un cliente seleccionelo en la tabla", "Información");
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

        //Método que filtra los entrenadores y los muestra
        private void BtnFiltrarEntrenadores_Click(object sender, EventArgs e)
        {
            //Comprobamos los filtros
            if (comprobarFiltroTxt(TxtFiltro) && comprobarFiltroCmb(CmbFiltro))
            {
                //Asignamos una petición según el filtro seleccionado
                String sql = "";
                switch (CmbFiltro.Text)
                {
                    case "Nombre":
                        sql = "SELECT * FROM personal WHERE nombre LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Apellidos":
                        sql = "SELECT * FROM personal WHERE apellidos LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Usuario":
                        sql = "SELECT * FROM personal WHERE usuario LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Correo electrónico":
                        sql = "SELECT * FROM personal WHERE correoElectronico LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                }
                try
                {
                    LsvEntrenadores.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    //Mostramos los entrenadores filtrados
                    while (lector.Read())
                    {
                        if (lector[7].ToString().Equals("Entrenador"))
                        {
                            ListViewItem lvi = LsvEntrenadores.Items.Add(lector[1].ToString());
                            lvi.SubItems.Add(lector[2].ToString());
                            lvi.SubItems.Add(lector[3].ToString());
                            lvi.SubItems.Add(lector[5].ToString());
                            try
                            {
                                Entrenador a = new Entrenador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), 
                                    lector[3].ToString(), lector[4].ToString(), lector[5].ToString(), (byte[])lector[6]);
                                lvi.Tag = a;
                            }
                            catch
                            {
                                Entrenador a = new Entrenador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), 
                                    lector[3].ToString(), lector[4].ToString(), lector[5].ToString());
                                lvi.Tag = a;
                            }
                        }
                    }
                    lector.Close();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Filtro incorrecto", "Error");
                    refrescarEntrenadores();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                }
            }
        }

        //Método que filtra los clientes y los muestra
        private void BtnFiltrarClientes_Click(object sender, EventArgs e)
        {
            //Comprobamos los filtros
            if (comprobarFiltroTxt(TxtFiltro) && comprobarFiltroCmb(CmbColumnaClientes))
            {
                //Asignamos una petición según el filtro seleccionado
                String sql = "";
                switch (CmbColumnaClientes.Text)
                {
                    case "Nombre":
                        sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, " +
                            "c.fechaNacimiento, c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, " +
                            "c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                            "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal " +
                            "WHERE c.nombre LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Apellidos":
                        sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, " +
                            "c.fechaNacimiento, c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, " +
                            "c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                            "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal " +
                            "WHERE c.apellidos LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Usuario":
                        sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, " +
                            "c.fechaNacimiento, c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, " +
                            "c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                            "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal " +
                            "WHERE c.usuario LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Correo electrónico":
                        sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, " +
                            "c.fechaNacimiento, c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, " +
                            "c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                            "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal " +
                            "WHERE c.correoElectronico LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Fecha nacimiento":
                        sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, " +
                            "c.fechaNacimiento, c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, " +
                            "c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                            "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal " +
                            "WHERE c.fechaNacimiento LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Teléfono":
                        sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, " +
                            "c.fechaNacimiento, c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, " +
                            "c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                            "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal " +
                            "WHERE c.telefono LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                    case "Entrenador":
                        sql = "SELECT c.IdCliente, c.nombre, c.apellidos, c.usuario, c.contrasena, c.correoElectronico, " +
                            "c.fechaNacimiento, c.telefono, c.peso, c.altura, c.frecuenciaDeporte, c.patologias, " +
                            "c.idPersonal, CONCAT_WS(' ', p.nombre, p.apellidos) AS 'entrenador'" +
                            "FROM cliente c LEFT JOIN personal p ON c.IdPersonal = p.IdPersonal " +
                            "WHERE CONCAT(p.nombre, ' ', p.apellidos) LIKE '%" + TxtFiltro.Text + "%'";
                        break;
                }
                try
                {
                    LsvClientes.Items.Clear();
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    //Mostramos los clientes filtrados
                    while (lector.Read())
                    {
                        double peso = 0, altura = 0;
                        string frecuencia = "", idPersonal = "0";

                        ListViewItem lvi = LsvClientes.Items.Add(lector[1].ToString());
                        lvi.SubItems.Add(lector[2].ToString());
                        lvi.SubItems.Add(lector[3].ToString());
                        lvi.SubItems.Add(lector[5].ToString());
                        string[] fecha = lector[6].ToString().Split(' ');
                        lvi.SubItems.Add(fecha[0]);
                        lvi.SubItems.Add(lector[13].ToString());

                        try
                        {
                            peso = lector.GetDouble(8);
                        }
                        catch { }
                        try
                        {
                            altura = lector.GetDouble(9);
                        }
                        catch { }
                        try
                        {
                            frecuencia = lector.GetString(10);
                        }
                        catch { }
                        try
                        {
                            idPersonal = lector.GetString(12);
                        }
                        catch
                        {
                            idPersonal = "0";
                        }
                        Cliente a = new Cliente(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), 
                            lector[3].ToString(), lector[4].ToString(), lector[5].ToString(), lector[6].ToString(), 
                            lector[7].ToString(), peso, altura, frecuencia, lector[11].ToString(), Int32.Parse(idPersonal));
                        lvi.Tag = a;
                    }
                    lector.Close();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Filtro incorrecto", "Error");
                    refrescarClientes();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                }
            }
        }
    }
}
