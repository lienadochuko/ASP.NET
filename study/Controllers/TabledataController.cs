using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using study.Data;
using study.Models;

namespace study.Controllers
{
    public class TabledataController : Controller
    {
        public readonly ApplicationDbContext _db;

        public TabledataController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        { 
            IEnumerable<Tabledata> objectTabledataList = _db.Tabledatas;
            return View(objectTabledataList);
        }

        //GET
        public IActionResult Create()
        { 
           
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tabledata obj)
        {
           if (ModelState.IsValid)
            {
                _db.Tabledatas.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
