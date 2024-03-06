using Core_DI_8.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_DI_8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CSVFileController : ControllerBase
    {
        IFileOperation fileOp;

        public CSVFileController([FromKeyedServices("CSV")]IFileOperation op)
        {
            fileOp = op;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = fileOp.ReadFile("myfile.csv");
            return Ok($"Data is read from CSV File : {data}");
        }

        [HttpPost]
        public IActionResult Post(string data)
        {
            fileOp.WriteFile("myfile.csv", data);
            return Ok($"Data is Written to CSV File : {data}");
        }
    }
}
