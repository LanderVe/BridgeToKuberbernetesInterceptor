using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeToKubernetesInterceptor.Back.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      if (Request.Headers.ContainsKey("kubernetes-route-as"))
      {
        return $"kubernetes-route-as: {Request.Headers["kubernetes-route-as"]}";
      }
      return "no value for kubernetes-route-as";
    }
  }
}
