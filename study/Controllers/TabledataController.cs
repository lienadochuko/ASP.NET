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
            if (obj.Name == obj.Department || obj.Name == obj.DisplayOrder.ToString() || obj.DisplayOrder.ToString() == obj.Department)
            {
                ModelState.AddModelError("CustomError", "pls make sure the name, department and order do not match");
            }
            if (obj.Name == obj.Department && obj.Name == obj.DisplayOrder.ToString() && obj.DisplayOrder.ToString() == obj.Department)
            {
                ModelState.AddModelError("CustomError", "pls make sure the name, department and order do not match");
            }
            if (ModelState.IsValid)
            {
                _db.Tabledatas.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "TableData created successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var modelFromDb = _db.Tabledatas.Find(id);
            //use either of the lines below if its is not a primary key
            //var model = _db.Tabledatas.FirstOrDefault(x => x.Id == id);
            //var model = _db.Tabledatas.SingleOrDefault(x => x.Id == id);

            if (modelFromDb == null)
            {
                return NotFound();
            }

            return View(modelFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tabledata obj)
        {
            if (obj.Name == obj.Department || obj.Name == obj.DisplayOrder.ToString() || obj.DisplayOrder.ToString() == obj.Department)
            {
                ModelState.AddModelError("CustomError", "pls make sure the name, department and order do not match");
            }
            if (obj.Name == obj.Department && obj.Name == obj.DisplayOrder.ToString() && obj.DisplayOrder.ToString() == obj.Department)
            {
                ModelState.AddModelError("CustomError", "pls make sure the name, department and order do not match");
            }
            if (ModelState.IsValid)
            {
                _db.Tabledatas.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "TableData edited successfully";
                return RedirectToAction("Index");
            }
            TempData["success"] = null;
            return View(obj);
        }


        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var modelFromDb = _db.Tabledatas.Find(id);
            //use either of the lines below if its is not a primary key
            //var model = _db.Tabledatas.FirstOrDefault(x => x.Id == id);
            //var model = _db.Tabledatas.SingleOrDefault(x => x.Id == id);

            if (modelFromDb == null)
            {
                return NotFound();
            }

            return View(modelFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Tabledata obj)
        {

            _db.Tabledatas.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = ("TableData deleted successfully");
                return RedirectToAction("Index");

        }
    }
}
