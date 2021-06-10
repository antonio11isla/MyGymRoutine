using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGymRoutineAdministrar
{
    public class Personal
    {
        private int idPersonal;
        private String nombre;
        private String apellidos;
        private String usuario;
        private String contrasena;
        private String correoElectronico;
        private byte[] imagen;

        public Personal(int idPersonal, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico)
        {
            this.idPersonal = idPersonal;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.correoElectronico = correoElectronico;
        }

        public Personal(int idPersonal, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico, byte[] imagen)
        {
            this.idPersonal = idPersonal;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.correoElectronico = correoElectronico;
            this.imagen = imagen;
        }

        public int IdPersonal { get => idPersonal; set => idPersonal = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}
