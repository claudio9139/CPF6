namespace prueba_1
{
    public class Function
    {
      
        
        //float
        
        private static bool Trv1 (string stringToConvert,out float result)

        {
            bool success;
            success=float.TryParse(stringToConvert,out result);

            return success;

       }


        // int 
        private static bool Trv2(string stringToConvert, out int result1)

        {
            bool success;
            success = int.TryParse(stringToConvert, out result1);

            return success;

        }

        
        // decimal


        private static bool Trv3(string stringToConvert, out decimal result2)

        {
            bool success;
            success = decimal.TryParse(stringToConvert, out result2);

            return success;


        }

        //double


        private static bool Trv4(string stringToConvert, out double result3)

        {
            bool success;
            success = double.TryParse(stringToConvert, out result3);

            return success;


        }

        //parseo manual

        private static bool Trv5(string stringToConvert, ref int result4)
        {

            bool ok = true;
            bool mal = false;

            foreach (char c in stringToConvert)
            {

                if (!char.IsDigit(c))
                {
                    ok = false;

                    Console.WriteLine($"Caracter {c} no es un digito valido");
                    break;

                }
         
            }

            if (ok)
            {

                result4 = int.Parse(stringToConvert);
                return ok;
            }

            else
            {
                result4 = 0;
                return ok;

            }









        }







        static void Main(string[] args)
        {
                bool success;
                float result; //result float
                string stringToConvert;
                int result1;  // result1 integer
                decimal result2;  // result 2 decimal
                double result3;   // result 3 double
                int result4 = 0;
                string consulta9;



            do
            {

                Console.WriteLine("Ingrese el numero a convertir\n\n\n");
                stringToConvert = Console.ReadLine();

                success = Trv1(stringToConvert, out result);

                Console.WriteLine($"Float Conversion   {success}");
                Console.WriteLine(result);


                success = Trv2(stringToConvert, out result1);

                Console.WriteLine($"Int Conversion   {success}");
                Console.WriteLine(result1);

                success = Trv3(stringToConvert, out result2);

                Console.WriteLine($"Decimal Conversion   {success}");
                Console.WriteLine(result2);

                success = Trv4(stringToConvert, out result3);

                Console.WriteLine($"Double Conversion   {success}");
                Console.WriteLine(result3);


                success= Trv5(stringToConvert, ref result4);
                Console.WriteLine($"User Parse Utility       {success}");
                Console.WriteLine(result4);

                Console.WriteLine();
                Console.WriteLine("DESEA SEGUIR INGRESANDO NUMEROS S/N");
                consulta9 = Console.ReadLine();

            }
            while (consulta9 == "s" || consulta9 == "S");




            }
                
                
                
                
        }
    }

