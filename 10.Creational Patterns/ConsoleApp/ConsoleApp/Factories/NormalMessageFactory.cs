using ConsoleApp.Interfaces;
using ConsoleApp.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Factories
{
    internal class NormalMessageFactory : IMessageFactory
    {
        public IMessage CreateMessage() => new NormalMessage();
    }
}
