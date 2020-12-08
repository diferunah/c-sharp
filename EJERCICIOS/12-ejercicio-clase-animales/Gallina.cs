using System;
public class Gallina : Aves
{
    public string Color { get; set; }

    public void Vuelo()
    {
        Console.WriteLine("Aletea");
    }

      public void Descripcion() 
    {
        Console.WriteLine("La gallina pone huevos, cacarea, tiene plumas y patas");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("La gallina es un animal pequeño");
    }

    private void OtroMetodo()
    {

    }
}