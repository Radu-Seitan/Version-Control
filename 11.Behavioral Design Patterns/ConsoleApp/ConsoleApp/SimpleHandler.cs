using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SimpleHandler : IRequestHandler<SimpleRequest>
    {
        public Task<Unit> Handle(SimpleRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine(request.Message);
            return Unit.Task;
        }
    }
}
