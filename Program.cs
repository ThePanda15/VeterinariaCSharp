using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string raza;
            string nom;
            ClassMascota mascotas = new ClassMascota();
            ClassFelinos felinos = new ClassFelinos();
            ClassConsultas consulta = new ClassConsultas();

            ClassCliente datos = new ClassCliente();

            ClassCliente[] informacion = new ClassCliente[10];



            for (int i = 0; i < informacion.Length; i++)
            {
                Console.WriteLine("******************** Informacion del cliente ********************");
                Console.WriteLine("Ingrese su nombre");
                datos.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su numero telefonico");
                datos.telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese su domicilio");
                datos.domicilio = Console.ReadLine();


                Console.WriteLine("Que servicio desea");
                consulta.GetServicio();



                Console.WriteLine("******************** Datos de la mascota ********************");
                Console.WriteLine("Ingrese el nombre de la mascota");
                mascotas.nombre = Console.ReadLine();
                Console.WriteLine("Su mascota es can o felino?");
                raza = Console.ReadLine();
                if (raza == "can")
                {
                    mascotas.raza = "can";
                    mascotas.GetRaza();
                }
                if (raza == "felino")
                {
                    mascotas.raza = "felino";
                    felinos.GetRaza();
                }
                Console.WriteLine("Ingrese la edad de la mascota");
                mascotas.edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el peso de la mascota");
                mascotas.peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese descripcion de la mascota");
                mascotas.rasgos = Console.ReadLine();


                Console.WriteLine("**************************Factura**************************");
                Console.WriteLine(consulta.fecha = DateTime.Today);
                Console.WriteLine("**************************D A T O S   D E L    C L I E N T E**************************");
                Console.WriteLine("\n Nombre del cliente: " + datos.Nombre + "\n Telefono: " + datos.telefono + "\n Domicilio: " + datos.domicilio);
                Console.WriteLine("**************************D A T O S   D E    L A    M A S C O T A**************************");
                Console.WriteLine("\n Nombre de la mascota" + mascotas.nombre + "\nSu mascota es un " + mascotas.raza + "\n Raza: " + mascotas.GetRaza() + "\n Edad: " + mascotas.edad + "\nPeso de la mascota " + mascotas.peso + "\nRasgos descriptivos " + mascotas.rasgos);
                Console.WriteLine("**************************D A T O S   D E    L A    C O N S U L T A**************************");
                Console.WriteLine("Medicamento extra " + consulta.MedicamentoExta + "\n Dosis " + mascotas.GetDosis() + "\n Id de mascota " + (mascotas.id++) + "\n Numero de visita " + consulta.CantidadVisistas + "\n Nombre de consulta " + consulta.NomServicio + "\n Costo del servicio " + consulta.costoSerivico + "\n Costo total"+ consulta.GetCostoTotal() + "\n Costo con descuento " + consulta.GetDescuento()) ;
               
                Console.ReadKey();
                Console.Clear();

            }
        
    }
    }
}
