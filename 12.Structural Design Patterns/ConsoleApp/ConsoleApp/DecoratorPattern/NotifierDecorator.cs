using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DecoratorPattern
{
    class NotifierDecorator : MessageDecorator
    {
        public NotifierDecorator(IMessage wrappedMessage) : base(wrappedMessage)
        {

        }

        public override void GetMessage()
        {
            Console.WriteLine("Pending message");
            base.GetMessage();        
        }
    }
}
