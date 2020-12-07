using System;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio => Se crea el objeto Alumno.
            //Nuevo alumno con el primer alumno utilizando el constructor por default.
            calumno alumno = new calumno(); //El crear el objeto se llama al constructor => no hace falta invocarlo.
            Console.WriteLine(alumno.MostrarDatos());

            //Se llama al constructor Aumentar cuota.
            alumno.AumentarCuota(650);
            //Se muestra el nuevo valor de la cuota.
            Console.WriteLine("El nuevo valor de la cuota es: {0}",alumno.Cuota);
            Console.WriteLine(" ");

            //Se llama al constructor Validar edad.
            bool edad = false;
            edad= alumno.ValidarEdad(40);
            Console.WriteLine("La validacion de la edad del alumno devolvio: {0}", edad);
                

            //Nuevo alumno con un 2do alumno utilizando otro constructor => Polimorfismo.
            calumno alumno2 = new calumno("Pedro","Perez","24856958", new DateTime(1980,01,25)) ;
            Console.WriteLine(alumno2.MostrarDatos());

            //Instancio => Se crea el objeto Profesor.
            cprofesor profesor = new cprofesor("Mariano", "Perez", "20458541",1500m);
           // profesor.Sueldo = 1500m;
            Console.WriteLine("Los datos basicos del profesor son: " + profesor.MostrarDatosProfesor2());

            //Instancion => Se crea el objeto Curso
            ccurso curso1 = new ccurso("Curso 1","13 clase",24,"Lunes y Martes","19hs a 22hs", new DateTime(2020,09,10));
            int cupo = 15;
            curso1.Cupos = cupo;
            curso1.ProfesordelCurso = profesor; //Se relaciona un profesor ingresado a un curso.
            //Se muestra el profesor asigando a un Curso
            Console.WriteLine(curso1.MostrarCurso());


            //Aumento del sueldo del profesor
            profesor.AumentarSuelo(100);
            Console.WriteLine("El nuevo sueldo del profesor es: {0}", profesor.Sueldo);

            //Console.WriteLine("El nombre del profesor del curso {0}, es {1}:", curso1.Nombre, curso1.ProfesordelCurso.Nombre);
            
            
            //Console.WriteLine("El Nombre del curso 1 es: {0}", curso1.Nombre);
            //Console.WriteLine("Los dias de cursada del curso 1 es: {0}", curso1.Dia);

            
             


            Console.ReadKey();
        }
    }
}
