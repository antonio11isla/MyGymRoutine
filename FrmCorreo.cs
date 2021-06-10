using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGymRoutineAdministrar
{
    public partial class FrmCorreo : Form
    {
        int x, y;
        bool mover;
        MySqlConnection ctn;

        public FrmCorreo()
        {
            InitializeComponent();
        }

        private void FrmCorreo_Load(object sender, EventArgs e)
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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCorreo_FormClosing(object sender, FormClosingEventArgs e)
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

        //Método que envía los datos de inicio de sesión por correo electrónico al correo introducido de este
        private void BtnRecuperarDatos_Click(object sender, EventArgs e)
        {
            if (validarCorreo())
            {
                String mensaje = "";

                try
                {
                    String sql = "SELECT usuario, contrasena FROM personal WHERE correoElectronico = '" + TxtCorreo.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        mensaje = "Le informamos de que se ha pedido la recuperación de sus datos de inicio de sesión.\n" +
                            "Usuario: " + lector[0].ToString() + "\n" +
                            "Contraseña: " + lector[1].ToString() + "\n\n" +
                            "Muchas gracias por usar nuestros servicios,\n" +
                            "MyGymRoutine.";
                    }
                    lector.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                }

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(TxtCorreo.Text);
                msg.Subject = "Recuperación datos";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Body = mensaje;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                //msg.IsBodyHtml = true;

                msg.From = new System.Net.Mail.MailAddress("info-gym@mygymroutine.es");
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("info-gym@mygymroutine.es", "usuario_Gym_2021");
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.ionos.es";

                try
                {
                    cliente.Send(msg);
                    MessageBox.Show("Correo enviado con éxito.", "Información");
                }
                catch
                {
                    MessageBox.Show("Error al enviar el correo.", "Error");
                }
                this.Close();
            }
        }

        //Método que comprueba la entrada de datos del campo correo
        //y devuelvo true or false en función si es correcto o no
        private bool validarCorreo()
        {
            if (TxtCorreo.Text.Equals(""))
            {
                errorProviderCorreo.SetError(TxtCorreo, "Introduzca su correo electrónico");
                return false;
            }
            else if (Regex.IsMatch(TxtCorreo.Text,
                             "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$"))
            {
                try
                {
                    String sql = "SELECT correoElectronico FROM personal WHERE correoElectronico = '" + TxtCorreo.Text + "'";
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
                        errorProviderCorreo.SetError(TxtCorreo, "");
                        return true;
                    }
                    else
                    {
                        errorProviderCorreo.SetError(TxtCorreo, "Correo electrónico incorrecto");
                        return false;
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
                errorProviderCorreo.SetError(TxtCorreo, "El correo electrónico no tiene el formato correcto");
                return false;
            }
        }
    }
}
