using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_UML
{
    internal class Customer
    {
        private string inputName;

        public Customer(string inputName)
        {
            Name = inputName;
        }

        public string Name
        {
            get { return inputName; }
            set { inputName = value; }
        }

        public void Loan()
        {
            Console.WriteLine(Name + " lånade föremålet.");
        }
        public void Return()
        {
            Console.WriteLine(Name + " Lämnade tillbaka föremålet.");
        }
    }
}
