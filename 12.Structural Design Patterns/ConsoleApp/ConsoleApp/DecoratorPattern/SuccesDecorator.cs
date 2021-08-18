using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DecoratorPattern
{
    class SuccesDecorator : MessageDecorator
    {
        public SuccesDecorator(IMessage wrappedMessage) : base(wrappedMessage)
        {

        }

        public override void GetMessage()
        {
            base.GetMessage();
            Console.WriteLine("Message delivered succesfully!");
        }
    }
}
