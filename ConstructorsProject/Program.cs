namespace ConstructorsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the default constructor
            Car defaultCar = new Car();
            defaultCar.DisplayCarInfo();  

            // Using the parameterized constructor
            Car hondaCivic = new Car("Honda", "Civic", 2022);
            hondaCivic.DisplayCarInfo();  

            // Using the copy constructor
            Car copiedCar = new Car(hondaCivic);
            copiedCar.DisplayCarInfo();
        }
    }
}