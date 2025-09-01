namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal Numero_Decimal;
            float Numero_Float;
            double Numero_Double;
            int numero_azar;
            string palabra;
            palabra = "1e0d";
         Random numero_aleat = new Random();
         numero_azar = numero_aleat.Next();  
         Console.WriteLine(numero_azar);
            Numero_Float = numero_azar/10000000;
            Numero_Decimal = 1e-1M;
            //Numero_Float = .1f;
            Numero_Double = 0.1d;
            Console.WriteLine($"****************************{Numero_Float}");
            for (int i = 0; i < Numero_Float/1; i++)

            {

                Numero_Decimal += .1M;
                Numero_Float += .1f;
                Numero_Double += .1d;
                Console.WriteLine(i);
                Console.WriteLine($"Decimal   { Numero_Decimal}\n");
                Console.WriteLine($"Float     {Numero_Float    }\n");
                Console.WriteLine($"Double    {Numero_Double   }\n\n\n");

            }
            
            
            
            
            
            //Console.WriteLine("Hello, World!");
        }
    }
}
