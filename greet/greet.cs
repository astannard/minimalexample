using System;
using FastEndpoints;

namespace example.Greet
{
    public class GreetEndpoint : Endpoint<EmptyRequest, GreetResponse>
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("/");
            AllowAnonymous();
        }

        public override async Task HandleAsync(EmptyRequest r, CancellationToken c)
        {
            await SendAsync(new GreetResponse { Message=$"Hello"});
        }
    }

}

