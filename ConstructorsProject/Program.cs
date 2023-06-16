using static ConstructorsProject.InterfaceDemo;

namespace ConstructorsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Myclass myObj = new Myclass();
            myObj.publicField = 10;           // Accessing public field
            myObj.PublicMethod();             // Accessing public method

            // The following lines will cause compilation errors
            // myObj.privateField = "private";     // Cannot access private field outside the class
            // myObj.PrivateMethod();              // Cannot access private method outside the class

            DerivedClass derivedObj = new DerivedClass();
            derivedObj.AccessProtectedField();    // Accessing protected field from derived class
            derivedObj.AccessProtectedMethod();   // Accessing protected method from derived class

            // The following lines will cause compilation errors
            // derivedObj.protectedField = true;     // Cannot access protected field outside the class hierarchy
            // derivedObj.ProtectedMethod();         // Cannot access protected method outside the class hierarchy
        }
    }

}

