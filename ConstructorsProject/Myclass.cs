using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsProject
{
     public class Myclass
     {
        public int publicField;            // Accessible from anywhere
        private string privateField;       // Accessible only within this class
        protected bool protectedField;     // Accessible within this class and derived classes
        internal double internalField;     // Accessible within the same assembly

        public void PublicMethod()
        {
            Console.WriteLine("Public method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal method");
        }
    }

    public class DerivedClass : Myclass
    {
        public void AccessProtectedField()
        {
            protectedField = true;           
        }

        public void AccessProtectedMethod()
        {
            ProtectedMethod();               // Accessing protected method from derived class
        }
    }
}

