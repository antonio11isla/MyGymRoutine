using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGymRoutineAdministrar
{
    public class Rutina
    {
        private int idRutina;
        private String nombre;
        private String descripcion;
        private String tipoRutina;
        private byte[] archivoRuta;
        private int idEntrenador;
        private ArrayList clientes = new ArrayList();
        private ArrayList dias = new ArrayList();

        public Rutina(int idRutina, string nombre, string descripcion, string tipoRutina, int idEntrenador)
        {
            this.idRutina = idRutina;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipoRutina = tipoRutina;
            this.idEntrenador = idEntrenador;
        }

        public Rutina(int idRutina, string nombre, string descripcion, string tipoRutina, byte[] archivoRuta, int idEntrenador)
        {
            this.idRutina = idRutina;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.tipoRutina = tipoRutina;
            this.archivoRuta = archivoRuta;
            this.idEntrenador = idEntrenador;
        }

        public int IdRutina { get => idRutina; set => idRutina = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string TipoRutina { get => tipoRutina; set => tipoRutina = value; }
        public byte[] ArchivoRuta { get => archivoRuta; set => archivoRuta = value; }
        public int IdEntrenador { get => idEntrenador; set => idEntrenador = value; }
        public ArrayList Clientes { get => clientes; set => clientes = value; }
        public ArrayList Dias { get => dias; set => dias = value; }

        public void addCliente(Cliente c)
        {
            Clientes.Add(c);
        }

        public void addDia(DiaRutina d)
        {
            Dias.Add(d);
        }
    }
}
