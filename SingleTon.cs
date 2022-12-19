using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Solid



/*
class program{
static void Main(String[] args){
SingleTon obj1=SingleTon.MyObject();
obj1.MyObject();
SingleTon obj2=SingleTon.MyObject(); here is not create the new memory space in the memory
obj2.MyObject();
}
}
*/
{
    sealed class SingleTon // class can't be inherit
    {
        private SingleTon()//with private construtor we're avoiding the creation of object
        {



        }





        public static SingleTon CreateObject = null;





        public static SingleTon MyObject()
        {
            if (CreateObject == null)
            {
                return new SingleTon();//each time the condition become true it'll create an obj
            }
            return CreateObject;
        }





        public static void GetDetails()
        {
            Console.WriteLine("this is kinda Singleton method");
            Console.ReadLine();
        }
    }
}

