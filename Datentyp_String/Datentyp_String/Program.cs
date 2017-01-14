using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.String text = "Text";
            string text = "Text";

            char zeichen = text[2];

            // immutable -> nicht veränderbar
            //text[2] = 's';

            string hallo = "Hallo";
            string welt = "Welt";
            string halloWelt = hallo + " " + welt;

            string neueZeile = "\n in einer \"neuen\" Zeile \tDies ist ein Backslash \\";
            string pfad = "C:\\temp";
            string verbatimString = @"C:\temp";
        }
    }
}
