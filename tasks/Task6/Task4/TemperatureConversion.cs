using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class TemperatureConversion
    {
        public static double Get(double Temperature, Unit unit)
        {
            if (unit == Unit.Celsius) return (Temperature - 32) * 5 / 9;
            if (unit == Unit.Fahrenheit) return Temperature * 9 / 5 + 32;
            return Temperature;
        }
    }
}
