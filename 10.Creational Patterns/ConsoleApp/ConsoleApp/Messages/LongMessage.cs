using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Messages
{
    class LongMessage : IMessage
    {
        public string GetMessage() => "This is a long message";
    }
}
