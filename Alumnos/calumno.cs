using System;
using System.Collections.Generic;
using System.Text;

namespace Alumnos
{
    class calumno
    {
        //Atributos
        //Short: prop tab tab
        public string Nombre { get; set; } //Permiso de lectura Get y escritura set.
        public string Apellido { get; set; }
        private string Documento { get; set; }
        public int Legajo { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public decimal Cuota { get; set; }
        private DateTime Fechaalta { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        private bool Cuotaaldia { get; set; }


        //Constructor
        public calumno()
        {

            Console.WriteLine("Ingrese el nombre del alumno: ");
            this.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del alumno: ");
            this.Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el Documento: ");
            this.Documento = Console.ReadLine();

            Console.WriteLine("Ingrese el Numero de Legajo: ");
            this.Legajo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese la Fecha de Nacimiento: ");
            this.Fechanacimiento = new DateTime(1980, 06, 12);

            Console.WriteLine("Ingrese el valor de la cuota:");
            this.Cuota = decimal.Parse(Console.ReadLine());

            this.Fechaalta = DateTime.Now; //Fecha actual del sistema

            Console.WriteLine("Ingrese el Tel. del Alumno: ");
            this.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el correo electronico: ");
            this.Mail = Console.ReadLine();

            this.Cuotaaldia = true;

        }



        //Polimorfismo / Metodos
        public calumno(string nombre, string apellido, string documento, DateTime fechanacimiento)
        {

            this.Nombre = nombre;

            this.Apellido = apellido;

            this.Documento = documento;

            this.Fechanacimiento = fechanacimiento;

        }

              
        public string MostrarDatos()
        {
            Console.WriteLine(" --------------Mostrar Datos del Alumno----------------");
            Console.WriteLine("Los datos ingresados del alumno son: ");
            string valordevolver = "Nombre del Alumno: " + Nombre + Environment.NewLine;
            valordevolver += "Apellido del Alumno: " + Apellido + Environment.NewLine;
            valordevolver += "DNI del Alumno: " + Documento + Environment.NewLine;
            valordevolver += "Legajo del Alumno: " + Legajo + Environment.NewLine;
            valordevolver += "Fecha de Nacimiento del Alumno: " + Fechanacimiento.ToString("MM/dd/yyyy") + Environment.NewLine;
            valordevolver += "Valor de la cuota del Alumno: " + Cuota + Environment.NewLine;
            valordevolver += "Fecha de Alta del Alumno: " + Fechaalta.ToString() + Environment.NewLine;
            valordevolver += "Tel. del Alumno: " + Telefono + Environment.NewLine;
            valordevolver += "Mail del Alumno: " + Mail + Environment.NewLine;
            valordevolver += "Cuota al Dia:" + Cuotaaldia + Environment.NewLine;

            return valordevolver;

        }

        //Constructor Aumentar cuota
        public void AumentarCuota(decimal aumento)
        {
            this.Cuota += aumento;
        }


        //Constructor Validar edad
        public bool ValidarEdad(int edad)
        {
            //Obtener la fecha de hoy
            DateTime fechahoy = DateTime.Now;
            //Restar el año de la fecha de hoy menos, el año de la fecha de nacimiento.
            int anio = fechahoy.Year - Fechanacimiento.Year;

            if (edad == anio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
