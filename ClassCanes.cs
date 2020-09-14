using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassCanes:ClassMascota
    {
        public bool entrenamiento;
        public int cantPartos;
        Random parto = new Random();
        Random raza = new Random();



        public int GetPartos()
        {
            cantPartos = parto.Next(1, 9);
            return cantPartos;
        }

        public override string GetRaza()
        {
            int aleNum = raza.Next(1, 6);
            switch (aleNum)
            {
                case 1: return "Pastor alemán";
                case 2: return "Gran danés";
                case 3: return "Caniche";
                case 4: return "Labrador retriever";

                default: return "Dachshund";
            }
        }
    }
}
