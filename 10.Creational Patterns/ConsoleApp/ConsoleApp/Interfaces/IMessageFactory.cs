using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    interface IMessageFactory
    {
        IMessage CreateMessage();
    }
}
