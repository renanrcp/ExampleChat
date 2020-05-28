using System;
using System.Threading.Tasks;
using MariSocketMiddleware.Entities.MariEventArgs;
using MariSocketMiddleware.Services;
using Microsoft.AspNetCore.Http;

namespace ExampleChat.Middlewares
{
    public class WebsocketService : MariWebSocketService
    {
        public WebsocketService()
        {
            OnOpen += OnOpenAsync;
            OnMessage += OnMessageAsync;
        }

        public override string Path { get; set; }

        public override Task<bool> AuthorizeAsync(HttpContext context)
            => Task.FromResult(true);

        private Task OnOpenAsync(OpenEventArgs arg)
            => Task.CompletedTask;

        private Task OnMessageAsync(MessageEventArgs arg)
            => Task.CompletedTask;
    }
}