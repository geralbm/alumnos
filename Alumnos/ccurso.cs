using System;
using System.Collections.Generic;
using System.Text;

namespace Alumnos
{
    class ccurso

    {
        //Atributos
        public string Nombre { get; set; }
        public string Duracion { get; set; }
        public int  CargaHoraria { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }
        public int DiasPorSemana { get; set; }
        public DateTime FechaDeInicio { get; set; }
        public int Cupos { get; set; }
        public cprofesor ProfesordelCurso { get; set; }

        public List<calumno> AlumnosdelCurso { get; set; }

        //Lista de alumnos => es una especie de arreglo, y se puede utilizar arreglos de clases
        //Se puede usar arreglos, pero el List es mas optimo y mas dinamico
        //En esta lista se guardan n-alumnos.
        //Se inicia el indice en valor 0
        //SIEMPRE QUE SE TRABAJE CON LISTA => INSTANCIARLA EN EL CONSTRUCTOR
        public List<calumno> AlumnosDelCurso { get; set; }


        // Constructor
        //---> Se realiza el constructur con datos ya setaeados en el Programa Principal
        public ccurso(string nombre, string duracion, int cargahoraria, string dia, string horario, DateTime fechadeinicio)
        {
            this.Nombre = nombre;
            this.Duracion = duracion;
            this.CargaHoraria = cargahoraria;
            this.Dia = dia;
            this.Horario = horario;
            this.FechaDeInicio = fechadeinicio;

            //SIEMPRE QUE SE TRABAJE CON LISTA => INICIALIZAR EN EL CONSTRUCTOR Y SE HACE INSTANCIANDOLA!
            //AlumnosDelCurso = new List<calumno>;
            AlumnosdelCurso = new List<calumno>();
        }

        //Crear metodo Mostror curso
        public string MostrarCurso()
        {
            //Otra forma de mostar datos.
            string mostrarcurso = $"Datos del curso:{Nombre} {Environment.NewLine} {Duracion} {Environment.NewLine} {Dia} {Environment.NewLine}{Horario}" +
                $"{FechaDeInicio} {Environment.NewLine}";
            //Para mostrar los datos del profesor re utilizo el metodo propio del Profesor => solo se llama.
            //Se re utiliza.
            mostrarcurso += $"Datos del Profesor del curso: {ProfesordelCurso.MostrarDatosProfesor2()}";


            return mostrarcurso;
        }

       
    }
}
