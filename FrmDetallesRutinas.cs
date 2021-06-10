using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyGymRoutineAdministrar
{
    public partial class FrmDetallesRutinas : Form
    {
        MySqlConnection ctn;
        Rutina rutina = new Rutina(0, "", "", "", 0);
        ArrayList diasRutina = new ArrayList();
        ArrayList ejercicios = new ArrayList();
        ArrayList ejerciciosRutina = new ArrayList();
        int diaSeleccionado = 1;
        int idPersonal;
        int x, y;
        bool mover;


        public FrmDetallesRutinas(int idPersonal)
        {
            InitializeComponent();

            this.idPersonal = idPersonal;
            rutina.IdEntrenador = idPersonal;

            LsbEjerciciosRutina.AllowDrop = true;
            this.AllowDrop = true;

            BtnAnadir.Enabled = true;
            BtnAnadir.Visible = true;
            BtnModificar.Enabled = false;
            BtnModificar.Visible = false;

            if (idPersonal != 1)
                CmbTipoRutina.Text = "Personalizada";

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

        public FrmDetallesRutinas(Rutina rutina, int idPersonal)
        {
            InitializeComponent();

            this.rutina = rutina;
            this.idPersonal = idPersonal;

            LsbEjerciciosRutina.AllowDrop = true;
            this.AllowDrop = true;

            BtnAnadir.Enabled = false;
            BtnAnadir.Visible = false;
            BtnModificar.Enabled = true;
            BtnModificar.Visible = true;

            TxtNombreRutina.Text = rutina.Nombre;
            CmbTipoRutina.Text = rutina.TipoRutina;
            TxtDescripcion.Text = rutina.Descripcion;            

            ctn = new MySqlConnection("Server=servergym.ddns.net; Port=9091; Database=db_gimnasio; Uid=usuarioGym; Password=usuario_Gym_2021;");

            try
            {
                ctn.Open();

                //Descargamos los datos de la rutina a modificar
                String sql = "SELECT rutina.idRutina, rutina.nombre, rutina.descripcion, rutina.tipoRutina, rutina.idPersonal " +
                    "FROM rutina " +
                    "INNER JOIN rutinaEjercicio ON rutina.idRutina = rutinaEjercicio.idRutina " +
                    "WHERE rutina.idRutina = " + rutina.IdRutina;
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                //Introducimos los datos en los campos
                while (lector.Read())
                {
                    rutina = new Rutina(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), 
                        lector[3].ToString(), Int32.Parse(lector[4].ToString()));
                }
                lector.Close();

                //Descargamos los dias de la rutina a modificar
                String sql2 = "SELECT DISTINCT dia FROM rutinaEjercicio WHERE idRutina = " + rutina.IdRutina;
                MySqlCommand cmd2 = new MySqlCommand(sql2);
                cmd2.Connection = ctn;
                MySqlDataReader lector2 = cmd2.ExecuteReader();
                while (lector2.Read())
                {
                    DiaRutina dia = new DiaRutina(Int32.Parse(lector2[0].ToString()));
                    rutina.addDia(dia);
                }
                lector2.Close();

                CmbDiaEjercicios.Items.Clear();
                foreach (DiaRutina dia in rutina.Dias)
                {
                    CmbDiaEjercicios.Items.Add(dia.Dia);

                    //Descargamos los ejercicios de cada dia de la rutina a modificar
                    String sql3 = "SELECT ejercicio.idEjercicio, ejercicio.nombre, ejercicio.repeticiones, ejercicio.series, " +
                    "ejercicio.descanso, ejercicio.grupoMuscular, ejercicio.musculo, ejercicio.descripcion, ejercicio.imagen " +
                    "FROM rutinaEjercicio " +
                    "INNER JOIN ejercicio ON rutinaEjercicio.idEjercicio = ejercicio.idEjercicio " +
                    "WHERE rutinaEjercicio.dia = " + dia.Dia + " AND rutinaEjercicio.idRutina = " + rutina.IdRutina;
                    MySqlCommand cmd3 = new MySqlCommand(sql3);
                    cmd3.Connection = ctn;
                    MySqlDataReader lector3 = cmd3.ExecuteReader();
                    while (lector3.Read())
                    {
                        Byte[] imagen = null;
                        try
                        {
                            imagen = (byte[])lector[8];
                        }
                        catch { }

                        dia.addEjercicio(new Ejercicio(Int32.Parse(lector3[0].ToString()), lector3[1].ToString(), lector3[2].ToString(), Int32.Parse(lector3[3].ToString()),
                            lector3[4].ToString(), lector3[5].ToString(), lector3[6].ToString(), lector3[7].ToString(), imagen));
                    }
                    lector3.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }

            diasRutina = new ArrayList(rutina.Dias);

            try
            {
                //Rellenamos el comboBox con el número de días de la rutina
                DiaRutina dia1 = (DiaRutina)diasRutina[0];
                foreach (Ejercicio ejercicio in dia1.Ejercicios)
                {
                    ejerciciosRutina.Add(ejercicio);
                }

                CmbDiasRutina.Text = rutina.Dias.Count.ToString();
            }
            catch { }
        }

        private void FrmDetallesRutinas_Load(object sender, EventArgs e)
        {
            //El jefe únicamente puede crear rutinas no personalizadas
            //Puede editar las personalizadas hechas por los entrenadores pero estan siguen siendo personalizadas y creadas por ellos
            //Si es el jefe
            if (this.idPersonal == 1)
            {
                //Y la rutina es personalizada no puede cambiar el tipo
                if (rutina.TipoRutina.Equals("Personalizada"))
                {
                    CmbTipoRutina.Enabled = false;
                }
                else
                {
                    //Si la rutina no es personalizada puede elegir el tipo pero no personalizada

                    CmbTipoRutina.Items.Clear();
                    CmbTipoRutina.Items.Add("Básica");
                    CmbTipoRutina.Items.Add("Perder peso");
                    CmbTipoRutina.Items.Add("Ganar masa");
                    CmbTipoRutina.Items.Add("Definir");
                    CmbTipoRutina.Text = rutina.TipoRutina;
                }
            }

            mostrarEjercicios();
        }

        //Método que muestra todos los ejercicios para poder introducirlos en la rutina
        private void mostrarEjercicios()
        {
            try
            {
                LsbEjercicios.Items.Clear();
                ejercicios.Clear();
                String sql = "SELECT * FROM ejercicio";
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    Byte[] imagen = null;
                    try
                    {
                        imagen = (byte[])lector[8];
                    }
                    catch { }

                    LsbEjercicios.Items.Add(lector[1].ToString());
                    ejercicios.Add(new Ejercicio(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), Int32.Parse(lector[3].ToString()),
                        lector[4].ToString(), lector[5].ToString(), lector[6].ToString(), lector[7].ToString(), imagen));
                }
                lector.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que cambia el número de días que tiene la rutina
        private void CmbDiasRutina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList diasRutinaAux = new ArrayList(diasRutina);
            CmbDiaEjercicios.Text = "1";
            CmbDiaEjercicios.Items.Clear();
            diasRutina.Clear();
            for (int i = 1; i<=Int32.Parse(CmbDiasRutina.Text); i++)
            {
                CmbDiaEjercicios.Items.Add(i);
                try {
                    diasRutina.Add(diasRutinaAux[i - 1]);
                }
                catch
                {
                    DiaRutina diaAux = new DiaRutina(i);
                    diasRutina.Add(diaAux);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que muestra los ejercicios del día seleccionado y guarda los del anterior
        private void CmbDiaEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            diasRutina[diaSeleccionado - 1] = new DiaRutina(diaSeleccionado, new ArrayList(ejerciciosRutina));

            DiaRutina dia = (DiaRutina)diasRutina[Int32.Parse(CmbDiaEjercicios.Text) - 1]; 
            ejerciciosRutina.Clear();
            LsbEjerciciosRutina.Items.Clear();
            foreach (Ejercicio ejercicio in dia.Ejercicios)
            {
                ejerciciosRutina.Add(ejercicio);
                LsbEjerciciosRutina.Items.Add(ejercicio.Nombre);
            }
            diaSeleccionado = Int32.Parse(CmbDiaEjercicios.Text);
        }

        //Método que quita el ejercicio seleccionado de la rutina
        private void BtnQuitarEjerc_Click(object sender, EventArgs e)
        {
            if (LsbEjerciciosRutina.SelectedItems != null && LsbEjerciciosRutina.SelectedItems.Count > 0)
            {
                ejerciciosRutina.RemoveAt(LsbEjerciciosRutina.SelectedIndex);
                LsbEjerciciosRutina.Items.RemoveAt(LsbEjerciciosRutina.SelectedIndex);
            }
            else MessageBox.Show("Seleccione el ejercicio en el listado para eliminarlo", "Información");
        }

        //Método que introduce el ejercicio seleccionado en la rutina
        private void BtnMeterEjerc_Click(object sender, EventArgs e)
        {
            if (LsbEjercicios.SelectedItems != null && LsbEjercicios.SelectedItems.Count > 0)
            {
                Ejercicio ejercicio = (Ejercicio)ejercicios[LsbEjercicios.SelectedIndex];

                bool coincide = false;
                for (int i = 0; i < LsbEjerciciosRutina.Items.Count; i++)
                {
                    if (LsbEjerciciosRutina.Items[i].ToString().Equals(ejercicio.Nombre))
                    {
                        coincide = true;
                        break;
                    }
                }

                if (coincide == false)
                {
                    ejerciciosRutina.Add(ejercicio);
                    LsbEjerciciosRutina.Items.Add(ejercicio.Nombre);
                }
            }
            else MessageBox.Show("Seleccione un ejercicio en el listado para añadirlo", "Información");
        }


        //Método que crea una nueva rutina
        private void BtnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                //Válidamos la entrada de datos de los campos
                if (validarNombre() && validarCmb(CmbDiasRutina) && validarTipoRutina() && validarDescripcion() && validarCmb(CmbDiaEjercicios))
                {
                    //Para que se guarde el día actual
                    CmbDiaEjercicios.Text = "1";

                    //Insertamos los datos de la rutina
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO rutina (nombre, descripcion, tipoRutina, idPersonal)" +
                    " VALUES ('" + TxtNombreRutina.Text + "', '" + TxtDescripcion.Text + "', '" + CmbTipoRutina.Text + "', " + idPersonal + ")");
                    cmd.Connection = ctn;
                    cmd.ExecuteNonQuery();

                    //Comprobamos el id de la rutina creada para introducirle los ejercicios y el pdf posteriormente
                    String sql2 = "SELECT idRutina FROM rutina WHERE nombre = '" + TxtNombreRutina.Text + "'";
                    MySqlCommand cmd2 = new MySqlCommand(sql2);
                    cmd2.Connection = ctn;
                    MySqlDataReader lector2 = cmd2.ExecuteReader();
                    while (lector2.Read())
                    {
                        rutina.IdRutina = Int32.Parse(lector2[0].ToString());
                    }
                    lector2.Close();

                    //Recorremos los días de la rutina
                    foreach (DiaRutina dia in diasRutina)
                    {
                        foreach (Ejercicio ejercicio in dia.Ejercicios)
                        {
                            //introducimos los ejercicios en cada día de la rutina
                            MySqlCommand cmd3 = new MySqlCommand("INSERT INTO rutinaEjercicio (idRutina, dia, idEjercicio)" +
                                " VALUES (" + rutina.IdRutina + ", " + dia.Dia + ", " + ejercicio.IdEjercicio + ")");
                            cmd3.Connection = ctn;
                            cmd3.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Se ha añadido correctamente la rutina", "Información");

                    //Creamos el pdf de la rutina
                    MemoryStream ms = new MemoryStream();
                    Document doc = generarRutinaPDF();
                    PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                    byte[] pdf = ms.ToArray();

                    //Introducimos el pdf en la rutina
                    MySqlCommand cmd4 = new MySqlCommand("UPDATE rutina SET archivo = @archivo " + "WHERE idRutina = " + rutina.IdRutina);
                    cmd4.Parameters.AddWithValue("archivo", pdf);
                    cmd4.Connection = ctn;
                    cmd4.ExecuteNonQuery();

                    this.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que modificia una rutina
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Válidamos la entrada de datos de los campos
                if (validarNombre() && validarCmb(CmbDiasRutina) && validarTipoRutina() && validarDescripcion() && validarCmb(CmbDiaEjercicios))
                {
                    //Para que se guarde el día actual
                    CmbDiaEjercicios.Text = "1";

                    if (CmbDiaEjercicios.Items.Count > 0)
                    {
                        MySqlCommand cmd2 = new MySqlCommand("DELETE FROM rutinaEjercicio WHERE idRutina = " + rutina.IdRutina);
                        cmd2.Connection = ctn;
                        cmd2.ExecuteNonQuery();

                        DiaRutina diaAux = new DiaRutina(diaSeleccionado, new ArrayList(ejerciciosRutina));
                        diasRutina[diaSeleccionado - 1] = diaAux;
                        DiaRutina diaAux2 = (DiaRutina)diasRutina[Int32.Parse(CmbDiaEjercicios.Text) - 1];
                        ejerciciosRutina.Clear();
                        foreach (Ejercicio ejercicio in diaAux.Ejercicios)
                        {
                            ejerciciosRutina.Add(ejercicio);
                        }

                        foreach (DiaRutina dia in diasRutina)
                        {
                            foreach (Ejercicio ejercicio in dia.Ejercicios)
                            {
                                MySqlCommand cmd3 = new MySqlCommand("INSERT INTO rutinaEjercicio (idRutina, dia, idEjercicio)" +
                                    " VALUES (" + rutina.IdRutina + ", " + dia.Dia + ", " + ejercicio.IdEjercicio + ")");
                                cmd3.Connection = ctn;
                                cmd3.ExecuteNonQuery();
                            }
                        }

                        //Creamos el nuevo pdf de la rutina
                        MemoryStream ms = new MemoryStream();
                        Document doc = generarRutinaPDF();
                        PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                        byte[] pdf = ms.ToArray();

                        //Actualizamos los datos de la rutina
                        MySqlCommand cmd = new MySqlCommand("UPDATE rutina SET nombre = '" + TxtNombreRutina.Text + "', descripcion = '" 
                            + TxtDescripcion.Text + "', tipoRutina = '" + CmbTipoRutina.Text + "', archivo = @archivo " +
                            "WHERE idRutina = " + rutina.IdRutina);
                        cmd.Parameters.AddWithValue("archivo", pdf);
                        cmd.Connection = ctn;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se ha modificado correctamente la rutina", "Información");
                    }
                    else
                        MessageBox.Show("La rutina no tiene asignado ningún día de ejercicios", "Error");

                    this.Close();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos.", "Error");
            }
        }

        //Método que crea el PFD de las rutinas
        private Document generarRutinaPDF()
        {
            try
            {
                //Obtenemos el nombre del creador de la rutina
                String entrenador = "";
                String sql = "SELECT nombre, apellidos FROM personal WHERE idPersonal = " + rutina.IdEntrenador;
                MySqlCommand cmd = new MySqlCommand(sql);
                cmd.Connection = ctn;
                MySqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    entrenador = lector[0].ToString() + " " + lector[1].ToString();
                }
                lector.Close();

                //Creamos el documento
                Document doc = new Document(PageSize.LETTER);
                //Indicamos donde vamos a guardar el documento
                //Si se va a crear un PDF que va a sustituir a otro cerrar antes ese otro o no se cerará el nuevo, excepción controlada
                PdfWriter writer = PdfWriter.GetInstance(doc,
                                            new FileStream("..\\..\\rutinas\\" + rutina.Nombre + ".pdf", FileMode.Create));

                // Le colocamos el título y el autor
                //**Nota: Esto no será visible en el documento
                doc.AddTitle("Rutina");
                doc.AddCreator(rutina.IdEntrenador.ToString());

                //Abrimos el archivo
                doc.Open();

                //Creamos los diferenentes tipos de fuente
                iTextSharp.text.Font fuenteEstandar = new iTextSharp.text.Font(
                    iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font fuenteTitulo = new iTextSharp.text.Font(
                    iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font fuenteSubtitulo = new iTextSharp.text.Font(
                    iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                iTextSharp.text.Font fuenteDia = new iTextSharp.text.Font(
                    iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //Escribimos el encabezamiento en el documento
                doc.Add(new Paragraph("Rutina: " + TxtNombreRutina.Text, fuenteTitulo));
                doc.Add(new Paragraph("Tipo: " + CmbTipoRutina.Text, fuenteSubtitulo));
                doc.Add(new Paragraph("Entrenador: " + entrenador, fuenteSubtitulo));

                doc.Add(Chunk.NEWLINE);

                //Creamos una tabla por día que contendrá los ejercicios de ese día de la rutina 
                foreach (DiaRutina dia in diasRutina)
                {
                    doc.Add(new Phrase("Dia " + dia.Dia, fuenteDia));

                    PdfPTable tblDia = new PdfPTable(5);
                    tblDia.WidthPercentage = 100;
                    //proporcion relativa - 1.5/10, 4.6/10, 1.3/10, 1.3/10 y 1.3/10
                    float[] widths = new float[] { 2.0f, 4.6f, 0.8f, 1.3f, 1.3f };
                    tblDia.SetWidths(widths);
                    tblDia.HorizontalAlignment = 0;

                    // Configuramos el título de las columnas de la tabla
                    PdfPCell clMusculo = new PdfPCell(new Phrase("Musculo", fuenteEstandar));
                    clMusculo.BorderWidth = 0;
                    clMusculo.BorderWidthBottom = 0.75f;
                    clMusculo.Padding = 3f;

                    PdfPCell clNombre = new PdfPCell(new Phrase("Ejercicio", fuenteEstandar));
                    clNombre.BorderWidth = 0;
                    clNombre.BorderWidthBottom = 0.75f;
                    clNombre.Padding = 3f;

                    PdfPCell clSeries = new PdfPCell(new Phrase("Series", fuenteEstandar));
                    clSeries.BorderWidth = 0;
                    clSeries.BorderWidthBottom = 0.75f;
                    clSeries.Padding = 3f;

                    PdfPCell clRepeticiones = new PdfPCell(new Phrase("Repeticiones", fuenteEstandar));
                    clRepeticiones.BorderWidth = 0;
                    clRepeticiones.BorderWidthBottom = 0.75f;
                    clRepeticiones.Padding = 3f;

                    PdfPCell clDescanso = new PdfPCell(new Phrase("Descanso", fuenteEstandar));
                    clDescanso.BorderWidth = 0;
                    clDescanso.BorderWidthBottom = 0.75f;
                    clDescanso.Padding = 3f;

                    // Añadimos las celdas a la tabla
                    tblDia.AddCell(clMusculo);
                    tblDia.AddCell(clNombre);
                    tblDia.AddCell(clSeries);
                    tblDia.AddCell(clRepeticiones);
                    tblDia.AddCell(clDescanso);

                    // Llenamos la tabla con los ejercicios de ese día
                    foreach (Ejercicio ejercicio in dia.Ejercicios)
                    {
                        clMusculo = new PdfPCell(new Phrase(ejercicio.Musculo, fuenteEstandar));
                        clMusculo.BorderWidth = 0;
                        clMusculo.Padding = 3f;

                        clNombre = new PdfPCell(new Phrase(ejercicio.Nombre, fuenteEstandar));
                        clNombre.BorderWidth = 0;
                        clNombre.Padding = 3f;

                        clSeries = new PdfPCell(new Phrase(ejercicio.Series.ToString(), fuenteEstandar));
                        clSeries.BorderWidth = 0;
                        clSeries.Padding = 3f;

                        clRepeticiones = new PdfPCell(new Phrase(ejercicio.Repeticiones, fuenteEstandar));
                        clRepeticiones.BorderWidth = 0;
                        clRepeticiones.Padding = 3f;

                        clDescanso = new PdfPCell(new Phrase(ejercicio.Descanso, fuenteEstandar));
                        clDescanso.BorderWidth = 0;
                        clDescanso.Padding = 3f;

                        // Añadimos las celdas a la tabla
                        tblDia.AddCell(clMusculo);
                        tblDia.AddCell(clNombre);
                        tblDia.AddCell(clSeries);
                        tblDia.AddCell(clRepeticiones);
                        tblDia.AddCell(clDescanso);
                    }

                    doc.Add(tblDia);
                    doc.Add(Chunk.NEWLINE);
                }

                doc.Close();
                writer.Close();

                return doc;
            }
            catch
            {
                MessageBox.Show("No se ha podido crear el PDF de la rutina.", "Error");
                Document doc = new Document();
                return doc;
            }
        }

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

        private void BtnFiltrarEjerc_Click(object sender, EventArgs e)
        {
            if (comprobarFiltroTxt(TxtFiltroEjerc) && comprobarFiltroCmb(CmbFiltroEjerc)) 
            {
                String sql = "";
                switch (CmbFiltroEjerc.Text)
                {
                    case "Nombre":
                        sql = "SELECT * FROM ejercicio WHERE nombre LIKE '%" + TxtFiltroEjerc.Text + "%'";
                        break;
                    case "Grupos musculares":
                        sql = "SELECT * FROM ejercicio WHERE grupoMuscular LIKE '%" + TxtFiltroEjerc.Text + "%'";
                        break;
                    case "Músculo":
                        sql = "SELECT * FROM ejercicio WHERE musculo LIKE '%" + TxtFiltroEjerc.Text + "%'";
                        break;
                }
                try
                {
                    LsbEjercicios.Items.Clear();
                    ejercicios.Clear();
                    MySqlCommand cmd = new MySqlCommand(sql);
                    cmd.Connection = ctn;
                    MySqlDataReader lector = cmd.ExecuteReader();
                    while (lector.Read())
                    {
                        Byte[] imagen = null;
                        try
                        {
                            imagen = (byte[])lector[8];
                        }
                        catch { }

                        LsbEjercicios.Items.Add(lector[1].ToString());
                        ejercicios.Add(new Ejercicio(Int32.Parse(lector[0].ToString()), lector[1].ToString(), lector[2].ToString(), Int32.Parse(lector[3].ToString()),
                        lector[4].ToString(), lector[5].ToString(), lector[6].ToString(), lector[7].ToString(), imagen));
                    }
                    lector.Close();
                }
                catch (System.InvalidOperationException)
                {
                    MessageBox.Show("Filtro incorrecto", "Error");
                    mostrarEjercicios();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {

                }
            }
        }

        private void BtnMostrarEjerc_Click(object sender, EventArgs e)
        {
            mostrarEjercicios();
        }

        private void TxtNombreRutina_Validating(object sender, CancelEventArgs e)
        {
            validarNombre();
        }

        //Método que valida el campo de nombre y devuelvo true or false en función si es correcto o no
        private bool validarNombre()
        {
            if (TxtNombreRutina.Text.Equals(""))
            {
                errorProviderDetallesRutina.SetError(TxtNombreRutina, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtNombreRutina.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtNombreRutina.Text.Length > 45)
            {
                errorProviderDetallesRutina.SetError(TxtNombreRutina,
                    "El nombre tiene algún caracter que no es válido\n" +
                    "45 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                if (TxtNombreRutina.Text.Equals(rutina.Nombre))
                {
                    errorProviderDetallesRutina.SetError(TxtNombreRutina, "");
                    return true;
                }
                else
                {
                    try
                    {
                        String sql = "SELECT nombre FROM rutina WHERE nombre = '" + TxtNombreRutina.Text + "'";
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
                            errorProviderDetallesRutina.SetError(TxtNombreRutina, "El nombre ya esá en uso");
                            return false;
                        }
                        else
                        {
                            errorProviderDetallesRutina.SetError(TxtNombreRutina, "");
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
        }

        //Método que valida el campo de descripción y devuelvo true or false en función si es correcto o no
        private void TxtDescripcion_Validating(object sender, CancelEventArgs e)
        {
            validarDescripcion();
        }

        private bool validarDescripcion()
        {
            if (TxtDescripcion.Text.Equals(""))
            {
                errorProviderDetallesRutina.SetError(TxtDescripcion, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(TxtDescripcion.Text,
                            "([¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{}])") || TxtDescripcion.Text.Length > 400)
            {
                errorProviderDetallesRutina.SetError(TxtDescripcion,
                    "El nombre tiene algún caracter que no es válido\n" +
                    "400 caractéres como máximo\n" +
                    "(¡!¿?|@#·$~%€&¬=*'`´\"<>_¨{})");
                return false;
            }
            else
            {
                errorProviderDetallesRutina.SetError(TxtDescripcion, "");
                return true;
            }
        }

        private void CmbTipoRutina_Validating(object sender, CancelEventArgs e)
        {
            validarTipoRutina();
        }

        //Método que valida el campo de tipoRutina y devuelvo true or false en función si es correcto o no
        private bool validarTipoRutina() 
        {
            if (CmbTipoRutina.Text.Equals(""))
            {
                errorProviderDetallesRutina.SetError(CmbTipoRutina, "El campo no puede quedar vacio");
                return false;
            }
            else if (CmbTipoRutina.Text.Equals("Personalizada") || CmbTipoRutina.Text.Equals("Básica") ||
                CmbTipoRutina.Text.Equals("Perder peso") || CmbTipoRutina.Text.Equals("Ganar masa") ||
                CmbTipoRutina.Text.Equals("Definir"))
            {
                errorProviderDetallesRutina.SetError(CmbTipoRutina, "");
                return true;
            }
            else
            {
                errorProviderDetallesRutina.SetError(CmbTipoRutina, "El campo tiene un valor incorrecto");
                return false;
            }
        }

        private void CmbDiasRutina_Validating(object sender, CancelEventArgs e)
        {
            validarCmb(CmbDiasRutina);
        }

        private void CmbDiaEjercicios_Validating(object sender, CancelEventArgs e)
        {
            validarCmb(CmbDiaEjercicios);
        }

        //Método que valida un comboBox y devuelvo true or false en función si es correcto o no
        private bool validarCmb(ComboBox Cmb)
        {
            if (Cmb.Text.Equals(""))
            {
                errorProviderDetallesRutina.SetError(Cmb, "El campo no puede quedar vacio");
                return false;
            }
            else if (Regex.IsMatch(Cmb.Text,
                            "^([1-" + CmbDiasRutina.Text + "]{1,1})$"))
            {
                errorProviderDetallesRutina.SetError(Cmb, "");
                return true;
            }
            else
            {
                errorProviderDetallesRutina.SetError(Cmb,
                    "El número no es correcto o tiene algún carácter no válido");

                return false;
            }
        }

        //Método para hacer Drag de un ejercicio en el listado de ejercicios
        private void LsbEjercicios_MouseDown(object sender, MouseEventArgs e)
        {
            if (LsbEjercicios.SelectedItems != null && LsbEjercicios.SelectedItems.Count > 0)
            {
                if (e.Button == MouseButtons.Left)
                {
                    DragDropEffects res = this.LsbEjercicios.DoDragDrop(this.LsbEjercicios.SelectedItem, DragDropEffects.Move);
                }
            }
        }

        //Método para hacer Drag de un ejercicio en el listado de ejercicios del día seleccionado de la rutina
        private void LsbEjerciciosRutina_MouseDown(object sender, MouseEventArgs e)
        {
            if (LsbEjerciciosRutina.SelectedItems != null && LsbEjerciciosRutina.SelectedItems.Count > 0)
            {
                DragDropEffects res = this.LsbEjerciciosRutina.DoDragDrop(this.LsbEjerciciosRutina.SelectedItem, DragDropEffects.Move);
                if (res == DragDropEffects.Move)
                {
                    ejerciciosRutina.RemoveAt(LsbEjerciciosRutina.SelectedIndex);
                    LsbEjerciciosRutina.Items.RemoveAt(LsbEjerciciosRutina.SelectedIndex);
                }
            }

        }

        //Método que permite hacer Drop en el formulario para así borrar el Drag
        private void FrmDetallesRutinas_DragOver(object sender, DragEventArgs e)
        {
            //e.Effect = DragDropEffects.None; para que no deje soltar en el resto del formulario
            e.Effect = DragDropEffects.Move;
        }

        //Método para hacer Drop en el listado de ejercicios del día seleccionado de la rutina
        private void LsbEjerciciosRutina_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Ejercicio ejercicio = (Ejercicio)ejercicios[LsbEjercicios.SelectedIndex];

                //Comprobamos que el ejercicio no esté ya
                bool coincide = false;
                for (int i = 0; i < LsbEjerciciosRutina.Items.Count; i++)
                {
                    if (LsbEjerciciosRutina.Items[i].ToString().Equals(ejercicio.Nombre))
                    {
                        coincide = true;
                        break;
                    }
                }

                //Si no está ya el ejercicio lo añadimos
                if (coincide == false)
                {
                    ejerciciosRutina.Add(ejercicio);
                    LsbEjerciciosRutina.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
                }
            }
            catch { }
        }

        //Método que permite hacer Drop en el comboBox de ejerciciosRutina
        private void LsbEjerciciosRutina_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
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

        private void FrmDetallesRutinas_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctn.Close();
        }
    }
}
