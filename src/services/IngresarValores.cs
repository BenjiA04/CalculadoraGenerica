
class IngresarValores
{
    public static void Ingresar<T>(List<T> listaNumeros)
    {
        bool valido = false;
        string seguirIngresando = "";
        int orden = 1;

        do {
        while (!valido){
            
            try
            {
                Console.Write($"\n-Valor #{orden}: ");
                string entrada = Console.ReadLine()!;

                T numero = (T)Convert.ChangeType(entrada, typeof(T));
                listaNumeros.Add(numero);
                valido = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato erroneo ingresado.");
                
            }
          }

          Console.Write("\n¿Quieres ingresar mas valores? ");
          seguirIngresando = Console.ReadLine()!.ToUpper();
          
          if(seguirIngresando == "SI") valido = false; orden++;

        }while(seguirIngresando == "SI");

        menuOperacion.MostrarMenu(listaNumeros);
    }
}