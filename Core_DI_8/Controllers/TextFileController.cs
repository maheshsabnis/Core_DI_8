using Core_DI_8.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_DI_8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextFileController : ControllerBase
    {
        IFileOperation fileOp;

        public TextFileController([FromKeyedServices("Text")]IFileOperation op)
        {
            fileOp = op;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            var data = fileOp.ReadFile("myfile.txt");
            return Ok($"Data is read from Text File : {data}");
        }

        [HttpPost]
        public IActionResult Post(string data)
        {
            fileOp.WriteFile("myfile.txt", data);
            return Ok($"Data is Written to Text File : {data}");
        }
    }
}
