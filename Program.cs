using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string > registro = new Dictionary<string, string>();

            registro.Add("Mar_45","admin485");
            registro.Add("Leon_admin", "pas_49424");
            registro.Add("Brisa_lop", "l@202605");
            registro.Add("Marta45", "ma#199526");
            registro.Add("Enrique*5","#200514@");

            string BuscarUsu = "Brisa_lop";

            if (registro.ContainsKey(BuscarUsu))
            {
                string password = registro[BuscarUsu];
                Console.WriteLine(" la contraseña del usuario: " + BuscarUsu + " es: " + password);
            }
            else
            {
                Console.WriteLine(" el usuario no existe");

            }


        }
    }
}
