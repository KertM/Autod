using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autod
{
    class Program
    {
        static void Main(string[] args)
        {
            var autod1 = new List<Auto>
            {
                new Auto(){Tootja = "RENAULT", Mudel = "SCENIC INTENS", Mootor = "1.5", kW = "81", Kütus = "Diisel", Värv = "Honey Gold" },
                new Auto(){Tootja = "CADILLAC", Mudel = "ATS PERFORMANCE", Mootor = "2.0 ", kW = "203", Kütus = "Bensiin", Värv = "Phantom Gray" },
                new Auto(){Tootja = "OPEL ", Mudel = "MOKKA X ENJOY", Mootor = "1.4", kW = "103", Kütus = "Bensiin", Värv = "Abalone White" },
                new Auto(){Tootja = "RENAULT", Mudel = "MEGANE", Mootor = "1.5", kW = "81", Kütus = "Diisel", Värv = "Flame Red" },
                new Auto(){Tootja = "SEAT", Mudel = "IBIZA XCELLENCE", Mootor = "1.0", kW = "85", Kütus = "Bensiin", Värv = "Mystic Magenta" },
                new Auto(){Tootja = "BMW", Mudel = "330Xi", Mootor = "3.0", kW = "170", Kütus = "Bensiin", Värv = "Silver" },
                new Auto(){Tootja = "Mercedes-Benz", Mudel = "ML 350", Mootor = "3.5", kW = "225", Kütus = "Bensiin", Värv = "Dark Brown" },
                new Auto(){Tootja = "Volkswagen", Mudel = "CC", Mootor = "1.4", kW = "118", Kütus = "Bensiin", Värv = "Black" },
                new Auto(){Tootja = "Lexus", Mudel = "GS 300", Mootor = "3.0", kW = "183", Kütus = "Bensiin", Värv = "Dark Greem" },
                new Auto(){Tootja = "Toyota", Mudel = "Auris Active", Mootor = "1.6", kW = "1598", Kütus = "Bensiin", Värv = "Red" },
                //new Auto(){Tootja = "", Mudel = "", Mootor = "", kW = "", Kütus = "", Värv = "" },
            };

            #region Kw järjestus

            #endregion

            #region o ja e täht

            #endregion

            #region mudel koosneb neljast tähest

            #endregion

            #region Kõige võimsam ja kõige nõrgem auto

            
            var a = autod1.Max();
            var b = autod1.Min();

            Console.WriteLine("Kõige võimsam auto: " + a + "\nKõige nõrgem auto: " + b);



            #endregion

            Console.ReadLine();

        }
    }
}
