public class RealizarOperaciones
{
    public delegate T Calcular<T>(T a, T b);
    public static void Realizar<T>(List<T> listaNumeros, Calcular<T> operacion, string nombre)
    {
      try{
       T resultado = listaNumeros[0];

       for(int i=1; i<listaNumeros.Count; i++)
       {
          resultado = operacion(resultado, listaNumeros[i]);
       }

       Console.WriteLine($"El resultado de la {nombre} es {resultado}");
      }
      catch (DivideByZeroException)
      {
         Console.WriteLine("No se puede dividir entre cero.");
      }
      catch (Exception ex)
      {
         Console.WriteLine($"Ocurrio un error: {ex.Message}");
      }
   }
}