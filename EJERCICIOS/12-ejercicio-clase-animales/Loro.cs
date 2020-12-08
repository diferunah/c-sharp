using System;
public class Loro : Aves
{
    public string Color { get; set; }

    public void Hablar()
    {
        Console.WriteLine("Hurra lorito");
    }

     public void Descripcion() 
    {
        Console.WriteLine("El loro es un ave domestica");
    }

     public void Tamano()
    {
        DescribirTamano();
        OtroMetodo();
    }

    private void DescribirTamano() 
    {
        Console.WriteLine("El loro es un ave peque;o");
    }

    private void OtroMetodo()
    {

    }
}