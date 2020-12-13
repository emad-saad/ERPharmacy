using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sehetak.Models;
using Microsoft.AspNetCore.Http;
namespace sehetak.Controllers
{
    public class HomeController : Controller
    {
        private readonly SOFTECHDB9Context _context;

        public HomeController(SOFTECHDB9Context context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Purchase()
        {
            return View();
        }

        public IActionResult Returns()
        {
            return View();
        }
        public IActionResult EzenEstlamAssnaf()
        {
            return View();
        }
        public IActionResult TalabSarfAsnaf()
        {
            return View();
        }

        public IActionResult ItemCard()
        {



            List<Itemsproducers> cl = new List<Itemsproducers>();
            cl = (from c in _context.Itemsproducers select c).ToList();
           
            ViewBag.items = (from item in cl
                             select new SelectListItem
                             {
                                 Text = item.Itemproducername,
                             });
            ///////////////////////////////////////////////////////////////////////المنشأ
            List<Itemsorigin> itemorg = new List<Itemsorigin>();
            itemorg = (from c in _context.Itemsorigin select c).ToList();

            ViewBag.itemsorig = (from item in itemorg
                             select new SelectListItem
                             {
                                 Text = item.Itemoriginname,
                             });
            ///////////////////////////////////////////////////////////////////////العبوة
            List<Itemsunits> itemsunits = new List<Itemsunits>();
            itemsunits = (from c in _context.Itemsunits select c).ToList();

            ViewBag.itemsunits = (from item in itemsunits
                                 select new SelectListItem
                                 {
                                     Text = item.Unitname,
                                 });
            ///////////////////////////////////////////////////////////////////////طبيعة
            List<Itemsclassif> itemsclassif = new List<Itemsclassif>();
            itemsclassif = (from c in _context.Itemsclassif select c).ToList();

            ViewBag.itemsclassif = (from item in itemsclassif
                                    select new SelectListItem
                                  {
                                      Text = item.Classifnamearabic,
                                  });
            return View();
            
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Login(string Username, string Password)
        {
            string _password = SecuritySystem.Encrypt(Password);
            var query = "SELECT * FROM [dbo].[users] where userid = '" + Username + "' and userpassword LIKE '" + _password + "' ";
            var user = await _context.Users.FromSql(query).ToListAsync();
            //var user = await _context.Users
            //    .FirstOrDefaultAsync(x => x.Userid == Username && x.Userpassword == _password);
            if (user.Count() == 0)
            {
                return View("Index");
            }
            else
            {
                return View();
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
