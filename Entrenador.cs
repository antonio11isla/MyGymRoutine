using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGymRoutineAdministrar
{
    public class Entrenador : Personal
    {
        private ArrayList clientes = new ArrayList();

        public Entrenador(int idPersonal, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico, byte[] imagen, ArrayList clientes) : base(idPersonal, nombre, apellidos, usuario, contrasena, correoElectronico, imagen)
        {
            this.clientes = clientes;
        }

        public Entrenador(int idPersonal, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico, byte[] imagen) : base(idPersonal, nombre, apellidos, usuario, contrasena, correoElectronico, imagen)
        {
        }

        public Entrenador(int idPersonal, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico) : base(idPersonal, nombre, apellidos, usuario, contrasena, correoElectronico)
        {
        }

        public ArrayList Clientes { get => clientes; set => clientes = value; }

        public void agregarCliente(Cliente c) {
            Clientes.Add(c);
        }
    }
}
