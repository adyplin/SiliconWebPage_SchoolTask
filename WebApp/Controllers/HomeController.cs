using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using WebApp.ViewModels;

namespace WebApp.Controllers;

public class HomeController(HttpClient httpClient) : Controller
{
    private readonly HttpClient _httpClient = httpClient;

    public IActionResult Index()
    {
        ViewData["Title"] = "Ultimate Task Management Assistant";

        return View();
    }

    [Route("/error")]

    public IActionResult Error404(int statusCode) => View();



    public async Task<IActionResult> Subscribe (SubscribeViewModel model)
    {
        if (ModelState.IsValid)
        {
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7253/api/subscribe", content);
            if (response.IsSuccessStatusCode)
            {
                TempData["StatusMessage"] = "You are now subscribed";
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
            {
                TempData["StatusMessage"] = "You're already subscribed";
            }

        }
        else
        {
            TempData["StatusMessage"] = "Invalid email address";
        }

        return RedirectToAction("Index", "Home", "subscribe");
    }

}
