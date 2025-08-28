Console.WriteLine("Hello, World!");

Habitaciones habitacion1 = new Habitaciones();
Habitaciones habitacion2 = new Habitaciones();
public class Tipos
{
    public int Id = 0;
    public String? TipoHabitacion = "";

    public List<Habitaciones> Habitaciones = new List<Habitaciones>();
}

public class Elementos
{
    public String? seccion = "";
    public int Id = 0;
    public String? paredColor = "";
    public int Televisores = 0;
    public int banos = 0;

}

public class Habitaciones
{
    public int Id = 0;
    public int NumHabitacion = 0;
    public bool Activo = false;
    public int valorNoche = 0;
    public Tipos Tipo = new Tipos();
    public List<Elementos> Elementos = new List<Elementos>();
}

public class Restricciones
{
    public int Id = 0;
    public bool ruido = false;
    public int numPersonas = 0;
    public bool animales = true;

}
