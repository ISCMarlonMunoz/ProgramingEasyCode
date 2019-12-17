using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgramingEasy.Areas.Identity.Data;
using ProgramingEasy.Data;
using ProgramingEasy.Models;

namespace ProgramingEasy.Controllers
{
    public class HomeController : Controller
    {
        public readonly ProgramingEasyContext _context;
        public readonly UserManager<ProgramingEasyUser> _userManager;

        private readonly ProgramingEasyDBContext _contextDB;

        public HomeController(ProgramingEasyContext context, UserManager<ProgramingEasyUser> userManager, ProgramingEasyDBContext contextDB)
        {
            _context = context;
            _userManager = userManager;

            _contextDB = contextDB;
        }
    

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        
        public IActionResult Examen()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult MenuAdmin()
        {
            return View();
        }

        public IActionResult ExamenMedio()
        {
            return View();
        }

        public IActionResult ExamenAvanzado()
        {
            return View();
        }




        //GET
        [HttpPost]
        public async Task <IActionResult> Contact([Bind("Id_calificacion,calificacion")] Calificaciones calificaciones)
        {
            //CALIFICACION
            if (ModelState.IsValid)
            {
                _contextDB.Add(calificaciones);
                await _contextDB.SaveChangesAsync();
                return RedirectToAction(nameof(Contact));
            }

            //ROL ID

                if (User.Identity.IsAuthenticated)
            {
                var user = _userManager.GetUserAsync(User);
                ViewBag.RolID = user.Result.RolID;
              
            }
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Chat()
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
