using System;
using System.Reflection;

namespace PractiseExamples
{
    [Customer(Id = 1249, Name = "Pavan")]
    class Program
    {

        
        public static void GetValues(Type t)
        {
            CustomerAttribute attr = (CustomerAttribute)Attribute.GetCustomAttribute(t, typeof(CustomerAttribute));

            if (attr == null)
            {
                Console.WriteLine("The Attribute Was Not Found");
            }
            else
            {
                Console.WriteLine(attr.Id);
            }
        }


        static void Main(string[] args)
        {
            Type T = Type.GetType("PractiseExamples.CustomerAttribute");
            Console.WriteLine(typeof(Program));
            GetValues(typeof(Program));

            
        }

    }
}
