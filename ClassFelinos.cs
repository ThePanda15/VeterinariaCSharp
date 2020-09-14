using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassFelinos:ClassMascota
    {
        public bool esterelizado;


        public override double GetDosis()
        {
            dosis = (peso * 8.25f)/2;
            return dosis;
        }
    }
}
