using AdoptionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdoptionMVC.Controllers
{
    public class AdoptionController : Controller
    {
        AdoptionDbContext dbContext = new AdoptionDbContext();
        [HttpGet]
        public IActionResult Index(string Breed)
        {
            List<Animal> Animals = new List<Animal>();
            //Animal result = dbContext.Animals.FirstOrDefault(p => p.Breed == Breed);
            return View(Animals);
        }
        [HttpPost]
        public IActionResult Breed()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Details(string Breed)
        {
            return View();
        }
        [HttpDelete]
        public IActionResult DeleteDog(string name)
        {

            Animal result = dbContext.Animals.Find(name);
            dbContext.Animals.Remove(result);
            dbContext.SaveChanges();

            return RedirectToAction("Details");
        }
        [HttpPost]
        public IActionResult AddDog(string image, string name, string description, string breed, int age) //will not break if I use [HttpGet] but doesn't go to add page???
        {
            List<Animal> Animals = new List<Animal>();
            dbContext.Animals.AddRange();
            dbContext.SaveChanges();
            return RedirectToAction("Index");

        }
            public IActionResult Add()
        {

            return View();
        }
    }
}
