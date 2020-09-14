using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassMascota
    {
        public int id;
        public string nombre;
        public string raza;
        public int edad;
        public float peso;
        public string rasgos;
        public float dosis;
        Random ran = new Random();
        public ClassMascota()
        {
            id = 1;
            
        }
        public virtual double GetDosis()
        {
            dosis = peso * 5.09f;
            return dosis;
        }

        public virtual string GetRaza()
        {
           
            int aleNum = ran.Next(1, 6);
            switch (aleNum)
            {
                case 1: return "Gato siamés";
                case 2: return "British Shorthair";
                case 3: return "Sphynx";
                case 4: return "Gato persa";

                default: return "Ragdoll";
            }
        }

    }
}
