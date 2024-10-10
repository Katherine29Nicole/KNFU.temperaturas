using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNFU.Cadenas
{
    public class ManipuladorCadenas
    {
        // Método para concatenar dos cadenas
        public string Concatenar(string cadena1, string cadena2)
        {
            return cadena1 + cadena2;
        }

        // Método para convertir una cadena a mayúsculas
        public string ConvertirAMayusculas(string cadena)
        {
            return cadena.ToUpper();
        }

        // Método para invertir una cadena
        public string InvertirCadena(string cadena)
        {
            char[] caracteres = cadena.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }

        // Método para contar palabras en una cadena
        public int ContarPalabras(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
                return 0;

            return cadena.Split(' ').Length;
        }
    }
}
