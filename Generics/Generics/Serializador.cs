using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Serializador
    {
        public static void Serializar(object obj)
        {
            StreamWriter sw = new StreamWriter(@$"C:\Cursos\Generics\Temp\{obj.GetType().Name}.txt");

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string objSerializado = serializador.Serialize(obj);

            sw.Write(objSerializado);
            sw.Close();
        }

        public static Classe Deserializar()
        {

            StreamReader sr = new StreamReader(@"C:\Cursos\Generics\Temp\(NomeDaClasse).txt");

        }



    }
}
