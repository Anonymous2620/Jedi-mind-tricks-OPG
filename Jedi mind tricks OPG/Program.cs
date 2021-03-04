using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_mind_tricks_OPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> person = new Dictionary<string, int>();

            person.Add("Alex", 19);

            person["navn"] = 78;

            Console.WriteLine(person.First());
            
            Dictionary<string, bool> persons = new Dictionary<string, bool>()
            {
                { "Luke", true },
                { "Han", false },
                { "Chewbacca", false }
            };

            persons.Remove("Han");

            foreach (KeyValuePair<string, bool> item in persons)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }
            
            Console.ReadKey();
        }
    }
}
