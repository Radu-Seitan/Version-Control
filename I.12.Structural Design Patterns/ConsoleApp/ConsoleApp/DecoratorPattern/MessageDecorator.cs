using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DecoratorPattern
{
    class MessageDecorator : IMessage
    {
        private IMessage _wrappedMessage;

        public MessageDecorator(IMessage wrappedMessage)
        {
            _wrappedMessage = wrappedMessage;
        }

        public virtual void GetMessage()
        {
            _wrappedMessage.GetMessage();
        }
    }
}
