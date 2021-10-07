using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    public static class Encriptacion // Esta clase será la que codificará/descodificará la cadena que le mandemos
    {
        public static string Codificar(this string cadenaNoEncript) //Esta funcion encripta una cadena
        {
            string cadenaencript = string.Empty; //Aqui se almacenará la cadena ya encriptada
            byte[] encriptado = System.Text.Encoding.Unicode.GetBytes(cadenaNoEncript);
            return cadenaencript; //Esta variable es la cadena ya encriptada
        }

        public static string Descodificar(this string cadenaNoEncript)
        {
            string cadenaencript = string.Empty; //Nuevamente esta será la cadena ya encrptada
            byte[] descod = Convert.FromBase64String(cadenaNoEncript);
            cadenaencript = System.Text.Encoding.Unicode.GetString(descod);
            return cadenaencript; //Nos devolvera la cadena ya encriptada
        }

    }
}
