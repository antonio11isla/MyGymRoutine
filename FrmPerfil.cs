using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyGymRoutineAdministrar
{
    public partial class FrmPerfil : Form
    {
        Personal personal;
        MySqlConnection ctn;
        int x, y;
        bool mover;

        public FrmPerfil(Administrador administrador)
        {
            InitializeComponent();
            this.personal = administrador;
        }

        public FrmPerfil(Entrenador entrenador)
        {
            InitializeComponent();
            this.personal = entrenador;
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            ctn = new MySqlConnection("Server=servergym.ddns.net; Port=9091; Database=db_gimnasio; Uid=usuarioGym; Password=usuario_Gym_2021;");
            try
            {
                ctn.Open();
                try
                {
                    //Cargamos los datos del usuario en los campos de texto y sacamos la imagen
                    String sql = "SELECT nombre, apellidos, usuario, correoElectronico, imagen FROM personal where idPersonal = " + personal.IdPersonal;
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        LblNombreCompleto.Text = lector[0].ToString() + " " + lector[1].ToString();
                        TxtNombre.Text = lector[0].ToString();
                        TxtApellidos.Text = lector[1].ToString();
                        TxtUsuario.Text = lector[2].ToString();
                        TxtCorreoElectronico.Text = lector[3].ToString();
                        try
                        {
                            MemoryStream ms = new MemoryStream((byte[])lector[4]);
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
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPerfil_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctn.Close();
        }

        //Método para cambiar la contreaseña desde otro formlario
        private void BtnCambiarContrasena_Click(object sender, EventArgs e)
        {
            FrmCambiarContra frm = new FrmCambiarContra(personal);
            frm.ShowDialog();
        }

        //Método que cambia los datos del usuario
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Comprobamos que todos los campos estén correctos
                if (validarNombre() && validarApellidos() && validarCorreo() && validarUsuario())
                {
                    //Convertimos la imagen en un arrray de bytes
                    MemoryStream ms = new MemoryStream();
                    PcbImagen.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] imagen = ms.ToArray(); 

                    //Actualizamos el personal
                    MySqlCommand cmd = new MySqlCommand("UPDATE personal SET nombre = '" + TxtNombre.Text +
                    "', apellidos = '" + TxtApellidos.Text + "', usuario = '" + TxtUsuario.Text +
                    "', correoElectronico = '" + TxtCorreoElectronico.Text + "', imagen = @imagen " +
                    "WHERE idPersonal = " + personal.IdPersonal);
                    cmd.Parameters.AddWithValue("imagen", imagen);
                    cmd.Connection = ctn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se modificado han correctamente los datos");
                    LblNombreCompleto.Text = TxtNombre.Text + " " + TxtApellidos.Text;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            validarNombre();
        }

        //Método que valida la entrada de datos del campo nombre
        private bool validarNombre()
        {
            if (TxtNombre.Text.Equals(""))
            {
                errorProviderPerfil.SetError(TxtNombre, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtNombre.Text,
                            "(^[A-ZÁÉÍÓÚ]{1}([a-zñáéíóú]+){2,})(\\s[A-ZÁÉÍÓÚ]{1}([a-zñáéíóú]+){2,})?$"))
            {
                errorProviderPerfil.SetError(TxtNombre, "");
                return true;
            }
            else
            {
                errorProviderPerfil.SetError(TxtNombre, "El nombre no tiene el formato correcto");
                return false;
            }
        }
        
        private void TxtApellidos_Validating(object sender, CancelEventArgs e)
        {
            validarApellidos();
        }

        //Método que valida la entrada de datos del campo apellidos
        private bool validarApellidos()
        {
            if (TxtApellidos.Text.Equals(""))
            {
                errorProviderPerfil.SetError(TxtApellidos, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtApellidos.Text,
                            "(^[A-ZÁÉÍÓÚ]{1}([a-zñáéíóú]+){2,})(\\s[A-ZÁÉÍÓÚ]{1}([a-zñáéíóú]+){2,})?$"))
            {
                errorProviderPerfil.SetError(TxtApellidos, "");
                return true;
            }
            else
            {
                errorProviderPerfil.SetError(TxtApellidos, "El apellido no tiene el formato correcto");
                return false;
            }
        }

        private void TxtUsuario_Validating(object sender, CancelEventArgs e)
        {
            validarUsuario();
        }

        //Método que valida la entrada de datos del campo usuario
        private bool validarUsuario()
        {
            if (TxtUsuario.Text.Equals(""))
            {
                errorProviderPerfil.SetError(TxtUsuario, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtUsuario.Text.Equals(personal.Usuario))
            {
                errorProviderPerfil.SetError(TxtUsuario, "");
                return true;
            }
            else
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
                        errorProviderPerfil.SetError(TxtUsuario, "El usuario ya esá en uso");
                        return false;
                    }
                    else if (Regex.IsMatch(TxtUsuario.Text,
                            "^([A-Za-z0-9ñÑ_]{8,15})$"))
                    {
                        errorProviderPerfil.SetError(TxtUsuario, "");
                        return true;
                    }
                    else
                    {
                        errorProviderPerfil.SetError(TxtUsuario,
                            "El usuario no tiene el formato correcto\n" +
                            "(De 8 a 15 caracteres. Solo letras sin tilde, números y _)");
                        return false;
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    return false;
                }
            }
        }

        private void TxtCorreoElectronico_Validating(object sender, CancelEventArgs e)
        {
            validarCorreo();
        }

        //Método que valida la entrada de datos del campo correo
        private bool validarCorreo()
        {
            if (TxtCorreoElectronico.Text.Equals(""))
            {
                errorProviderPerfil.SetError(TxtCorreoElectronico, "El campo no puede quedar vacio");
                return false;
            }
            else if (TxtCorreoElectronico.Text.Equals(personal.CorreoElectronico))
            {
                errorProviderPerfil.SetError(TxtCorreoElectronico, "");
                return true;
            }
            else
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
                        errorProviderPerfil.SetError(TxtCorreoElectronico, "El correo electrónico ya esá en uso");
                        return false;
                    }
                    else
                    {
                        if (Regex.IsMatch(TxtCorreoElectronico.Text,
                            "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$"))
                        {
                            errorProviderPerfil.SetError(TxtCorreoElectronico, "");
                            return true;
                        }
                        else
                        {
                            errorProviderPerfil.SetError(TxtCorreoElectronico, "El correo electrónico no tiene el formato correcto");
                            return false;
                        }
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
                    return false;
                }
            }
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmPerfil_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            x = e.X;
            y = e.Y;
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmPerfil_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        //Método para mover el formulario desde el borde personalizado
        private void FrmPerfil_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover == true)
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        //Método que permite seleccionar una imagen de perfil y la introduce en el pictureBox
        private void PcbImagen_Click(object sender, EventArgs e)
        {
            openFileDialogPerfil.Title = "Seleccione la foto de perfil";
            openFileDialogPerfil.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";

            if (openFileDialogPerfil.ShowDialog() == DialogResult.OK)
                if (File.Exists(openFileDialogPerfil.FileName))
                {
                    PcbImagen.Image = Image.FromFile(openFileDialogPerfil.FileName);
                }
        }
    }
}
