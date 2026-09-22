namespace Problema_5
{
    internal class Program
    {
            static void Main(string[] args)
            {
                //Console.WriteLine("Hello, World!");
                //crea el objeto miLibroCalificaciones  de LibroCalificicariones y pasa el nombre al 
                //cursor y constructor 
                LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones("" +
                    "CS101 Introduccion a la programcion en C#");
                miLibroCalificaciones.MostrarMensaje();//Muestra mensaje de bienvenida
                miLibroCalificaciones.DeterminarPromedio();//Encuentra el promedio de calificaciones
            }//Fin de main
        }//Fin de la clase
}

