using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class AlmaPiac
    {
        //public double GetAlmaÁr(double kg)
        //1 paramétere van, hogy hány kilót veszünk, és 1 dolgot ad vissza: az alma árát.Egyetlen csavar van benne,
        //hogy minél több almát veszünk annál több kedvezményt kapunk.
        //Legalább 5 kg alma vásárlása esetén a kedvezmény 10 %, 20kg, vagy a felett 15 %. 1 kg alma ára 400Ft.
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
