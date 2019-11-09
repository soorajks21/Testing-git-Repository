using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
  [Route("api/[Controller]")]
  public class TestController : Controller
  {
    [HttpGet("/api/values")]
    public IEnumerable<string> Get()
    {
      return new string[] { "a", "b" };
    }
    [HttpPost("/api/values")]
    public void postvalue(string c)
    {
      string s = c;
    }
  }

}

