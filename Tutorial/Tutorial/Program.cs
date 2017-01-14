using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console */
            Console.WriteLine("Hello World");

            Console.Write("Eingabe: ");
            string eingabe = Console.ReadLine();
            Console.WriteLine("Es wurde \"{0}\" eingegeben.", eingabe);


            /* Variables */

            // bool: true/false (4 Bytes)
            bool enable = false;
            Console.WriteLine("\nsizeof(bool): " + System.Runtime.InteropServices.Marshal.SizeOf(enable));

            // char (1 Byte)
            char grade = 'A';
            Console.WriteLine("\nsizeof(char): " + System.Runtime.InteropServices.Marshal.SizeOf(grade));

            // Integer (4 Bytes)
            int maxInt = int.MaxValue;
            Console.WriteLine("\nint with a max number of " + maxInt);
            Console.WriteLine("sizeof(int): " + System.Runtime.InteropServices.Marshal.SizeOf(maxInt));

            // Unsigned Integer
            UInt16 ui16Number = UInt16.MaxValue;
            Console.WriteLine("\nUInt16 with a max number of " + ui16Number);
            Console.WriteLine("sizeof(nUInt16): " + System.Runtime.InteropServices.Marshal.SizeOf(ui16Number));

            // Long (8 Bytes)
            long maxLong = long.MaxValue;
            Console.WriteLine("\nlong with a max number of " + maxLong);
            Console.WriteLine("sizeof(long): " + System.Runtime.InteropServices.Marshal.SizeOf(maxLong));

            // Decimal (16 Bytes)
            decimal maxDec = decimal.MaxValue;
            Console.WriteLine("\ndeciaml with a max number of " + maxDec);
            Console.WriteLine("sizeof(decimal): " + System.Runtime.InteropServices.Marshal.SizeOf(maxDec));

            // Float (4 Bytes, max: 3.4e+38 with 7 decimals of precision) 
            float maxFloat = float.MaxValue;
            Console.WriteLine("\nfloat with a max number of " + maxFloat);
            Console.WriteLine("sizeof(float): " + System.Runtime.InteropServices.Marshal.SizeOf(maxFloat));

            // Double (8 Bytes, max: 1.7e+308 with 15 decimals of precision)
            double maxDouble = double.MaxValue;
            Console.WriteLine("\ndouble with a max number of " + maxDouble);
            Console.WriteLine("sizeof(double): " + System.Runtime.InteropServices.Marshal.SizeOf(maxDouble));

            var anotherName = "Hans";



            int i = 0;
            i++;
            ++i;
            i--;
            --i;
            i += 3;
            i *= 10;
            i %= 13;

            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("\nMath.Abs(-10.5) = " + (Math.Abs(+number1)));
            Console.WriteLine("Math.Ceiling(10.5) = " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(10.5) = " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(10.5, 15) = " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(10.5, 15) = " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(10.5, 2) = " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(10.5) = " + (Math.Round(number1)));
            Console.WriteLine("Math.Sqrt(10.5) = " + (Math.Sqrt(number1)));


            Random rand = new Random();
            for (int ii = 0; ii < 5; ii++)
            {
                Console.WriteLine("Würfeln: " + (rand.Next(1, 7)));
                Console.ReadKey();
            }


            /* Relational Operators: > < >= <= == !=
             * 
             * Logical Operators: &&    AND  
             *                    ||    OR  
             *                    ^     
             *                    !     NOT
             */
            int age = 32;

            if ((age >= 5) && (age <= 13))
            {
                Console.WriteLine("bli");
            }
            else if ((age > 13) && (age < 18))
            {
                Console.WriteLine("bla");
            }
            else
            {
                Console.WriteLine("blub");
            }


            Console.WriteLine("!true = " + !true);

            switch (age)
            {
                case 0:
                    Console.WriteLine("bli");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("bla");
                    break;
                default:
                    Console.WriteLine("blub");
                    break;
            }

            // 22:00


            Console.ReadKey();
        }
    }
}
