namespace Contador_numeros_positivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

                Contador de números positivos
               Pedir números enteros al usuario hasta que ingrese un número negativo. 
                Al final, mostrar cuántos positivos ingresó.

            */

            Console.WriteLine("Ingrese numeros enteros positivos, para finalizar ingrese un numero negativo \n\n");
            int numero;
            int contador = 0;
            do
            {
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    contador++;
                    Console.WriteLine($"Cardinal de numero ingresado {contador}   Numero ingresado {numero} \n\n");
                }
            } while (numero >= 0);
            Console.WriteLine($"Ha ingresado {contador} numeros positivos");
            Console.WriteLine("\n\n Fin del programa");















            //Console.WriteLine("Hello, World!");
        }
    }
}
