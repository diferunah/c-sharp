public class NewBaseType
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public string NoCarnet { get; set; }

    public int obtenerEdad()
    {
        return 21;
    }
}

public class Alumno : NewBaseType
{
    public Alumno(int codigo, string nombre, string telefono)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
    }
}