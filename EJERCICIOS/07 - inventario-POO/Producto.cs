public class Producto
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }         // Propiedades de prodcuto
    public int Existencia { get; set; }

    public Producto(string codigo, string descripcion, int existencia)
    {
        Codigo = codigo;
        Descripcion = descripcion;                  // Contructor de producto
        Existencia = existencia;
    }

}