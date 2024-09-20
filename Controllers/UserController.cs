using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Taxi.Models;
using Taxi.Data;

namespace Taxi.Controllers;
 
public class UserController : Controller
{
     private readonly TaxiContext _context;

        public UserController(TaxiContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
}