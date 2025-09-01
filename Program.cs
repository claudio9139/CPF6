namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
             Promedio de notas
             Pedir al usuario que ingrese notas (double). Seguir pidiendo hasta que escriba -1. Luego calcular y mostrar el promedio de las notas válidas.
            */

            Console.WriteLine("Ingrese notas para calcular el promedio, para finalizar ingrese -1 \n\n");
            double nota;
            double sumaNotas = 0;
            int contadorNotas = 0;
            do
            {
                nota = double.Parse(Console.ReadLine());
                if (nota != -1)
                {
                    sumaNotas += nota;
                    contadorNotas++;
                    Console.WriteLine($"Nota ingresada {nota}   Cardinal de notas ingresadas {contadorNotas} \n\n");
                }
            } while (nota != -1);
            if (contadorNotas > 0)
            {
                double promedio = sumaNotas / contadorNotas;
                Console.WriteLine($"El promedio de las notas ingresadas es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron notas válidas.");
            }














            //Console.WriteLine("Hello, World!");
        }
    }
}
