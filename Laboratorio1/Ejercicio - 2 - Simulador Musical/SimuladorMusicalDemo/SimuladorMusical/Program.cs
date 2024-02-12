using System;

internal class Program
{
    public static void Main(string[] args)
    {
        // las instancias
        Instrumento guitarra = new Guitarra("Electrica");
        Instrumento piano = new Piano("de Cola");
        Instrumento violin = new Violin("Clasico");

        //menu
        while (true)
        {
            Console.WriteLine("======= SIMULADOR MUSICAL =======");
            Console.WriteLine("                                 ");
            Console.WriteLine("1.-Tocar la Guitarra");
            Console.WriteLine("2.-Tocar el Piano");
            Console.WriteLine("3.-Tocar el Violín");
            Console.WriteLine("4.-Salir");
            Console.WriteLine("                                 ");
            Console.WriteLine("======= SIMULADOR MUSICAL =======");
            Console.Write("Elija una opción (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        TocarInstrumento(guitarra);
                        break;

                    case 2:
                        TocarInstrumento(piano);
                        break;

                    case 3:
                        TocarInstrumento(violin);
                        break;

                    case 4:
                        Console.WriteLine("¡Gracias por usar mi simulador musical ! Hasta luego.");
                        return;

                    default:
                        Console.WriteLine("Opcion no valida, please elija una opcion del 1 al 4");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no valida, porfavor escoja un numero.");
            }

            Console.WriteLine(); //separador
        }
    }

    private static void TocarInstrumento(Instrumento instrumento)
    {
        Console.WriteLine($"Tocando el instrumento: {instrumento.Nombre}");
        instrumento.Sonar();
        Console.WriteLine();
    }
}

//la clase principal
class Instrumento
{
    //propiedad instrumento
    public string Nombre { get; }

    //construcoro
    public Instrumento(string nombre)
    {
        Nombre = nombre;
    }

    //metodo para sonar
    public virtual void Sonar()
    {
        Console.WriteLine("¡Haciendo sonar el instrumento!");
    }
}

//clase derivada - Guitarra
class Guitarra : Instrumento
{
    //ropiedad para el tipo de guitarra
    public string Tipo { get; }

    //constructor
    public Guitarra(string tipo) : base("Guitarra")
    {
        Tipo = tipo;
    }

    public override void Sonar()
    {
        Console.WriteLine($"Tocando la guitarra {Tipo}: ¡Tararara!");
    }
}

//clase derivada - Piano
class Piano : Instrumento
{
    public string Tipo { get; }

    public Piano(string tipo) : base("Piano")
    {
        Tipo = tipo;
    }

    public override void Sonar()
    {
        Console.WriteLine($"Tocando el piano {Tipo}: ¡Plin plin plin!");
    }
}

//clase derivada - Violín
class Violin : Instrumento
{
    //propiedad para el tipo de violín
    public string Tipo { get; }

    public Violin(string tipo) : base("Violín")
    {
        Tipo = tipo;
    }

    public override void Sonar()
    {
        Console.WriteLine($"Tocando el violín {Tipo}: ¡Screeeech!");
    }
}
