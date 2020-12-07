using System;
using System.Collections.Generic;
using System.Text;

namespace Alumnos
{
    class cprofesor
    {
        //Atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public decimal Sueldo { get; set; }
        public string Documento { get; set; }



        //Constructor Completo sin parametros y pedido de datos por consola
        public cprofesor()
        {
            Console.WriteLine("Ingrese el nombre del Profesor: ");
            this.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del Profesor: ");
            this.Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el correo electronico: ");
            this.Mail = Console.ReadLine();

            Console.WriteLine("Ingrese el Telefono de contacto: ");
            this.Telefono = Console.ReadLine();

            Console.WriteLine("Ingrese el valor del sueldo: ");
            this.Sueldo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el DNI: ");
            this.Documento = Console.ReadLine();
     
        }

        //Constructor Acotado con parametros por el problema principal
        public cprofesor(string nombre, string apellido, string documento, decimal sueldo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Documento = documento;
            this.Sueldo = sueldo;
        }

        //Constructor Completo Mostrar datos
        public string MostrarDatosProfesor()
        {
            Console.WriteLine(" --------------Mostrar Datos de Profesor----------------");
            string mostrar = "Nombre de Profesor: " + Nombre + Environment.NewLine;
            mostrar += "Apellido de Profesor: " + Apellido + Environment.NewLine;
            mostrar += "Email del Profesor: " + Mail + Environment.NewLine;
            mostrar += "Tel. del Profesor: " + Telefono + Environment.NewLine;
            mostrar += "Sueldo del Profesor: " + Sueldo + Environment.NewLine;
            mostrar += "DNI del Profesor: " + Documento + Environment.NewLine;

            return mostrar;

        }

        public string MostrarDatosProfesor2()
        {
            Console.WriteLine("Los datos del Profesor: ");
            string valordevoler = Environment.NewLine + "Nombre del profesor: " + Nombre + Environment.NewLine;
            valordevoler += "Apellido de Profesor: " + Apellido + Environment.NewLine;
            valordevoler += "Documento del Profesor: " + Documento + Environment.NewLine;

            return valordevoler;
        }

        //Aumentar sueldo
        public void AumentarSuelo(decimal nuevosueldo)
        {
            this.Sueldo += nuevosueldo;
        }
    }

}
