using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KNFU.Temperatura;

namespace KNFU.Temperatura.Unit.TestMSTest
{
    [TestClass]
    public class ConvertidorTemperaturaTests
    {
        [TestMethod]
        public void CelsiusAFahrenheit_DeberiaConvertirCorrectamente()
        {
            var convertidor = new ConvertidorTemperatura();
            double resultado = convertidor.CelsiusAFahrenheit(0);
            Assert.AreEqual(32, resultado);
        }

        [TestMethod]
        public void FahrenheitACelsius_DeberiaConvertirCorrectamente()
        {
            var convertidor = new ConvertidorTemperatura();
            double resultado = convertidor.FahrenheitACelsius(32);
            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void CelsiusAKelvin_DeberiaConvertirCorrectamente()
        {
            var convertidor = new ConvertidorTemperatura();
            double resultado = convertidor.CelsiusAKelvin(0);
            Assert.AreEqual(273.15, resultado);
        }

        [TestMethod]
        public void KelvinACelsius_DeberiaConvertirCorrectamente()
        {
            var convertidor = new ConvertidorTemperatura();
            double resultado = convertidor.KelvinACelsius(273.15);
            Assert.AreEqual(0, resultado);
        }
    }
}
