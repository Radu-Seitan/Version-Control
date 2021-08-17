using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Messages
{
    class NormalMessage : IMessage
    {
        public string GetMessage() => "Message";
    }
}
