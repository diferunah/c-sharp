using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(); //llama al id del constructor
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno b = new Alumno(); //llama al id del constructor
            b.Id = 2;               // sobreescrbe el valor de constructor
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Martinez";

            Alumno c = new Alumno(3); //llama al 2do constructor con variable declarada
            b.PrimerNombre = "Pedro";

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
        }
    }
}
