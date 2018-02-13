// using Microsoft.AspNetCore.Mvc;
// using PingPong.Models;
// using System.Collections.Generic;
//
// namespace PingPong.Controllers
// {
//   public class PingPongController : Controller
//   {
//     [HttpGet("/")]
//     public ActionResult Index()
//     {
//       return View();
//     }
//
//     [HttpPost("/results")]
//     public ActionResult CreateForm()
//     {
//       PingPongGenerator newPingPongGenerator = new PingPongGenerator(
//       Request.Form["pingPongNumber"]);
//       List<int> model = PingPongGenerator.GetAll();
//       return View("Results", model);
//     }
//   }
// }
