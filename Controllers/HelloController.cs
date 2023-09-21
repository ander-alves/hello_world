using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace helloWorld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World";
        }

        [HttpGet("/meunome")]
        public string MeuNome()
        {
            return "Chamando URI /meunome";
        }
    }
}
