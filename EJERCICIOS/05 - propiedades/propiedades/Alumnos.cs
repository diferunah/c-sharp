public class Alumno
{
    public int Id { get; set; }

    public string PrimerNombre { get; set; }

    public string SegundoNombre { get; set; }

    public Alumno() //constructores
    {
        Id = 1;
    }


    public Alumno(int id) //constructores con declaracion 
    {
        Id = id;
    }

    public Alumno(string primerNombre, string segundoNombre)
    {
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;
    }

}

