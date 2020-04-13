using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesInt
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation Example

           
            Console.WriteLine("Enter Year of birth");

             DateTime  Dob = DateTime.Parse(Console.ReadLine());

            var person = new Person(Dob);

            try
            {
                if (person.CalculateAge() <= 25)
                {
                    Console.WriteLine(person.CalculateAge());
                    Console.WriteLine("You are a young man");
                }
                else
                {
                    Console.WriteLine("Youre  too old oooo !!!");
                }
            }
            catch (Exception ex)
            {
               
            }

            var human = new Human();

            human.SetName("Japheth");

            Console.WriteLine(human.GetName());


            var kookie = new Cookie();

            kookie["name"] = "Blessing";

            Console.WriteLine(kookie["name"]);


            var text = new Text();
            text.Copy();
            text.Duplicate();
        }
    }
}
