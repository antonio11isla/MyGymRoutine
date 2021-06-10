using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGymRoutineAdministrar
{
    public class DiaRutina
    {
        private int dia;
        private ArrayList ejercicios = new ArrayList();

        public DiaRutina(int dia)
        {
            this.Dia = dia;
        }

        public DiaRutina(int dia, ArrayList ejercicios)
        {
            this.Dia = dia;
            this.Ejercicios = ejercicios;
        }

        public int Dia { get => dia; set => dia = value; }
        public ArrayList Ejercicios { get => ejercicios; set => ejercicios = value; }

        public void addEjercicio(Ejercicio e) 
        {
            ejercicios.Add(e);
        }
    }
}
