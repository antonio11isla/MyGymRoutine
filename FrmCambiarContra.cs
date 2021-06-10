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
    public partial class FrmCambiarContra : Form
    {
        Personal personal;
        MySqlConnection ctn;
        int x, y;
        bool mover;

        public FrmCambiarContra(Personal personal)
        {
            InitializeComponent();
            this.personal = personal;
        }

        private void FrmCambiarContra_Load(object sender, EventArgs e)
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

        //Método que cambiar la contraseña del usuario
        private void BtnCambiarContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que la contraseña antigua este bien introducida
                if (validarContrasenaAntigua())
                {
                    errorProviderContra.SetError(TxtContrasena, "");

                    //Comprobamos que las contraseñas nuevas ´sean válidas
                    if (validarContrasena(TxtNuevaContra) && validarConfirmarContra())
                    {
                        //Actualizamos las contraseñas
                        String sql = "UPDATE personal SET contrasena = '" + TxtConfirmarContra.Text + "' WHERE idPersonal = " + personal.IdPersonal;
                        MySqlCommand cmd = new MySqlCommand(sql);
                        cmd.Connection = ctn;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se ha modificado correctamente la contraseña");
                        this.Close();
                    }
                }
                else
                    errorProviderContra.SetError(TxtContrasena, "La contraseña es incorrecta");
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        private void TxtContrasena_Validating(object sender, CancelEventArgs e)
        {
            validarContrasena(TxtContrasena);
        }

        //Método para validar la contraseña antigua
        private bool validarContrasenaAntigua()
        {
            try
            {
                String sql = "SELECT contrasena FROM personal WHERE idPersonal = " + personal.IdPersonal;
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                bool coincide = false; 
                while (lector.Read())
                {
                    if (lector[0].ToString().Equals(TxtContrasena.Text))
                        coincide = true;
                    else
                        coincide = false;
                }
                lector.Close();
                return coincide;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                return false;
            }
        }

        private void TxtNuevaContra_Validating(object sender, CancelEventArgs e)
        {
            validarContrasena(TxtNuevaContra);
        }

        //Método para validar una contraseña
        private bool validarContrasena(TextBox txt)
        {
            if (txt.Text.Equals(""))
            {
                errorProviderContra.SetError(txt, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(txt.Text,
                            "^([A-Za-z0-9ñÑ]{8,15})$"))
            {
                errorProviderContra.SetError(txt, "");
                return true;
            }
            else
            {
                errorProviderContra.SetError(txt,
                    "La contraseña no tiene el formato correcto\n" +
                    "(De 8 a 15 caracteres. Solo letras sin tilde y números)");
                return false;
            }
        }

        private void TxtConfirmarContra_Validating(object sender, CancelEventArgs e)
        {
            validarConfirmarContra();
        }

        //Método para validar el campo de repetir contraseña
        private bool validarConfirmarContra()
        {
            if (TxtConfirmarContra.Text.Equals(""))
            {
                errorProviderContra.SetError(TxtConfirmarContra, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtNuevaContra.Text.Equals(TxtConfirmarContra.Text))
            {
                errorProviderContra.SetError(TxtConfirmarContra, "");
                return true;
            }
            else
            {
                errorProviderContra.SetError(TxtConfirmarContra, "La contraseña no es igual");
                return false;
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

        private void FrmCambiarContra_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
