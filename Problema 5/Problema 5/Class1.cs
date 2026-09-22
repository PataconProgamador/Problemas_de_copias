using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_5
{
    public class LibroCalificaciones
    {
        private string nombreCurso;
        public LibroCalificaciones(string nombre) // nombre del curso que representa este LibroCalificaiones
        {
            nombreCurso = nombre; // inicializa nombreCurso usando la propiedad
        }// fin del constructor
        // propiedad para obtener (get) y establecer (set) el nombre del curso
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            } // fin get
            set
            {
                nombreCurso = value; // set deberia validar
            } // fin set
        }// fin de la propiedad Nombrecurso

        //Muestra mensaje de bienvenida para el usuario de LibroCalificaciones 
        public void MostrarMensaje()
        {
            //la propiedad NombreCurso obtiene el nombre del curso
            Console.WriteLine("Bienvenido a l libro de calificaciones de \n {0}\n", NombreCurso);
        }//FIn del metodo MostrarMensaje

        //Determina el promedio de la clase con base en las 10 claificaciones introducidas por el usuario
        public void DeterminarPromedio()
        {
            int total; //suma de las calificaciones introducidas por el usuario
            int contadorCalif; //Numero de las siguiente calificacion a introducir
            int calificacion; // valor de la calificaion introducida por el usuario
            double promedio; // promedio de las calificaciones

            //fase de inicializacion
            total = 0; //inicializa el total
            contadorCalif = 0; //inicializa el contador del ciclo

            //mensaje para recibir como entrada la calificacion del usuario
            Console.Write("Escriba calificacion o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());

            //fase de procesamiento
            while (calificacion != -1)// itera hasta que se ingrese -1
            {
                total += calificacion; //suma la calificacion al total
                contadorCalif++;//incrementa el contador en 1
                //mensaje para recibir la siguiente entrada del usuario
                Console.Write("Escriba calificacion o -1 para salir: ");
                calificacion = Convert.ToInt32(Console.ReadLine());
            }//fin del while

            //fase de terminacion
            //si el usuario introdujo cuando menos una calificacion...
            if (contadorCalif != 0)
            {
                //calcula el promedio de todas las calificaciones introducidas
                promedio = (double)total / contadorCalif;
                //muestra el total y el promedio con 2 cifras de precision
                Console.WriteLine("El total de las {0} calificaciones introducidas es {1}", contadorCalif, total);
                Console.WriteLine("EL promedio de la clase es {0:F2}", promedio);
            }//fin del if
            else // No se introdujeron calificaciones, muestra mensaje de error
                Console.WriteLine("No se introdujeron calificaciones");
        }//Fin del metodo DeterminarPromedio
    }//Fin de la clase LibroCalificaciones
}
