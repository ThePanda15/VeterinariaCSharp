using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassConsultas
    {
        public int id;
        public DateTime fecha;
        public string NomServicio;
        public int costoSerivico;
        public int MedicamentoExta;
        public int CantidadVisistas;
        public float descuento;
        public float costoTotal;
        public int opc;
        Random visita = new Random();
        Random medicamento = new Random();

        public ClassConsultas()
        {
            
        }

        public void GetServicio()
        {
            MedicamentoExta = medicamento.Next(0, 501);
            Console.WriteLine("1.-Servicio de cardiologia\n2.- Consulta\n3.- Cirugia\n4.- Servicio de Diagnostico por imagen\n5.- Pedicure");
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    NomServicio = "Cardiologia";
                    costoSerivico = 1500;
                    break;
                case 2:
                    NomServicio = "Consulta";
                    costoSerivico = 2000;
                    break;
                case 3:
                    NomServicio = "Cirugia";
                    costoSerivico = 3000;
                    break;


                case 4:
                    NomServicio = "Servicio de Diagnóstico por Imagen";
                    costoSerivico = 5000;
                    break;
                case 5:
                    NomServicio = "Pedicure";
                    costoSerivico = 10000;
                    break;
                default:
                    break;
            }
        }


        public virtual float GetDescuento()
        {
            MedicamentoExta = medicamento.Next(0, 501);
            CantidadVisistas = visita.Next(1, 16);
            if (CantidadVisistas > 5)
            {
                Console.WriteLine("Usted tiene descuento");
                costoTotal =costoTotal- (costoTotal * 0.20f);
                return costoTotal;
                
            }
            else
            {
                Console.WriteLine("Usted no tiene descuento");
                return costoTotal;
            }
       
           
            
        }

        public float GetCostoTotal()
        {
     
            costoTotal = costoSerivico + MedicamentoExta;
            return costoTotal;
        }
    }
}
