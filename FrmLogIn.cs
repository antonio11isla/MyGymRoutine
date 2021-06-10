using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyGymRoutineAdministrar
{
    public partial class FrmLogIn : Form
    {
        MySqlConnection ctn;
        Administrador administrador;
        Entrenador entrenador;
        int x, y;
        bool mover;

        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //FrmPruebas frm = new FrmPruebas();
            //this.Hide();
            //frm.ShowDialog();
            //Application.Exit();
        }

        //Método que comprueba la entrada de datos del campo usuario
        //y devuelvo true or false en función si es correcto o no
        private bool comprobarUsuario() 
        {
            if (Regex.IsMatch(TxtUsuario.Text, "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])"))
            {
                errorProviderLogIn.SetError(TxtUsuario,
                    "El usuario tiene algún caracter no es válido\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}=)");
                return false;
            }
            else
            {
                errorProviderLogIn.SetError(TxtUsuario, "");
                return true;
            }
        }
        //Método que comprueba la entrada de datos del campo contraseña
        //y devuelvo true or false en función si es correcto o no
        private bool comprobarContrasena()
        {
            if (Regex.IsMatch(TxtContrasena.Text, "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])"))
            {
                errorProviderLogIn.SetError(TxtContrasena,
                    "La contraseña tiene algún caracter no es válido\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})=");
                return false;
            }
            else
            {
                errorProviderLogIn.SetError(TxtContrasena, "");
                return true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        //Método que abre un formulario nuevo según el tipo de personal
        private void usuarioIniciado(Form frm) {
            
            ctn.Close();
            this.Hide();
            frm.ShowDialog();
            try
            {
                this.Visible = true;
            }
            catch{ }
            TxtUsuario.Text = "";
            TxtContrasena.Text = "";
            ctn.Open();
        }

        //Método que pasa el foco del campo usuario a contraseña al pulsar intro
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                TxtContrasena.Focus();
        }

        //Método que llama al logIn al pulsar intro en el campo contraseña
        private void TxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                login();
        }

        //Método que comprueba los datos de inicio de sesión y decide que tipo de personal es
        private void login()
        {
            //Comprobamos que los campos sean correctos
            if (comprobarUsuario() && comprobarContrasena())
            {
                try
                {
                    ctn = new MySqlConnection("Server=servergym.ddns.net; Port=9091; Database=db_gimnasio; Uid=usuarioGym; Password=usuario_Gym_2021;");
                    try
                    {
                        ctn.Open();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException)
                    {
                        MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    }                                                                                                                                                     


                    //Si hay coincidencia del usuario y contraseña con algún suario, comprobamos el tipo de personal y
                    //creamos un objeto con sus datos que pasamos al siguiente formulario
                    Boolean entrenadorEncontrado = false, administradorEncontrado = false, jefeEncontrado = false;

                    String sql = "SELECT * FROM personal WHERE usuario = '" + TxtUsuario.Text + "' AND contrasena = '" + TxtContrasena.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        if (lector["tipoPersonal"].ToString().Equals("Entrenador"))
                        {
                            try
                            {
                                entrenador = new Entrenador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), 
                                    lector[4].ToString(), lector[5].ToString(), (byte[])lector[6]);
                            }
                            catch
                            {
                                entrenador = new Entrenador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), 
                                    lector[4].ToString(), lector[5].ToString());
                            }
                            entrenadorEncontrado = true;
                            break;
                            }
                        if (lector["tipoPersonal"].ToString().Equals("Administrador"))
                        {
                            try
                            {
                                administrador = new Administrador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), 
                                    lector[4].ToString(), lector[5].ToString(), (byte[])lector[6]);
                            }
                            catch
                            {
                                administrador = new Administrador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),
                                    lector[4].ToString(), lector[5].ToString());
                            }
                            administradorEncontrado = true;
                            break;
                        }
                        if (lector["tipoPersonal"].ToString().Equals("Jefe"))
                        {
                            try
                            {
                                administrador = new Administrador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),
                                    lector[4].ToString(), lector[5].ToString(), (byte[])lector[6]);
                            }
                            catch
                            {
                                administrador = new Administrador(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(),
                                    lector[4].ToString(), lector[5].ToString());
                            }
                            jefeEncontrado = true;
                            break;
                        }
                    }
                    lector.Close();

                    //Según el tipo de personal encontramos iniciamos el formulario que le corresponda
                    if (entrenadorEncontrado)
                    {
                        FrmEntrenador frm = new FrmEntrenador(entrenador);
                        usuarioIniciado(frm);
                    }
                    else if (administradorEncontrado)
                    {
                        FrmAdministrador frm = new FrmAdministrador(administrador);
                        usuarioIniciado(frm);
                    }
                    else if (jefeEncontrado)
                    {
                        FrmJefe frm = new FrmJefe(administrador);
                        usuarioIniciado(frm);
                    }
                    else
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Información");
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMiminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Método para mover el formulario desde el borde personalizado
        private void PcbBorde_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            x = e.X;
            y = e.Y;
        }

        //Método para mover el formulario desde el borde personalizado
        private void PcbBorde_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        //Método para mover el formulario desde el borde personalizado
        private void PcbBorde_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        //Método que abre un nuevo formulario para enviar correo con los datos de inicio de sesión
        private void LnkCorreo_Click(object sender, EventArgs e)
        {
            FrmCorreo frm = new FrmCorreo();
            frm.ShowDialog();
        }
    }
}
