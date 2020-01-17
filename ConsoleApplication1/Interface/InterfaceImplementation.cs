using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Interface
{
    interface ICustomer
    {
        //int Id;
        //public void Print();
        void Print();
    }
    public class Customer : ICustomer
    {
        public void Print()
        {
            throw new NotImplementedException();
        }
    }
    class InterfaceImplementation
    {
    }
}
