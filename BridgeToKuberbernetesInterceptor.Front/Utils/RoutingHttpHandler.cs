using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BridgeToKuberbernetesInterceptor.Front.Utils
{
  public class RoutingHttpHandler : DelegatingHandler
  {
    private readonly IHttpContextAccessor httpContextAccessor;

    public RoutingHttpHandler(IHttpContextAccessor httpContextAccessor)
    {
      this.httpContextAccessor = httpContextAccessor;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage outgoingRequest, CancellationToken cancellationToken)
    {
      var incomingRequest = httpContextAccessor.HttpContext.Request;

      // Propagate the routing header
      if (incomingRequest.Headers.ContainsKey("kubernetes-route-as"))
      {
        outgoingRequest.Headers.Add("kubernetes-route-as", incomingRequest.Headers["kubernetes-route-as"] as IEnumerable<string>);
      }
      return base.SendAsync(outgoingRequest, cancellationToken);
    }
  }
}
