using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGymRoutineAdministrar
{
    public partial class FrmDetallesCliente : Form
    {
        String idEntrenador = "0";
        String altura = "", peso = "", fechaNac = "", frecuenciaDeporte = "", tlf = "", patologias = "";
        MySqlConnection ctn;
        Cliente cliente = new Cliente(0, "", "", "", "", "", "", "", 0, 0, "");
        int x, y;
        bool mover;

        public FrmDetallesCliente()
        {
            InitializeComponent();

            BtnAnadir.Enabled = true;
            BtnAnadir.Visible = true;
            BtnModificar.Enabled = false;
            BtnModificar.Visible = false;
        }        

        public FrmDetallesCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;

            BtnAnadir.Enabled = false;
            BtnAnadir.Visible = false;
            BtnModificar.Enabled = true;
            BtnModificar.Visible = true;

            //Cargamos los datos del cliente a modificar
            TxtNombre.Text = cliente.Nombre;
            TxtApellidos.Text = cliente.Apellidos;
            TxtUsuario.Text = cliente.Usuario;
            TxtContrasena.Text = cliente.Contrasena;
            TxtCorreoElectronico.Text = cliente.CorreoElectronico;
            MtbFechaNac.Text = cliente.FechaNacimiento;
            if (cliente.Peso > 0)
                TxtPeso.Text = cliente.Peso.ToString();
            MtbTlf.Text = cliente.Telefono.ToString();
            if (cliente.Altura>0)
                TxtAltura.Text = cliente.Altura.ToString();
            TxtPatologias.Text = cliente.Patologias;
            CmbFrecuencia.Text = cliente.FrecuenciaDeporte;
        }

        private void FrmDetallesCliente_Load(object sender, EventArgs e)
        {
            ctn = new MySqlConnection("Server=servergym.ddns.net; Port=9091; Database=db_gimnasio; Uid=usuarioGym; Password=usuario_Gym_2021;");
            try
            {
                ctn.Open();

                //Consultamos el nombre y apellidos del entrenador del cliente si tiene
                String sql = "SELECT nombre, apellidos FROM personal WHERE idPersonal = " + cliente.IdEntrenador;
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    CmbEntrenador.Text = lector[0].ToString() + " " + lector[1].ToString();
                }
                lector.Close();

                //Consultamos los nombres y apellidos de los entrenadores y lo añadimos al comboBox
                sql = "SELECT nombre, apellidos, tipoPersonal FROM personal";
                cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    if (lector[2].ToString().Equals("Entrenador"))
                    {
                        CmbEntrenador.Items.Add(lector[0].ToString() + " " + lector[1].ToString());
                    }
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que modifica un cliente
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Válidamos la entrada de datos de los campos
                if (validarNombre() && validarApellidos() && validarCorreo() && validarUsuario() && validarContrasena() && validarFecha() && 
                    validarTlf() && validarPeso() && validarAltura() && validarFrecuencia() && validarPatologias() && validarEntrenador())
                {
                    //Actualizamos los datos del cliente
                    MySqlCommand cmd = new MySqlCommand("UPDATE cliente SET nombre = '" + TxtNombre.Text +
                        "', apellidos = '" + TxtApellidos.Text + "', usuario = '" + TxtUsuario.Text +
                        "', contrasena = '" + TxtContrasena.Text + "', correoElectronico = '" + TxtCorreoElectronico.Text +
                        "', fechaNacimiento = '" + fechaNac + "', telefono = " + tlf +
                        ", peso = " + peso + ", altura = " + altura + ", frecuenciaDeporte = " + frecuenciaDeporte + 
                        ", patologias = " + patologias + ", idPersonal = " + idEntrenador +
                        " WHERE idCliente = " + cliente.IdCliente);
                    cmd.Connection = ctn;
                    MessageBox.Show("Se modificado correctamente " + cmd.ExecuteNonQuery().ToString() + " cliente.");

                    //Notificamos al cliente con un correo electrónico con todos sus datos
                    if (ChbNotificar.Checked == true)
                    {
                        String entre = CmbEntrenador.Text;
                        if (CmbEntrenador.Text.Equals(""))
                            entre = "Solicite un entrenador en su gimnasio";

                        //Mensaje del correo
                        String mensaje = "Le informamos de que se han sido modificado sus datos.\n" +
                            "Nombre: " + TxtNombre.Text + "\n" +
                            "Apellido: " + TxtApellidos.Text + "\n" +
                            "Usuario: " + TxtUsuario.Text + "\n" +
                            "Contraseña: " + TxtContrasena.Text + "\n" +
                            "Fecha de nacimiento: " + fechaNac + "\n" +
                            "Teléfono: " + MtbTlf.Text + "\n" +
                            "Peso: " + peso + "\n" +
                            "Altura: " + altura + "\n" +
                            "Frecuencia con la que practica deporte: " + CmbFrecuencia.Text + "\n" +
                            "Patologías: " + TxtPatologias.Text + "\n" +
                            "Entrenador: " + entre + "\n\n" +
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

                    this.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }

        }

        //Método que añade un cliente nuevo
        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                //Válidamos la entrada de datos de los campos
                if (validarNombre() && validarApellidos() && validarCorreo() && validarUsuario() && validarContrasena() && validarFecha() && 
                    validarTlf() && validarPeso() && validarAltura() && validarFrecuencia() && validarPatologias() && validarEntrenador())
                {
                    //Añadimos al nuevo cliente
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO cliente (nombre, apellidos, usuario, contrasena," +
                    " correoElectronico, fechaNacimiento, telefono, peso, altura, frecuenciaDeporte, patologias, idPersonal)" +
                    " VALUES ('" + TxtNombre.Text + "', '" + TxtApellidos.Text + "', '" + TxtUsuario.Text + "', '" +
                    TxtContrasena.Text + "', '" + TxtCorreoElectronico.Text + "', '" + fechaNac + "', " + tlf + "," +
                    peso + ", " + altura + ", " + frecuenciaDeporte + ", " + patologias + ", " + idEntrenador + ")");
                    cmd.Connection = ctn;
                    MessageBox.Show("Se añadido correctamente " + cmd.ExecuteNonQuery().ToString() + " cliente.");

                    //Notificamos al cliente con un correo electrónico con todos sus datos
                    if (ChbNotificar.Checked == true)
                    {
                        String entre = CmbEntrenador.Text;
                        if (CmbEntrenador.Text.Equals(""))
                            entre = "Solicite un entrenador en su gimnasio";

                        //Mensaje del correo
                        String mensaje = "Le informamos de que se ha sido dado de alta en nuestra app.\n" +
                            "Nombre: " + TxtNombre.Text + "\n" +
                            "Apellido: " + TxtApellidos.Text + "\n" +
                            "Usuario: " + TxtUsuario.Text + "\n" +
                            "Contraseña: " + TxtContrasena.Text + "\n" +
                            "Fecha de nacimiento: " + fechaNac + "\n" +
                            "Teléfono: " + MtbTlf.Text + "\n" +
                            "Peso: " + peso + "\n" +
                            "Altura: " + altura + "\n" +
                            "Frecuencia con la que practica deporte: " + CmbFrecuencia.Text + "\n" +
                            "Patologías: " + TxtPatologias.Text + "\n" +
                            "Entrenador: " + entre + "\n\n" +
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

                    this.Close();
                }
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

        private void FrmDetallesCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctn.Close();
        }

        private void BtnContraAleatoria_Click(object sender, EventArgs e)
        {
            TxtContrasena.Text = generarAleatorio();
            errorProviderDetallesClientes.SetError(TxtContrasena, "");
        }

        private void BtnUserAleatorio_Click(object sender, EventArgs e)
        {
            TxtUsuario.Text = generarAleatorio();
            errorProviderDetallesClientes.SetError(TxtUsuario, "");
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
                errorProviderDetallesClientes.SetError(TxtNombre, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtNombre.Text,
                            "(^[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})(\\s[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})?$"))
            {
                errorProviderDetallesClientes.SetError(TxtNombre, "");
                return true;
            }
            else
            {
                errorProviderDetallesClientes.SetError(TxtNombre, "El nombre no tiene el formato correcto");
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
                errorProviderDetallesClientes.SetError(TxtApellidos, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtApellidos.Text,
                            "(^[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})(\\s[A-ZÁÉÍÓÚÑ]{1}([a-zñáéíóú]+){2,})?$"))
            {
                errorProviderDetallesClientes.SetError(TxtApellidos, "");
                return true;
            }
            else
            {
                errorProviderDetallesClientes.SetError(TxtApellidos, "El apellido no tiene el formato correcto");
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
                errorProviderDetallesClientes.SetError(TxtUsuario, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtUsuario.Text.Equals(cliente.Usuario))
            {
                errorProviderDetallesClientes.SetError(TxtUsuario, "");
                return true;
            }
            else if (Regex.IsMatch(TxtUsuario.Text,
                            "^([A-Za-z0-9ñÑ_]{8,15})$"))
            {
                try
                {
                    String sql = "SELECT usuario FROM cliente WHERE usuario = '" + TxtUsuario.Text + "'";
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
                        errorProviderDetallesClientes.SetError(TxtUsuario, "El usuario ya esá en uso");
                        return false;
                    }
                    else
                    {
                        errorProviderDetallesClientes.SetError(TxtUsuario, "");
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
                errorProviderDetallesClientes.SetError(TxtUsuario,
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
                errorProviderDetallesClientes.SetError(TxtContrasena, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtContrasena.Text,
                            "^([A-Za-z0-9ñÑ]{8,15})$"))
            {
                errorProviderDetallesClientes.SetError(TxtContrasena, "");
                return true;
            }
            else
            {
                errorProviderDetallesClientes.SetError(TxtContrasena,
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
                errorProviderDetallesClientes.SetError(TxtCorreoElectronico, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtCorreoElectronico.Text.Equals(cliente.CorreoElectronico))
            {
                errorProviderDetallesClientes.SetError(TxtCorreoElectronico, "");
                return true;
            }
            else if (Regex.IsMatch(TxtCorreoElectronico.Text,
                            "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$"))
            {
                try
                {
                    String sql = "SELECT correoElectronico FROM cliente WHERE correoElectronico = '" + TxtCorreoElectronico.Text + "'";
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
                        errorProviderDetallesClientes.SetError(TxtCorreoElectronico, "El correo electrónico ya esá en uso");
                        return false;
                    }
                    else
                    {
                        errorProviderDetallesClientes.SetError(TxtCorreoElectronico, "");
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
                errorProviderDetallesClientes.SetError(TxtCorreoElectronico, "El correo electrónico no tiene el formato correcto");
                return false;
            }
        }

        private void MtbFechaNac_Validating(object sender, CancelEventArgs e)
        {
            validarFecha();
        }


        //Método que valida el campo de fecha y devuelvo true or false en función si es correcto o no
        private bool validarFecha()
        {
            DateTime fechaActual = DateTime.Now;
            DateTime fechaAntigua = new DateTime(1920, 01, 01);
            String[] fechaS = MtbFechaNac.Text.Split('-');
            try
            {
                DateTime fecha = new DateTime(Int32.Parse(fechaS[2]), Int32.Parse(fechaS[1]), Int32.Parse(fechaS[0]));
                if (MtbFechaNac.Text.Equals(""))
                {
                    errorProviderDetallesClientes.SetError(MtbFechaNac, "El campo no puede quedar vacio");
                    return false;
                }
                else if (DateTime.Compare(fecha, fechaActual) >= 0 || DateTime.Compare(fechaAntigua, fecha) >= 0)
                {
                    errorProviderDetallesClientes.SetError(MtbFechaNac, "Fecha incorrecta");
                    return false;
                }
                else
                {
                    errorProviderDetallesClientes.SetError(MtbFechaNac, "");
                    this.fechaNac = fechaS[2] + "-" + fechaS[1] + "-" + fechaS[0];
                    return true;
                }
            }
            catch
            {
                errorProviderDetallesClientes.SetError(MtbFechaNac, "Fecha incorrecta");
                return false;
            }
        }

        private void MtbTlf_Validating(object sender, CancelEventArgs e)
        {
            validarTlf();
        }

        //Método que valida el campo de telefono y devuelvo true or false en función si es correcto o no
        private bool validarTlf()
        {
            if (MtbTlf.Text.Equals("        "))
            {
                errorProviderDetallesClientes.SetError(MtbTlf, "");
                this.tlf = "NULL";
                return true;
            }
            if (Regex.IsMatch(MtbTlf.Text,
                            "^[67](\\d){2}\\s(\\d){3}\\s(\\d){3}$"))
            {
                errorProviderDetallesClientes.SetError(MtbTlf, "");
                this.tlf = "'" + MtbTlf.Text + "'";
                return true;
            }
            else
            {
                errorProviderDetallesClientes.SetError(MtbTlf, "El número no tiene el formato correcto");
                this.tlf = "NULL";
                return false;
            }
        }

        private void TxtAltura_Validating(object sender, CancelEventArgs e)
        {
            validarAltura();
        }

        //Método que valida el campo de altura y devuelvo true or false en función si es correcto o no
        private bool validarAltura()
        {
            try
            {
                if (TxtAltura.Text.Equals(""))
                {
                    errorProviderDetallesClientes.SetError(TxtAltura, "");
                    this.altura = "NULL";
                    return true;
                }

                String alturaAux = TxtAltura.Text.Replace('.', ',');
                double altura = double.Parse(alturaAux);

                if ((0.8 > altura) || altura > 2.4)
                {
                    errorProviderDetallesClientes.SetError(TxtAltura, "La altura es incorrecta");
                    this.altura = "NULL";
                    return false;
                }
                else
                {
                    errorProviderDetallesClientes.SetError(TxtAltura, "");
                    this.altura = altura.ToString().Replace(',', '.');
                    return true;
                }
            }
            catch
            {
                errorProviderDetallesClientes.SetError(TxtAltura, "Error de formato(9,99)");
                this.altura = "NULL";
                return false;
            }
        }

        private void TxtPeso_Validating(object sender, CancelEventArgs e)
        {
            validarPeso();
        }

        //Método que valida el campo de peso y devuelvo true or false en función si es correcto o no
        private bool validarPeso()
        {
            try
            {
                if (TxtPeso.Text.Equals(""))
                {
                    errorProviderDetallesClientes.SetError(TxtPeso, "");
                    this.peso = "NULL";
                    return true;
                }

                String pesoAux = TxtPeso.Text.Replace('.', ',');
                double peso = double.Parse(pesoAux);
                
                if ((20 > peso) || peso > 200)
                {
                    errorProviderDetallesClientes.SetError(TxtPeso, "El peso es incorrecto");
                    this.peso = "NULL";
                    return false;
                }
                else
                {
                    errorProviderDetallesClientes.SetError(TxtPeso, "");
                    this.peso = Math.Round(peso,2).ToString().Replace(',', '.');
                    return true;
                }
            }
            catch
            {
                errorProviderDetallesClientes.SetError(TxtPeso, "Error de formato(999,99)");
                this.peso = "NULL";
                return false;
            }
        }

        //Método que valida el campo de petologías y devuelvo true or false en función si es correcto o no
        private void TxtPatologias_Validating(object sender, CancelEventArgs e)
        {
            validarPatologias();
        }

        private bool validarPatologias()
        {
            if (TxtPatologias.Text.Equals(""))
            {
                errorProviderDetallesClientes.SetError(TxtPatologias, "");
                patologias = "NULL";
                return true;
            }
            else if (Regex.IsMatch(TxtPatologias.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtPatologias.Text.Length > 200)
            {
                errorProviderDetallesClientes.SetError(TxtPatologias,
                    "El campo tiene algún caracter que no es válido\n" +
                    "200 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                errorProviderDetallesClientes.SetError(TxtPatologias, "");
                patologias = "'" + TxtPatologias.Text + "'";
                return true;
            }
        }
        
        private void CmbFrecuencia_Validating(object sender, CancelEventArgs e)
        {
            validarFrecuencia();
        }

        //Método que valida el campo de frecuencia de deporte y devuelvo true or false en función si es correcto o no
        private bool validarFrecuencia()
        {
            if (CmbFrecuencia.Text.Equals(""))
            {
                errorProviderDetallesClientes.SetError(CmbFrecuencia, "");
                frecuenciaDeporte = "NULL";
                return true;
            }
            else if (CmbFrecuencia.Text.Equals("nunca") || CmbFrecuencia.Text.Equals("menos de 2 días") ||
                CmbFrecuencia.Text.Equals("entre 2 y 5 días") || CmbFrecuencia.Text.Equals("más de 5 días"))
            {
                errorProviderDetallesClientes.SetError(CmbFrecuencia, "");
                frecuenciaDeporte = "'" + CmbFrecuencia.Text + "'";
                return true;
            }
            else
            {
                errorProviderDetallesClientes.SetError(CmbFrecuencia, "El campo tiene un valor incorrecto");
                frecuenciaDeporte = "NULL";
                return false;
            }
        }

        private void CmbEntrenador_Validating(object sender, CancelEventArgs e)
        {
            validarEntrenador();
        }

        //Método que valida el campo del entrenador y devuelvo true or false en función si es correcto o no
        private bool validarEntrenador() 
        {
            if (CmbEntrenador.Text.Equals(""))
            {
                errorProviderDetallesClientes.SetError(CmbEntrenador, "");
                idEntrenador = "NULL";
                return true;
            }
            if (Regex.IsMatch(CmbEntrenador.Text, "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])"))
            {
                errorProviderDetallesClientes.SetError(CmbEntrenador, "El campo tiene algún carácter no válido");
                return false;
            }
            else
            {
                try
                {
                    String sql = "SELECT idPersonal FROM personal WHERE CONCAT(nombre, ' ', apellidos) = '" + CmbEntrenador.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    idEntrenador = "0";
                    while (lector.Read())
                    {
                        idEntrenador = lector[0].ToString();
                    }
                    lector.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    return false;
                }

                if (idEntrenador.Equals("0"))
                {
                    errorProviderDetallesClientes.SetError(CmbEntrenador, "El entrenador es incorrecto.");
                    return false;
                }
                else
                {
                    errorProviderDetallesClientes.SetError(CmbEntrenador, "");
                    return true;
                }
            }
        }
    }
}
