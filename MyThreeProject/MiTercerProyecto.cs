using MyThirdLibrary;



namespace MiTercerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejemplo de Lista
            //

            List<string> nombre233 = new List<string>();
            nombre233.Add("Pepe(0)");
            nombre233.Add("Pepe(1)");
            nombre233.Add("Pepe(2)");

            List<string> apellido233 = new List<string>();
            apellido233.Add("Perez(0)");
            apellido233.Add("Perez(1)");
            apellido233.Add("Perez(2)");

            Console.WriteLine(apellido233.Count);


            string nombre = "Juan(0)";
            string nombre1 = "JuanRamon(1)";
            string nombre2 = "Juan Pablo(2)";
            string apellido = "Perez(0)";
            string apellido1 = "Perez Gomez(1)";
            string apellido2 = "Perez Gimenez(2)";
            string direccion = "San Lorenzo 3725 Olivos";

            string nombre4 = "Juan(4)";
            string nombre5 = "JuanRamon(5)";
            string nombre6 = "Juan Pablo(6)";
            string apellido4 = "Perez(4)";
            string apellido5 = "Perez Gomez(5)";
            string apellido6 = "Perez Gimenez(6)";
            string direccion1 = "San Lorenzo 3725 Olivos(1)";
            string nombre7 = "Juan(7)";
            string apellido7 = "Perez Gomez(7)";

            string marcaEquipo = "Samsung";
            string modeloEquipo = "A20";

           
            
            //CLASE 
            // MyServicioTecnico.nombreEmpresa = "VEOLIA";
            //MyServicioTecnico.direccionEmpresa = "TRONADOR 4890";
            //Console.WriteLine($"\n\nEL NOMBRE DE LA EMPRESA ES     {MyServicioTecnico.nombreEmpresa}         iteraciones constructor estatico       {MyServicioTecnico.contadorIteraciones} ");
            //Console.WriteLine($"\n\nLA DIRECCION DE LA EMPRESA ES  {MyServicioTecnico.direccionEmpresa}                             iteraciones constructor estatico       {MyServicioTecnico.contadorIteraciones}\n\n");

            /*

            MyServicioTecnico Servicio1=new MyServicioTecnico();
            Servicio1.SetnombreCliente(nombre);
            Servicio1.SetApellidoCliente(apellido);
            

            Console.WriteLine($"{Servicio1.GetType()} {Servicio1.GetNombreCliente()}   {Servicio1.GetApellidoCliente()}    instancia ():  {MyServicioTecnico.contadorIteraciones}              ");
            MyServicioTecnico Servicio2 = new MyServicioTecnico();

            Servicio2.SetnombreCliente(nombre1);
            Servicio2.SetApellidoCliente(apellido1);

            Console.WriteLine($"{Servicio2.GetType()} {Servicio2.GetNombreCliente()}   {Servicio2.GetApellidoCliente()}   instancia ():  {MyServicioTecnico.contadorIteraciones}              ");
            MyServicioTecnico Servicio3 = new MyServicioTecnico();
            Servicio3.SetnombreCliente(nombre2);
            Servicio3.SetApellidoCliente(apellido2);


            Console.WriteLine($"{Servicio3.GetType()} {Servicio3.GetNombreCliente()}   {Servicio3.GetApellidoCliente()}   instancia ():  {MyServicioTecnico.contadorIteraciones}              ");


            /*
            string nombre4 = "Juan(4)";
            string nombre5 = "JuanRamon(5)";
            string nombre6 = "Juan Pablo(6)";
            string apellido4 = "Perez(4)";
            string apellido5 = "Perez Gomez(5)";
            string apellido6 = "Perez Gimenez(6)";
            string direccion1 = "San Lorenzo 3725 Olivos(1)";
            
            
            
            string nombre7 = "Juan(7)";

            string apellido7 = "Perez Gomez(7)";

            


            /*

            MyServicioTecnico Servicio4 = new MyServicioTecnico(nombre4);
            Console.WriteLine($"{Servicio4.GetType()}  {Servicio4.GetNombreCliente()}   {Servicio4.GetApellidoCliente()}    {Servicio4.GetDireccionCliente()}       instancia (parametro) :                           {MyServicioTecnico.contadorIteracionesUno}              ");
            MyServicioTecnico Servicio5 = new MyServicioTecnico(nombre5,apellido5);
            Console.WriteLine($"{Servicio5.GetType()}   {Servicio5.GetNombreCliente()}   {Servicio5.GetApellidoCliente()}    {Servicio5.GetDireccionCliente()}       instancia (parametro1,parametro2) :               {MyServicioTecnico.contadorIteracionesDos}              ");
            MyServicioTecnico Servicio6 = new MyServicioTecnico(nombre6,apellido6);
            Console.WriteLine($"{Servicio6.GetType()}  {Servicio6.GetNombreCliente()}   {Servicio6.GetApellidoCliente()}    {Servicio6.GetDireccionCliente()}        instancia (parametro1,parametro2) :               {MyServicioTecnico.contadorIteracionesDos}              ");
            */


            /*
            MyServicioTecnico Servicio7 = new MyServicioTecnico(marcaEquipo, modeloEquipo,direccion1);

            Servicio7.MarcaEquipo = "UPS3";
            Servicio7.ModeloEquipo = "APC300";
            Servicio7.DireccionCliente = "AV. Maipu 3745 Olivos";
            Servicio7.NombreCliente = "CLAUDIO";
            Servicio7.ApellidoCliente = "LUCHESSI";
            Console.WriteLine(Servicio7.DireccionCliente);
            //Console.WriteLine($"\n\n\n {Servicio7.MarcaEquipo} \n  {Servicio7.ModeloEquipo} \n   {Servicio7.DireccionCliente}      \n    instancia (parametro1 nombre,parametro2 apellido ,parametro3 direccion)     iteracion  {MyServicioTecnico.contadorIteracionesTres}              ");

            string mostrar=string.Empty;
            Servicio7.EmailCliente="xgordon13@fibertel.com.ar";
            
            mostrar=Servicio7.MostrarInfo();
            
            Console.WriteLine($"\n\n  {mostrar}      ");

            
            for (int i = 0; i < 3; i++)
            {
                Servicio7.PromedioRandom =i+10;
                mostrar = (Servicio7.Potencia).ToString();
                Console.WriteLine($"\n\n  {i}   {mostrar}      ");
                Servicio7.NombreCliente = nombre233[0];
                Console.WriteLine(nombre233[i]);
            }

            /*
            Servicio7.PromedioRandom = 1;
            mostrar =Servicio7.Potencia.ToString();
            Console.WriteLine($"\n\n  {mostrar}      ");

            

            Servicio7.PromedioRandom = 2000;
            mostrar = (Servicio7.PromedioRandom).ToString();
            Console.WriteLine($"\n\n  {mostrar}      ");
            */

            /*
            Servicio6.SetEmailCliente("xgordon6@fibertel.com.ar");
            mostrar = Servicio6.MostrarInfo();

            Console.WriteLine($"\n\n  {mostrar}      ");

            Servicio5.SetEmailCliente("xgordon5@fibertel.com.ar");
            mostrar = Servicio5.MostrarInfo();

            Console.WriteLine($"\n\n  {mostrar}      ");

            Servicio4.SetEmailCliente("xgordon4@fibertel.com.ar");
            Servicio4.SetApellidoCliente ("LUCHESSI");
            mostrar = Servicio4.MostrarInfo();

            Console.WriteLine($"\n\n  {mostrar}      ");

            double precioReparacion=MyServicioTecnico.CalcularPrecioReparacion(15000, 15);

            Console.WriteLine($"\n\n  EL PRECIO DE LA REPARACION ES DE  {precioReparacion}      ");

            Servicio4.SetPotencia(2000);
            double precioEquipo=Servicio4.CalcularPrecioEquipo(Servicio4, 15);

            Console.WriteLine($"\n\n  EL PRECIO DEL EQUIPO ES DE  {precioEquipo}      ");


            //Metodo instancia Devolver Resultado 

            
            Servicio7.SetPotencia(10);
            Servicio6.SetPotencia(1);

            Console.WriteLine(Servicio7.DevolverResultado(Servicio6));



            */

            // INSTANCIA CON CERO PARAMETROS

            MyServicioTecnico Servicio1 = new MyServicioTecnico();
            Servicio1.NombreCliente = nombre1;
            Servicio1.ApellidoCliente = apellido1;
            Servicio1.EmailCliente= "xxxxxx1@gmail.com";
            Servicio1.MarcaEquipo = marcaEquipo + "1";




            string nombre000=MyServicioTecnico.nombreEmpresa;
            string direccion000 = MyServicioTecnico.direccionEmpresa;

            Console.WriteLine(Servicio1.MostrarInfo());
            //Console.WriteLine($" {Servicio1.NombreCliente}       {Servicio1.ApellidoCliente}   {nombre000}      {direccion000} ");

            // CON UN PARAMETRO 

            MyServicioTecnico Servicio2 = new MyServicioTecnico("NombreCliente2##########");
            //Servicio2.NombreCliente = nombre2;
            Servicio2.ApellidoCliente = apellido2;
            //Console.WriteLine($" {Servicio2.NombreCliente}       {Servicio2.ApellidoCliente}");
            Console.WriteLine(Servicio2.MostrarInfo());


            // CON DOS PARAMETROS

            MyServicioTecnico Servicio3 = new MyServicioTecnico("APELLIDOCliente3##########","EMAILCLIENTE3#########");
            Servicio3.NombreCliente = nombre2 + "3";

            //Console.WriteLine($" {Servicio3.NombreCliente} {Servicio3.ApellidoCliente} {Servicio3.EmailCliente }");

            Console.WriteLine(Servicio3.MostrarInfo());


            // CON TRES PARAMETROS

            MyServicioTecnico Servicio4 = new MyServicioTecnico("MARCA4##########", "MODELO4#########","DIRECCION4");
            Servicio4.NombreCliente = nombre4;
            Servicio4.ApellidoCliente = apellido4;
            Servicio4.EmailCliente = Servicio3.EmailCliente + "4";
            //Console.WriteLine($" {Servicio4.NombreCliente} {Servicio4.ApellidoCliente} {Servicio4.EmailCliente} {Servicio4.MarcaEquipo}       {Servicio4.ModeloEquipo}   {Servicio4.DireccionCliente}");
            Console.WriteLine(Servicio4.MostrarInfo());
            double Promedio1 = Servicio4.CalcularPromedio(1000);
            string nombre2000 = MyServicioTecnico.nombreEmpresa;
            Console.WriteLine(Promedio1);

        }//end Main
    }//end class program
}// end namespace
