namespace desafio1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Las tecnologías en evaluación son:
             🔹 Inteligencia Artificial (IA)
             🔹 Realidad Virtual/Aumentada (RV/RA)
             🔹 Internet de las Cosas (IOT)
             Para tomar una decisión informada, la empresa ha lanzado una encuesta entre sus empleados
             con el propósito de analizar ciertas métricas.
             🔹 Recolección de Datos
             Cada empleado encuestado deberá proporcionar la siguiente información:
             ✔️ Nombre
             ✔️ Edad (debe ser 18 años o más)
             ✔️ Género (Masculino, Femenino, Otro)
             ✔️ Tecnología elegida (IA, RV/RA, IOT)
            El sistema deberá permitir ingresar los datos de 10 empleados mediante la terminal.


 */
            string nombre;
            int edad;
            string genero;
            string tecnologia_utilizada;
            int cantidad_empleados = 2;
            string Masc = "M";
            string Fem = "F";
            string Otr = "O";
            long contador_1 = 0;
            float contador_2 = 0;
            long mayor_edad = 0;
            string nombre_mayor_edad = "";
            string tecnologia_mayor_edad = "";
            float contador_M=0;
            float contador_F=0;
            float contador_Otr=0;
            long edad_eligieron_iot = 0;
            long cantidad_eligieron_iot = 0;



            Console.WriteLine("Ingrese los datos siguientes......");

            for (int i = 0; i < cantidad_empleados; i++)
            {
                Console.WriteLine("\n\n");
                Console.Write($"Ingrese el nombre del empleado #{i + 1}   :");
                //Console.WriteLine();
                nombre = Console.ReadLine();

                Console.Write($"Ingrese la edad del empleado #{i + 1} (debe ser 18 años o más)  :");
                //Console.WriteLine();

                do {

                    edad = int.Parse(Console.ReadLine());
                    if (edad < 18)
                    {
                        Console.WriteLine("edad invalida,debe ser mayor a 18 años");
                    };
                } while (edad < 18);








                do
                {

                    Console.Write($"Ingrese el género del empleado #{i + 1}   :((M)asculino, (F)emenino, (O)tro)");

                    genero = Console.ReadLine();

                    if (!((genero == Masc || genero == Fem) || (genero == Otr)))
                    {

                        Console.WriteLine($"Genero invalido,debe ser M ,F,O años y Ud ingresa {genero}");

                    }

                } while (!((genero == Masc || genero == Fem) || (genero == Otr)));




                do {

                    Console.Write($"Ingrese la  tecnologia utilizada del empleado #{i + 1}   :(IA, RV/RA, IOT)");
                    //Console.WriteLine();
                    tecnologia_utilizada = Console.ReadLine();


                    if (!((tecnologia_utilizada == "IA" || tecnologia_utilizada == "RV/RA") || (tecnologia_utilizada == "IOT")))
                    {

                        Console.WriteLine($"Ingreso Invalido ,debe seleccionar (IA, RV/RA, IOT) y  Ud ingresa {tecnologia_utilizada}");

                    }

                } while (!((tecnologia_utilizada == "IA" || tecnologia_utilizada == "RV/RA") || (tecnologia_utilizada == "IOT")));








                /**********************************************************************************************************
                Cantidad de empleados de género masculino que votaron por IOT o IA, 
               cuya edad esté entre 25 y 50 años (inclusive).
               */

                if ((genero == Masc) && ((tecnologia_utilizada=="IOT") ||(tecnologia_utilizada=="IA")) && (edad >25 && edad <=50))
                {
                    contador_1++; 
                }




             /* Porcentaje de empleados que NO votaron por IA, siempre y cuando:
                su género no sea Femenino 
                su edad está entre los 33 y 40 años.
             */
                
                if (!(tecnologia_utilizada=="IA") && !(genero=="F") && (edad >=33 && edad <= 40)) 
                
                {
                    contador_2++;



                }


                /*
                 Empleado masculino de mayor edad: mostrar su nombre y la tecnología que votó.
                */

                if (edad > mayor_edad) 
                {
                    mayor_edad = edad;
                    nombre_mayor_edad = nombre;
                    tecnologia_mayor_edad = tecnologia_utilizada;

                }

                /*
                Porcentajes totales según género
                */

                switch (genero)
                {

                    case "M":
                        contador_M++;
                        Console.WriteLine($"M{contador_M}");
                        break;

                    case "F":
                        contador_F++;
                        Console.WriteLine($"F{contador_F}");
                        break;


                    case "O":
                        contador_Otr++;
                        Console.WriteLine($"OTR{ contador_Otr}");
                        break;
                        
                }

                /*
                 Edad promedio de los que eligieron IOT
                 */
             if (tecnologia_utilizada=="IOT")
                {
                    cantidad_eligieron_iot++;
                    edad_eligieron_iot += edad;

                }






            }

            Console.WriteLine("SALIDA DE DATOS ..................\n\n");

            Console.WriteLine("Cantidad de empleados de género masculino que votaron por IOT o IA, \r\n cuya edad esté entre 25 y 50 años (inclusive).");


            Console.WriteLine($"La Cantidad de empleados es {contador_1}");

            Console.WriteLine("Porcentaje de empleados que NO votaron por IA, siempre y cuando:\r\n su género no sea Femenino \r\n Su edad está entre los 33 y 40 años\n");
           
            Console.WriteLine($"El porcentaje de empleados es {contador_2/cantidad_empleados*100}");

            Console.WriteLine($"Empleado masculino de mayor edad: mostrar su nombre y la tecnología que votó.\r\n");
            Console.WriteLine($"El empleado de mayor edad es {nombre_mayor_edad}, {mayor_edad} y la tecnologia es {tecnologia_mayor_edad}");

            Console.WriteLine($"Porcentaje segun genero Masc {contador_M/cantidad_empleados*100}\n");
            Console.WriteLine($"Porcentaje segun genero Feme {contador_F / cantidad_empleados * 100}\n");
            Console.WriteLine($"Porcentaje segun genero Otro {contador_Otr / cantidad_empleados * 100}\n");

            if (cantidad_eligieron_iot > 0)
            {
                Console.WriteLine($"Edad Promedio del personal que eligio IOT   {edad_eligieron_iot / cantidad_eligieron_iot}");
            }




            Console.WriteLine();























            //Console.WriteLine("Hello, World!");
        }
    }
}
