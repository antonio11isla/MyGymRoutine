using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyGymRoutineAdministrar
{
    public partial class FrmDetallesPersonal : Form
    {
        MySqlConnection ctn;
        Administrador administrador = new Administrador(0, "", "", "", "", "", null);
        Entrenador entrenador = new Entrenador(0, "", "", "", "", "", null);
        String tipoPersonal = "";
        int x, y;
        bool mover;

        public FrmDetallesPersonal(String tipoPersonal)
        {
            InitializeComponent();
            this.tipoPersonal = tipoPersonal;

            BtnAnadir.Enabled = true;
            BtnAnadir.Visible = true;
            BtnModificar.Enabled = false;
            BtnModificar.Visible = false;
        }

        public FrmDetallesPersonal(Administrador administrador)
        {
            InitializeComponent();
            this.administrador = administrador;

            TxtNombre.Text = administrador.Nombre;
            TxtApellidos.Text = administrador.Apellidos;
            TxtUsuario.Text = administrador.Usuario;
            TxtContrasena.Text = administrador.Contrasena;
            TxtCorreoElectronico.Text = administrador.CorreoElectronico;
            BtnAnadir.Enabled = false;
            BtnAnadir.Visible = false;
            BtnModificar.Enabled = true;
            BtnModificar.Visible = true;
        }

        public FrmDetallesPersonal(Entrenador entrenador)
        {
            InitializeComponent();
            this.entrenador = entrenador;

            TxtNombre.Text = entrenador.Nombre;
            TxtApellidos.Text = entrenador.Apellidos;
            TxtUsuario.Text = entrenador.Usuario;
            TxtContrasena.Text = entrenador.Contrasena;
            TxtCorreoElectronico.Text = entrenador.CorreoElectronico;
            BtnAnadir.Enabled = false;
            BtnAnadir.Visible = false;
            BtnModificar.Enabled = true;
            BtnModificar.Visible = true;
        }

        private void FrmDetallesPersonal_Load(object sender, EventArgs e)
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
        }


        //Método para modificar los datos de un entrenador
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Válidamos la entrada de datos de los campos de texto
                if (validarNombre() && validarApellidos() && validarCorreo() && validarUsuario() && validarContrasena())
                {
                    //Comprobamos si el personal es entrenador o administrador 
                    String idPersonal = "";
                    if (administrador.IdPersonal != 0)
                    {
                        idPersonal = administrador.IdPersonal.ToString();
                    }
                    else
                    {
                        idPersonal = entrenador.IdPersonal.ToString();
                    }

                    //Actualizamos los datos del personal
                    MySqlCommand cmd = new MySqlCommand("UPDATE personal SET nombre = '" + TxtNombre.Text +
                        "', apellidos = '" + TxtApellidos.Text + "', usuario = '" + TxtUsuario.Text +
                        "', contrasena = '" + TxtContrasena.Text + "', correoElectronico = '" + TxtCorreoElectronico.Text + 
                        "' where idPersonal = " + idPersonal);
                    cmd.Connection = ctn;
                    MessageBox.Show("Se modificado correctamente " + cmd.ExecuteNonQuery().ToString() + " personal");

                    //Notificamos al personal con un correo electrónico con todos sus datos
                    if (ChbNotificar.Checked == true)
                    {
                        //Mensaje del correo
                        String mensaje = "Le informamos de que se han sido modificado sus datos.\n" +
                            "Nombre: " + TxtNombre.Text + "\n" +
                            "Apellido: " + TxtApellidos.Text + "\n" +
                            "Usuario: " + TxtUsuario.Text + "\n" +
                            "Contraseña: " + TxtContrasena.Text + "\n\n" +
                            "Muchas gracias por usar nuestros servicios,\n" +
                            "MyGymRoutine.";

                        //Creamos el correo electrónico
                        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                        msg.To.Add(TxtCorreoElectronico.Text);
                        msg.Subject = "Modificacion de datos";
                        msg.SubjectEncoding = System.Text.Encoding.UTF8;
                        msg.Body = mensaje;
                        msg.BodyEncoding = System.Text.Encoding.UTF8;
                        //msg.IsBodyHtml = true;

                        //Creamos y damos valores al cliente
                        msg.From = new System.Net.Mail.MailAddress("info-gym@mygymroutine.es");
                        System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                        cliente.Credentials = new System.Net.NetworkCredential("info-gym@mygymroutine.es", "usuario_Gym_2021");
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.Host = "smtp.ionos.es";

                        //Enviamos el correo
                        try
                        {
                            cliente.Send(msg);
                        }
                        catch
                        {
                            MessageBox.Show("Error al enviar el correo.", "Error");
                        }
                    }
                }

                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que añade un personal nuevo
        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                //Válidamos la entrada de datos de los campos de texto
                if (validarNombre() && validarApellidos() && validarCorreo() && validarUsuario() && validarContrasena())
                {
                    //Añadimos al nuevo personal
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO personal (nombre, apellidos, usuario, contrasena, correoElectronico, tipoPersonal)" +
                    " VALUES ('" + TxtNombre.Text + "', '" + TxtApellidos.Text + "', '" + TxtUsuario.Text + "', '" + 
                    TxtContrasena.Text + "', '" + TxtCorreoElectronico.Text + "', '" + tipoPersonal + "')");
                    cmd.Connection = ctn;
                    MessageBox.Show("Se añadido correctamente " + cmd.ExecuteNonQuery().ToString() + " personal");

                    //Notificamos al personal con un correo electrónico con todos sus datos
                    if (ChbNotificar.Checked == true)
                    {
                        //Mensaje del correo
                        String mensaje = "Le informamos de que se ha sido dado de alta en nuestra app.\n" +
                            "Nombre: " + TxtNombre.Text + "\n" +
                            "Apellido: " + TxtApellidos.Text + "\n" +
                            "Usuario: " + TxtUsuario.Text + "\n" +
                            "Contraseña: " + TxtContrasena.Text + "\n\n" +
                            "Muchas gracias por usar nuestros servicios,\n" +
                            "MyGymRoutine.";

                        //Creamos el correo electrónico
                        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                        msg.To.Add(TxtCorreoElectronico.Text);
                        msg.Subject = "Alta en MyGymRoutine";
                        msg.SubjectEncoding = System.Text.Encoding.UTF8;
                        msg.Body = mensaje;
                        msg.BodyEncoding = System.Text.Encoding.UTF8;
                        //msg.IsBodyHtml = true;

                        //Creamos y damos valores al cliente
                        msg.From = new System.Net.Mail.MailAddress("info-gym@mygymroutine.es");
                        System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                        cliente.Credentials = new System.Net.NetworkCredential("info-gym@mygymroutine.es", "usuario_Gym_2021");
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.Host = "smtp.ionos.es";

                        //Enviamos el correo
                        try
                        {
                            cliente.Send(msg);
                        }
                        catch
                        {
                            MessageBox.Show("Error al enviar el correo.", "Error");
                        }
                    }
                }

                this.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetallesPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctn.Close();
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

        private void BtnContraAleatoria_Click(object sender, EventArgs e)
        {
            TxtContrasena.Text = generarAleatorio();
            errorProviderDetallesPersonal.SetError(TxtContrasena, "");
        }

        private void BtnUserAleatorio_Click(object sender, EventArgs e)
        {
            TxtUsuario.Text = generarAleatorio();
            errorProviderDetallesPersonal.SetError(TxtUsuario, "");
        }

        //Método que genera un String aleatorio válido como contraseña o usuario
        private String generarAleatorio() 
        {
            Random rdn = new Random();
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int longitud = caracteres.Length;
            char letra;
            int longitudContrasena = 10;
            string contrasenaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasena; i++)
            {
                letra = caracteres[rdn.Next(longitud)];
                contrasenaAleatoria += letra.ToString();
            }
            return contrasenaAleatoria;
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            validarNombre();
        }


        //Método que valida el campo de nombre y devuelvo true or false en función si es correcto o no
        private bool validarNombre()
        {
            if (TxtNombre.Text.Equals(""))
            {
                errorProviderDetallesPersonal.SetError(TxtNombre, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtNombre.Text,
                            "(^[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})(\\s[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})?$"))
            {
                errorProviderDetallesPersonal.SetError(TxtNombre, "");
                return true;
            }
            else
            {
                errorProviderDetallesPersonal.SetError(TxtNombre, "El nombre no tiene el formato correcto");
                return false;
            }
        }

        private void TxtApellidos_Validating(object sender, CancelEventArgs e)
        {
            validarApellidos();
        }

        //Método que valida el campo de apellidos y devuelvo true or false en función si es correcto o no
        private bool validarApellidos()
        {
            if (TxtApellidos.Text.Equals(""))
            {
                errorProviderDetallesPersonal.SetError(TxtApellidos, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtApellidos.Text,
                            "(^[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})(\\s[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})?$"))
            {
                errorProviderDetallesPersonal.SetError(TxtApellidos, "");
                return true;
            }
            else
            {
                errorProviderDetallesPersonal.SetError(TxtApellidos, "El apellido no tiene el formato correcto");
                return false;
            }
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            validarUsuario();
        }

        //Método que valida el campo de usuario y devuelvo true or false en función si es correcto o no
        private bool validarUsuario()
        {
            if (TxtUsuario.Text.Equals(""))
            {
                errorProviderDetallesPersonal.SetError(TxtUsuario, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtUsuario.Text.Equals(administrador.Usuario))
            {
                errorProviderDetallesPersonal.SetError(TxtUsuario, "");
                return true;
            }
            else if (TxtUsuario.Text.Equals(entrenador.Usuario))
            {
                errorProviderDetallesPersonal.SetError(TxtUsuario, "");
                return true;
            }
            else if (Regex.IsMatch(TxtUsuario.Text,
                            "^([A-Za-z0-9ñÑ_]{8,15})$"))
            {
                try
                {
                    String sql = "SELECT usuario FROM personal WHERE usuario = '" + TxtUsuario.Text + "'";
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
                        errorProviderDetallesPersonal.SetError(TxtUsuario, "El usuario ya esá en uso");
                        return false;
                    }
                    else
                    {
                        errorProviderDetallesPersonal.SetError(TxtUsuario, "");
                        return true;
                    }


                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    return false;
                }
            }
            else
            {
                errorProviderDetallesPersonal.SetError(TxtUsuario,
                    "El usuario no tiene el formato correcto\n" +
                    "(De 8 a 15 caracteres. Solo letras sin tilde, números y _)");
                return false;
            }
        }

        private void TxtContrasena_Validating(object sender, CancelEventArgs e)
        {
            validarContrasena();
        }

        //Método que valida el campo de contraseña y devuelvo true or false en función si es correcto o no
        private bool validarContrasena()
        {
            if (TxtContrasena.Text.Equals(""))
            {
                errorProviderDetallesPersonal.SetError(TxtContrasena, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtContrasena.Text,
                            "^([A-Za-z0-9ñÑ]{8,15})$"))
            {
                errorProviderDetallesPersonal.SetError(TxtContrasena, "");
                return true;
            }
            else
            {
                errorProviderDetallesPersonal.SetError(TxtContrasena,
                    "La contraseña no tiene el formato correcto\n" +
                    "(De 8 a 15 caracteres. Solo letras sin tilde y números)");
                return false;
            }
        }

        private void TxtCorreoElectronico_Validating(object sender, CancelEventArgs e)
        {
            validarCorreo();
        }

        //Método que valida el campo de correo y devuelvo true or false en función si es correcto o no
        private bool validarCorreo()
        {
            if (TxtCorreoElectronico.Text.Equals(""))
            {
                errorProviderDetallesPersonal.SetError(TxtCorreoElectronico, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtCorreoElectronico.Text.Equals(administrador.CorreoElectronico))
            {
                errorProviderDetallesPersonal.SetError(TxtCorreoElectronico, "");
                return true;
            }
            else if (TxtCorreoElectronico.Text.Equals(entrenador.CorreoElectronico))
            {
                errorProviderDetallesPersonal.SetError(TxtCorreoElectronico, "");
                return true;
            }
            else if (Regex.IsMatch(TxtCorreoElectronico.Text,
                            "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$"))
            {
                try
                {
                    String sql = "SELECT correoElectronico FROM personal WHERE correoElectronico = '" + TxtCorreoElectronico.Text + "'";
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
                        errorProviderDetallesPersonal.SetError(TxtCorreoElectronico, "El correo electrónico ya esá en uso");
                        return false;
                    }
                    else
                    {
                        errorProviderDetallesPersonal.SetError(TxtCorreoElectronico, "");
                        return true;                        
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    return false;
                }
            }
            else
            {
                errorProviderDetallesPersonal.SetError(TxtCorreoElectronico, "El correo electrónico no tiene el formato correcto");
                return false;
            }
        }
    }
}
