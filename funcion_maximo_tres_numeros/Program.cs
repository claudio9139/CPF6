namespace funcion_maximo_tres_numeros
{
    public class Funciones
    {
        public static string Saludar(string saludo,string nombre)
        {

        string mensaje =$" {nombre}  {saludo}";



         return mensaje ;

   

        }
        
        public static decimal mas_grande_de_tres(decimal num1, decimal num2, decimal num3,out decimal num4 )
        {
            decimal result;
            decimal result1;
            num4 = 1e6M;
            result=Math.Max(num1, num2);
            result1=Math.Max(result, num3);


            return result1;

        }
        

        public static decimal Ingresar_Numero()
        {
         bool flag;
         decimal primer_numero;
            do
            {
                
                flag = decimal.TryParse(Console.ReadLine(), out primer_numero);
                if (!flag)
                {
                    Console.WriteLine("DATO INVALIDO NO NUMERICO");
                }
            }
            while (!flag);
         return primer_numero; 
        }





        
        
        
        
        
        
        static void Main(string[] args)
        {
            decimal num4 = 233;
            string miNombre="JUAN PEREZ";
            string saludo = "Buenas tardes";
            string retorno;
            //retorno = Saludar(miNombre, saludo);
            //
            decimal primer_numero;
            decimal segundo_numero;
            decimal tercer_numero;
            decimal resultado;
            bool flag;
            //Console.WriteLine();
            //Console.Write($"Ingrese el 1er Numero       :");
            // primer_numero = decimal.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.Write($"Ingrese el 1er Numero       :");
            primer_numero = Ingresar_Numero();
            Console.Write($"Ingrese el 2er Numero       :");
            segundo_numero = Ingresar_Numero();
            Console.Write($"Ingrese el 3er Numero        :");
            tercer_numero = Ingresar_Numero();
            resultado = mas_grande_de_tres(primer_numero, segundo_numero, tercer_numero, out num4);
            /*
            flag=decimal.TryParse(Console.ReadLine(),out primer_numero);
            Console.Write($"Ingrese el 2er Numero       :");
            //segundo_numero= decimal.Parse(Console.ReadLine());
            flag=decimal.TryParse(Console.ReadLine(),out segundo_numero);
            Console.Write($"Ingrese el 3er Numero        :");
            //tercer_numero = decimal.Parse(Console.ReadLine());
            flag=decimal.TryParse(Console.ReadLine(),out tercer_numero);
            resultado =mas_grande_de_tres(primer_numero,segundo_numero,tercer_numero,out num4);
            */




            Console.WriteLine($"el mayor entre los numeros {primer_numero} ,{segundo_numero} y {tercer_numero} es = a {resultado},{num4}");
        }
    }
}
