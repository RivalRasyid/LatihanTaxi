using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    public class Taxi
    {
        public string DriveName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriveName);
            if (OnDuty == true)
            {
                Console.WriteLine("OnDuty: Yes");
            }
            else if (OnDuty = false)
            {
                Console.WriteLine("OnDuty: No");
            }
            Console.WriteLine("Number Of Passenger: {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\nRival sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("Rival selesai mengantar penumpang");
        }
    }
}
