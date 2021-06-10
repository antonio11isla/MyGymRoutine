using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGymRoutineAdministrar
{
    public class Cliente
    {
        private int idCliente;
        private String nombre;
        private String apellidos;
        private String usuario;
        private String contrasena;
        private String correoElectronico;
        private String fechaNacimiento;
        private String telefono;
        private double peso;
        private double altura;
        private String frecuenciaDeporte;
        private String patologias;
        private int idEntrenador;
        private ArrayList rutinas = new ArrayList();

        public Cliente(int idCliente, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico, string fechaNacimiento, String telefono, double peso, double altura, string frecuenciaDeporte)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellidos = apellidos;
            IdCliente = idCliente;
            Nombre = nombre;
            Apellidos = apellidos;
            Usuario = usuario;
            Contrasena = contrasena;
            CorreoElectronico = correoElectronico;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Peso = peso;
            Altura = altura;
            FrecuenciaDeporte = frecuenciaDeporte;
        }

        public Cliente(int idCliente, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico, string fechaNacimiento, String telefono, double peso, double altura, string frecuenciaDeporte, int idEntrenador)
        {
            IdCliente = idCliente;
            Nombre = nombre;
            Apellidos = apellidos;
            IdCliente = idCliente;
            Nombre = nombre;
            Apellidos = apellidos;
            Usuario = usuario;
            Contrasena = contrasena;
            CorreoElectronico = correoElectronico;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Peso = peso;
            Altura = altura;
            FrecuenciaDeporte = frecuenciaDeporte;
            IdEntrenador = idEntrenador;
        }

        public Cliente(int idCliente, string nombre, string apellidos, string usuario, string contrasena, string correoElectronico, string fechaNacimiento, string telefono, double peso, double altura, string frecuenciaDeporte, string patologias, int idEntrenador)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.correoElectronico = correoElectronico;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.peso = peso;
            this.altura = altura;
            this.frecuenciaDeporte = frecuenciaDeporte;
            this.patologias = patologias;
            this.idEntrenador = idEntrenador;
        }

        public Cliente(int idCliente, string nombre, string apellidos, string fechaNacimiento, double peso, double altura, string frecuenciaDeporte, string patologias)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.altura = altura;
            this.frecuenciaDeporte = frecuenciaDeporte;
            this.patologias = patologias;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public String Telefono { get => telefono; set => telefono = value; }
        public int IdEntrenador { get => idEntrenador; set => idEntrenador = value; }
        public ArrayList Rutinas { get => rutinas; set => rutinas = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }
        public string FrecuenciaDeporte { get => frecuenciaDeporte; set => frecuenciaDeporte = value; }
        public string Patologias { get => patologias; set => patologias = value; }

        public void agregarRutina(Rutina r)
        {
            Rutinas.Add(r);
        }
    }
}
