using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SolidPrinciple
{
    class OCPTransport1
    {



    }
    public interface Location
    {
        bool Area(string AreaName);
        double GetAmt(int PadAmt);
    }





    class Brookefield : Location
    {
        public bool Area(string AreaName)
        {
            return "Brookefield".Equals(AreaName);
        }
        public double GetAmt(int PadAmt)
        {
            return PadAmt * 0.150;
        }
    }





    class CmrEngineeringCollege : Location
    {
        public bool Area(string AreaName)
        {
            return "CmrEngineeringCollege".Equals(AreaName);
        }
        public double GetAmt(int PadAmt)
        {
            return PadAmt * 0.130;
        }
    }





    class Marathahalli : Location
    {
        public bool Area(string AreaName)
        {
            return "Marathahalli".Equals(AreaName);
        }
        public double GetAmt(int PadAmt)
        {
            return PadAmt * 0.200;
        }
    }





    class Banashankari : Location
    {
        public bool Area(string AreaName)
        {
            return "Banashankari".Equals(AreaName);
        }
        public double GetAmt(int PadAmt)
        {
            return PadAmt * 0.300;
        }
    }







}