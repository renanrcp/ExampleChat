using System.Threading.Tasks;
using MariSocketMiddleware.Services;
using Microsoft.AspNetCore.Http;

namespace ExampleChat.Middlewares
{
    public class WebsocketService : MariWebSocketService
    {
        public WebsocketService()
        {
        }

        public override string Path { get; set; }

        public override Task<bool> AuthorizeAsync(HttpContext context)
            => Task.FromResult(true);
    }
}