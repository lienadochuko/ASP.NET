using Microsoft.AspNetCore.Mvc;
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
    }
}
