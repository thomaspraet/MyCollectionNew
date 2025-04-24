using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyCollection.web.Data;
using MyCollection.web.Models;

namespace MyCollection.web.Controllers
{
    public class ArtistController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ArtistController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Artist> objArtistList = _db.Artists.ToList();
            return View(objArtistList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Artist obj)
        {
            _db.Artists.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "Artist");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Artist? artistFromDb = _db.Artists.FirstOrDefault(u => u.Id == id);
            if (artistFromDb == null)
            {
                return NotFound();
            }
            return View(artistFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Artist obj)
        {
            _db.Artists.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "Artist");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Artist? artistFromDb = _db.Artists.FirstOrDefault(u => u.Id == id);
            if (artistFromDb == null)
            {
                return NotFound();
            }
            return View(artistFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Artist? obj = _db.Artists.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Artists.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index", "Artist");

        }
    }
}
