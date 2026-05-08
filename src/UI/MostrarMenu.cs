class Menu
{
    public static void MostrarMenu()
    {
        Console.WriteLine("Bienvenidos.");
        Console.WriteLine("Seleccione el tipo de dato que va a manejar");
        Console.WriteLine("1. Entero");
        Console.WriteLine("2. Double");
        Console.WriteLine("3. Float");

        int opcion = 0;
        bool valido;

        do{

            valido = false;

            while (!valido){
                try
                {
                    Console.Write("\nOpcion: ");
                    opcion = int.Parse(Console.ReadLine()!);

                    valido = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato erroneo ingresado.");
                    
                }
            }

            
            switch (opcion)
            {
                case 1:
                List<int> listInt = new();
                IngresarValores.Ingresar(listInt);
                break;

                case 2:
                List<double> listDouble = new();
                IngresarValores.Ingresar(listDouble);
                break;

                case 3:
                List<float> listFloat = new();
                IngresarValores.Ingresar(listFloat);
                break;

                default:
                Console.WriteLine("Opcion invalida.");
                break;
            }

        }while(opcion >= 4);
    }
}