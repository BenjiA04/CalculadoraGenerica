
class menuOperacion
{
    public static void MostrarMenu<T>(List<T> listaNumeros)
    {
        Console.WriteLine("¿Que operacion va a realizar?");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");
        
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
                RealizarOperaciones.Realizar(listaNumeros, (a,b) => (dynamic)a! + (dynamic)b!, "suma");
                break;

                case 2:
                RealizarOperaciones.Realizar(listaNumeros, (a,b) => (dynamic)a! - (dynamic)b!, "resta");
                break;

                case 3:
                RealizarOperaciones.Realizar(listaNumeros, (a,b) => (dynamic)a! * (dynamic)b!, "multiplicacion");
                break;

                case 4:
                try {
                RealizarOperaciones.Realizar(listaNumeros, (a,b) => (dynamic)a! / (dynamic)b!, "division");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;

                default:
                Console.WriteLine("Opcion invalida.");
                break;
            }
        }while(opcion >= 5);
    }
}