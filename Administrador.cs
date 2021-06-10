using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGymRoutineAdministrar
{
    public class Administrador : Personal
    {
        public Administrador(int idPersonal, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico, byte[] imagen) : base(idPersonal, nombre, apellidos, usuario, contrasena, correoElectronico, imagen)
        {
        }

        public Administrador(int idPersonal, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico) : base(idPersonal, nombre, apellidos, usuario, contrasena, correoElectronico)
        {
        }
    }
}
