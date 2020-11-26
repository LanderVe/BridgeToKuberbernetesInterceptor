using BridgeToKuberbernetesInterceptor.Front.Models;
using BridgeToKuberbernetesInterceptor.Front.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeToKuberbernetesInterceptor.Front.Controllers
{
  public class HomeController : Controller
  {
    private readonly IBackHttpClient backHttpClient;

    public HomeController(IBackHttpClient backHttpClient)
    {
      this.backHttpClient = backHttpClient;
      this.backHttpClient = backHttpClient;
    }

    public async Task<IActionResult> Index()
    {
      ViewBag.Value = await backHttpClient.GetValueAsync(1);
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
