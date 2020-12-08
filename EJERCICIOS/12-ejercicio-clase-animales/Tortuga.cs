using System;
public class Tortuga: Peces
{
    public string Color { get; set; }

    public void Nada()
    {
        Console.WriteLine("Nadar");
    }

     public void Descripcion() 
    {
        Console.WriteLine("La tortuga camina lento y tiene caparazon");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("La tortuga es un animal pequeño o grande");
    }

    private void OtroMetodo()
    {

    }
}