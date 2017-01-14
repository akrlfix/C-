using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* RM auf C# Projekt im Projektmappen-Explorer -> Eigenschaften ->  Einstellungen ...*/

namespace KonfigurationSpeichern
{
    class Program
    {
        static void Main(string[] args)
        {
            int intParameter = Properties.Settings.Default.intParameter;
            string parameter = Properties.Settings.Default.stringParameter;

            Console.WriteLine("intParameter: " + intParameter);
            Console.WriteLine("stringParameter: " + parameter);

            parameter = RequestParameterFromUser();
        }

        private static string RequestParameterFromUser()
        {
            string parameter = Properties.Settings.Default.stringParameter;

            Console.WriteLine("*** Parameter Eingabe ***");
            Console.Write("Soll der gespeicherte Parameter \"{0}\" verwendet werden? (ja/nein): ", parameter);
            string eingabe = Console.ReadLine();

            if (eingabe.ToLower().Equals("nein"))
            {
                Console.Write("Bitte Parameter eingeben: ");
                parameter = Console.ReadLine();

                Properties.Settings.Default.stringParameter = parameter;
                Properties.Settings.Default.Save();
            }

            return parameter;
        }
    }
}
