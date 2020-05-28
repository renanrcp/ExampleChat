using Microsoft.AspNetCore.Mvc;

namespace ExampleChat.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        public MessagesController()
        { }

        [HttpGet]
        public IActionResult GetLastMessages()
            => Ok();
    }
}