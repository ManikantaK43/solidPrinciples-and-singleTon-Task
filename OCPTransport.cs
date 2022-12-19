using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SolidPrinciple
{
    class OCTransport
    {
        double GetAmount;





        public double TotalAmount(int padAmt, string Area)
        {
            if (Area.Equals("Brookefield"))
            {
                GetAmount = padAmt * 0.150;
            }
            else if (Area.Equals("CMR Engineering college"))
            {
                GetAmount = padAmt * 0.130;
            }
            else if (Area.Equals("Marathahalli"))
            {
                GetAmount = padAmt * 0.200;
            }
            else if (Area.Equals("Banashankari"))
            {
                GetAmount = padAmt * 0.300;
            }
            else
            {
                Console.WriteLine("Only this 4 spots our services available");
            }
            return GetAmount;



        }
    }
}