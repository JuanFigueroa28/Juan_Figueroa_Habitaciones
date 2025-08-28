Console.WriteLine("Hello, World!");

Habitaciones habitacion1 = new Habitaciones();
Habitaciones habitacion2 = new Habitaciones();

habitacion1.Id = 1011;
habitacion1.NumHabitacion = 10;
habitacion1.Activo = true;
habitacion1.valorNoche = 40000;
habitacion1.Tipo = new Tipos() { Id = 1, TipoHabitacion = "Dual" };
habitacion1.Elementos = new List<Elementos>();
habitacion1.Elementos.Add(new Elementos() { Id = 1, seccion = "humeda", paredColor = "Azul Oscuro", Televisores = 0, banos = 2 });

habitacion1.Restricciones = new List<Restricciones>();
habitacion1.Restricciones.Add(new Restricciones() { Id = 1, ruido = false, numPersonas = 2, animales = false});


Console.WriteLine(habitacion1.Tipo);
Console.WriteLine(habitacion1.Id);
Console.WriteLine(habitacion1.NumHabitacion);
Console.WriteLine(habitacion1.Activo);
Console.WriteLine(habitacion1.valorNoche);

Console.WriteLine("Elementos:");
    Console.WriteLine(habitacion1.elementos);

    Console.WriteLine(Restricciones.ruido);
    Console.WriteLine(Restricciones.numPersonas);
    Console.WriteLine(Restricciones.animales);

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