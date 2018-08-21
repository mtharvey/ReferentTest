using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ThirdPartyTool;

namespace TestLib
{
    public class TestService
    {
        public string GetTestMessage()
        {
            var libMessage = MessageThing.GetMessage();
            var coreMessage = CoreTest.Thingy.SECRET_MESSAGE;
            return $"Lib: {libMessage};  Core: {coreMessage};";
        }
    }
}
