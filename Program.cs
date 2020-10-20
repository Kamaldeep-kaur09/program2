using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeExceptionHandler
{
    class ProgramException
    {
        static void Main(string[] args)
        {
            try
            {
                int result = CheckAge();
                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (CustomAge Age1)
            {

                Console.WriteLine(Age1.Message);
            }


        }
        static int CheckAge()
        {
            Console.WriteLine("Enter age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                throw new Exception("Age should be more than 18");
            }
            return age;
        }

    }
    public class CustomAge : Exception
    {
        public CustomAge(string message) : base(message)
        {

        }
    }
}

