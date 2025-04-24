using Microsoft.AspNetCore.Mvc;
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
    }
}
