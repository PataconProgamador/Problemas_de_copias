using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problema_4
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
            get { 
                return nombreCurso; 
            } // fin get
            set { 
                nombreCurso = value; // set deberia validar
            } // fin set
        }// fin de la propiedad Nombrecurso

        //Muestra mensaje de bienvenida para el usuario de LibroCalificaciones 
        public void MostrarMensaje ()
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
            int promedio; // promedio de las calificaciones

            //fase de inicializacion
            total = 0; //inicializa el total
            contadorCalif = 1; //inicializa el contador del ciclo

            //fase de procesamiento
            while (contadorCalif <=10)// itera 10 veces
            {
                Console.Write("Escriba calificacion:"); //Mensaje para el usuario
                calificacion = Convert.ToInt32(Console.ReadLine());
                total += calificacion; //suma la calificacion al total
                contadorCalif++;//incrementa el contador en 1
            }//fin del while
            promedio = total / 10; //division entera produce resultado entero

            //imprime el total y el promedio de las calificaciones
            Console.WriteLine("\n EL total de las 10 calificaciones es {0}", total);
            Console.WriteLine("EL promedio de la clase es {0}", promedio);
        }//Fin del metodo DeterminarPromedio
    }//Fin de la clase LibroCalificaciones
}
