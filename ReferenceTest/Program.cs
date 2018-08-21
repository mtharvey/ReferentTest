using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLib.TestService service = new TestLib.TestService();
            Console.WriteLine(service.GetTestMessage());
            Console.WriteLine("Hit ENTER");
            Console.ReadLine();
        }
    }
}
