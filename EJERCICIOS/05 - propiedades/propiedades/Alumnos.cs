public class Alumno
{
    public int Id { get; set; }

    public string PrimerNombre { get; set; }

    public string SegundoNombre { get; set; }

    public Alumno() //constructores
    {
        Id = 1;
    }

    public Alumno(int Id) //constructores con declaracion 
    {
        Id = Id;
    }

}
