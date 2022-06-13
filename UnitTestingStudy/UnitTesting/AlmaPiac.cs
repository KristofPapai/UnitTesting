using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class AlmaPiac
    {
        static double AlmaArKg = 400.0;
        public double GetAlmaAr(double kg) {
            if (kg >= 5 && kg < 20)
            {
                return (kg * AlmaArKg) * 0.9;
            }
            else if (kg >= 20.0)
            {
                return (kg * AlmaArKg) * 0.85;
            }
            else
            {
                return kg * AlmaArKg;
            }
        }
    }
}
