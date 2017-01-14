using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datentyp_TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen von TimeSpan Objekten
            Console.WriteLine("### Erstellen von TimeSpan Objekten! ###");

            // 1 - Konstruktor
            TimeSpan zeitSeitTagesbeginn = new TimeSpan(17, 03, 49);

            // 2 - statische From-Methoden
            TimeSpan zeitVonMitternachtBisFruehstueck = TimeSpan.FromHours(10);

            // 3 - Rechnen mit DateTime Objekten
            TimeSpan zeitSeitLetzterAktion = new DateTime(2017, 1, 1, 12, 0, 0) - DateTime.Now;


            Console.WriteLine(zeitSeitTagesbeginn);
            Console.WriteLine(zeitVonMitternachtBisFruehstueck);
            Console.WriteLine(zeitSeitLetzterAktion);

            // Rechnen mit TimeSpan
            Console.WriteLine("### Rechnen mit TimeSpan ###");

            TimeSpan eineStunde = TimeSpan.FromHours(1.0);
            TimeSpan zehnMillisekunden = TimeSpan.FromMilliseconds(10.0);
            TimeSpan summe = eineStunde.Add(zehnMillisekunden);
            TimeSpan differenz = eineStunde - zehnMillisekunden;

            Console.WriteLine(summe);
            Console.WriteLine(differenz);

            // Minutes vs. TotalMinutes
            Console.WriteLine("### Minutes vs. TotalMinutes ###");

            TimeSpan zeitSeitIrgendwas = new TimeSpan(2, 30, 00);

            Console.WriteLine(zeitSeitIrgendwas.Minutes);           // 30
            Console.WriteLine(zeitSeitIrgendwas.TotalMinutes);      // 150

            // String nach TimeSpan konvertieren
            Console.WriteLine("### String nach TimeSpan konvertieren ###");

            string gueltigeDauerString = "02:45:30";
            string ungueltigeDauerString = "02:10:80";

            TimeSpan gueltigeDauer;
            bool ret = TimeSpan.TryParse(gueltigeDauerString, out gueltigeDauer);        // wenn konvertierung erfolgreich: return true
            Console.WriteLine(ret);
            Console.WriteLine(gueltigeDauer);

            TimeSpan ungueltigeDauer;
            ret = TimeSpan.TryParse(ungueltigeDauerString, out ungueltigeDauer);
            Console.WriteLine(ret);
            Console.WriteLine(ungueltigeDauer);

            Console.ReadKey();
        }
    }
}
