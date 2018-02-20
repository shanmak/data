using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("","","","");
            Gender m1 = new Gender("mani", "male", "india", "83134567");
            Gender m2;
            m2 = new Gender("thama", "female", "singapore", "6543289");
           Console.WriteLine( m1.DIsplay());
            Console.WriteLine();
            Console.WriteLine(m2.DIsplay());
            Console.WriteLine();
            m2.Name = "thaya";
            Console.WriteLine(m2.DIsplay());
            
        }
    }
}
