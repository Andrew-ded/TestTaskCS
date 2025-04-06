using App;
using Domain;
using Domain.Interface;
using Domain.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestTask.Controllers.UI
{
    public class HomeController : Controller
    {
        private readonly ISubdivisionsService _service;
       
        public HomeController(ISubdivisionsService service)
        {
            _service = service;
            
        }
        
        

        public async Task<IActionResult> Index()
        {
            var subdivisions = await _service.GetAllSubdivisions();
            
           
            return View(subdivisions);
        }

        public async Task<IActionResult> Department(int id)
        {
            var subdivision = await _service.GetSubdivisions(id);
            ViewBag.TotalEmployees = Func.CountEmployees(subdivision);
            if (subdivision == null)
            {
                return NotFound();
            }

            return View(subdivision);
        }

        // POST: HomeController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
