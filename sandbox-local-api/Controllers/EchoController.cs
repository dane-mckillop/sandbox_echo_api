using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace sandbox_local_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EchoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] 
    Dictionary<string, string> query)
    {
        var values = query.Values.Where(v => !string.IsNullOrEmpty(v)).ToArray();

        if (values.Length == 1)
        {
            return Ok(new { data = values[0] });
        }

        return Ok(new { data = values });
    }
}