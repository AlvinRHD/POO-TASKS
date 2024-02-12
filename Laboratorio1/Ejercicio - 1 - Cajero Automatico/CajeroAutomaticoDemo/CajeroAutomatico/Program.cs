internal class Program
{
    public static void Main(string[] args)
    {
        //la contra del usuario
        string contra = "1234";

        //dinero inicial
        decimal saldo = 1000;

        Console.WriteLine("Bienvenido al ATM");

        //solicitar la contra
        Console.WriteLine("Porfavor ingrese su contraseña");
        string contraIngreso = Console.ReadLine();

        //verificar si la contra es valida
        while (contraIngreso != contra)
        {
            Console.WriteLine("Contraseña incorrecta, intente nuevamente porfavor");

            //solicitar denuevo la contra
            Console.WriteLine("Porfavor ingrese su contraseña");
            contraIngreso = Console.ReadLine();
        }

        Console.WriteLine("Contraseña correcta");

        //demas funcionalidades   //menu
        while (true)
        {
            Console.WriteLine(".::::::::MENU::::::::.");
            Console.WriteLine("                      ");
            Console.WriteLine("1.-Ver saldo ");
            Console.WriteLine("2.-Depositar ");
            Console.WriteLine("3.-Retiro en efectivo ");
            Console.WriteLine("4.-Salir..... ");
            Console.WriteLine("                      ");
            Console.WriteLine(".::::::::MENU::::::::.");

            //solicitar al usuario que quiere hacer
            Console.Write("Porfavor elija una opcion entre el 1 y 4 ");
            string opcion = Console.ReadLine();


            //que procese lo que se escogio
            switch (opcion)
            {
                case "1":
                    //saldo
                    Console.WriteLine($"Saldo actual: ${saldo}");
                    break;

                case "2":
                    //deposito
                    Console.WriteLine("Ingrese la cantidad a depositar: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal cantidadDeposito))
                    {
                        saldo += cantidadDeposito;
                        Console.WriteLine($"Deposito con exito, nuevo saldo: ${saldo}");
                    }

                    else
                    {
                        Console.WriteLine("La entrada no es valida, porfavor ingrese un monto que sea valido.");
                    }
                    break;

                case "3":
                    //retirar efectivo
                    Console.WriteLine("Ingrese la cantidad a retirar: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal cantidadRetiro))
                    {
                        if (cantidadRetiro <= saldo)
                        {
                            saldo -= cantidadRetiro;
                            Console.WriteLine($"Retiro exitoso, nuevo saldo: ${saldo}");
                        }

                        else
                        {
                            Console.WriteLine("No hay suficiente saldo para realizar el retiro.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Entrada no valida porfavor ingrese un monto valido.");
                    }
                    break;

                case "4":
                    //salir 
                    Console.WriteLine("Gracias por usar nuestro ATM, nos vemos luego!!!!!!!");
                    Console.WriteLine("Presione cualquier letra para salir");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Opcion no valida, porfavor elija una opcion del 1 al 4");
                    break;
            }
        }
    }
}