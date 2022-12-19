using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SolidPrinciple
{
    class LiskovTransport
    {





        public virtual String MainBranch()
        {
            return "Bangaluru";
        }
    }





    class SubBranch : LiskovTransport
    {
        public override String MainBranch()
        {
            return "Yaswantpur";
        }
    }







}