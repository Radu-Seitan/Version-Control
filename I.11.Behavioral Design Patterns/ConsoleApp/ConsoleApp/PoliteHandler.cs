using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PoliteHandler : IRequestHandler<PoliteRequest>
    {
        public Task<Unit> Handle(PoliteRequest request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Would you please: {request.Message}");
            return Unit.Task;
        }
    }
}
