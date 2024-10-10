using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNFU.Temperatura
{
    public class ConvertidorTemperatura
    {
        public double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public double CelsiusAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public double KelvinACelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
    }
}
