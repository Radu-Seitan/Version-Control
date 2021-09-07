using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Messages
{
    class ShortMessage : IMessage
    {
        public string GetMessage() => "msg";
    }
}
