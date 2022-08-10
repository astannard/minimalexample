using System;
using FastEndpoints;

namespace example.Greet
{
    public class FarewellEndpoint : Endpoint<EmptyRequest, FarewellResponse>
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/bye");
            AllowAnonymous();
        }

        public override async Task HandleAsync(EmptyRequest r, CancellationToken c)
        {
            await SendAsync(new FarewellResponse { Message=$"Goodbye"});
        }
    }

}

