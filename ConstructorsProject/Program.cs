using static ConstructorsProject.InterfaceDemo;

namespace ConstructorsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable drawable;
            drawable = new Addition();
            drawable.Operation();
            drawable = new Subtraction();
            drawable.Operation();
            drawable = new Multiplication();
            drawable.Operation();
        }
    }
}