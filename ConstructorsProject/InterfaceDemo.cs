using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsProject
{
    internal class InterfaceDemo
    {
        public interface IDrawable
        {
            void Operation();

        }

        public class Addition : IDrawable
        {
            public void Operation()
            {
                Console.WriteLine(".....Perform Addition.....");
            }
        }

        public class Subtraction : IDrawable
        {
            public void Operation()
            {
                Console.WriteLine(".....Perform Subtraction.....");
            }
        }

        public class Multiplication : IDrawable
        {
            public void Operation()
            {
                Console.WriteLine(".....Perform Multiplication....");
            }
        }

    }
}

