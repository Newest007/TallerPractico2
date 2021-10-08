using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventasExpress
{
    // Esta clase será la que codificará/descodificará la cadena que le mandemos
    public static class Seguridad 
    {
        //Esta funcion encripta una cadena
        public static string Encriptar(this string cadenaAencriptar) 
        {
            //Aqui se almacenará la cadena ya encriptada
            string resultado = string.Empty; 
            byte[] encriptado = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            resultado = Convert.ToBase64String(encriptado);
            //Esta variable es la cadena ya encriptada
            return resultado; 
        }

        public static string DesEncriptar(this string cadenaNoEncript)
        {
            //Nuevamente esta será la cadena ya encrptada
            string resultado = string.Empty; 
            byte[] desencriptado = Convert.FromBase64String(cadenaNoEncript);
            resultado = System.Text.Encoding.Unicode.GetString(desencriptado);
            //Nos devolvera la cadena ya encriptada
            return resultado; 
        }

    }
}
