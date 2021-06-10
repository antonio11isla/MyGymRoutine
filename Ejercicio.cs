using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGymRoutineAdministrar
{
    public class Ejercicio
    {
        private int idEjercicio;
        private String nombre;
        private String repeticiones;
        private int series;
        private String descanso;
        private String grupoMuscular;
        private String musculo;
        private String descripcion;
        private Byte[] imagen;

        public Ejercicio(int idEjercicio, string nombre, string repeticiones, int series, string descanso, 
            string grupoMuscular, string musculo, string descripcion, byte[] imagen)
        {
            this.idEjercicio = idEjercicio;
            this.nombre = nombre;
            this.repeticiones = repeticiones;
            this.series = series;
            this.descanso = descanso;
            this.grupoMuscular = grupoMuscular;
            this.musculo = musculo;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

        public int IdEjercicio { get => idEjercicio; set => idEjercicio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Repeticiones { get => repeticiones; set => repeticiones = value; }
        public int Series { get => series; set => series = value; }
        public string Descanso { get => descanso; set => descanso = value; }
        public string GrupoMuscular { get => grupoMuscular; set => grupoMuscular = value; }
        public string Musculo { get => musculo; set => musculo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
    }
}
