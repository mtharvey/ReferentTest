using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
    public class TestService
    {
        public string GetTestMessage() { return "This is in the library... " + CoreTest.Thingy.SECRET_MESSAGE; }
    }
}
