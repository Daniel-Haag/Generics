using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Generics
{
    internal class Serializador
    {
        public static void Serializar<T>(T obj)
        {
            StreamWriter sw = new StreamWriter(@$"C:\Cursos\Generics\Temp\{typeof(T).Name}.txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();
        }

        public static T Deserializar<T>()
        {
            StreamReader sr = new StreamReader(@$"C:\Cursos\Generics\Temp\{typeof(T).Name}.txt");
            string conteudo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();

            var obj = serializador.Deserialize<T>(conteudo);

            return obj;
        }
    }
}
