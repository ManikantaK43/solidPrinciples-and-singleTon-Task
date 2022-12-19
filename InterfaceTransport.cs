using SolidPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SolidPrinciple
{



    interface InterfaceTransport
    {        //segregation of the task    
        void WorkerDetail(int EmpId, String EmpName, String EmpAddress);
    }



    interface InterfaceTransport1 { void CustomerDetails(String CustomerName, int CustomerNumber, String CustomerAddress); }



    interface INterfaceTransport2 { void OwnerDetails(int GstNumber, String Location, String Name, int ContactDetail); }
}



public class InterfaceImplementation : InterfaceTransport, InterfaceTransport1, InterfaceTransport2
{
    public int EmpId { get; private set; }



    public void CustomerDetails(string CustomerName, int CustomerNumber, string CustomerAddress)
    {        //throw new NotImplementedException();   
        Console.WriteLine(CustomerName = "abs");
        Console.WriteLine(CustomerNumber = 233293911);
        Console.WriteLine(CustomerAddress = "XYZ road mysuru");
    }



    public void OwnerDetails(int GstNumber, string Location, string Name, int ContactDetail)
    {        //throw new NotImplementedException();
        Console.WriteLine(EmpId = 123);
        Console.WriteLine(GstNumber = 1229300091);
        Console.WriteLine(Location = "Marathahalli");
        Console.WriteLine(Name = "uwosja");
        Console.WriteLine(ContactDetail = 8329371);



    }



    void InterfaceTransport.WorkerDetail(int EmpId, string EmpName, string EmpAddress)
    {
        // throw new NotImplementedException();
        Console.WriteLine(EmpId = 123);
        Console.WriteLine(EmpName = "XYZ");
        Console.WriteLine(EmpAddress = "asb road bangaluru");
    }




}