using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using System.Collections.Generic;
using System.Linq;
using System;
// USING DIRECTIVES HERE

namespace AnimalShelter.Controllers
{
  public class AnimalsController : Controller
  {
    private readonly AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    public ActionResult Index() // /animals - GET
    {
      List<Animal> model = _db.Animals.ToList();
      return View(model);
      
    }

    public ActionResult Details(int id) // does need view. /animals/details - GET
    {
      // SELECT * FROM animals WHERE Id = id;
      Animal foundAnimal = _db.Animals.FirstOrDefault(animal => animal.Id == id);
      return View(foundAnimal);
    }

    public ActionResult Create() // animals/create - GET
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Animal animal) // animals/create - POST
    { 
      animal.DateOfAdmittance = DateTime.Now.ToString("dd/MM/yyyy");
      _db.Animals.Add(animal); //Add to our C# object that represents our database
      _db.SaveChanges(); // Update our actual database with the current state of our C# db representation
      return RedirectToAction("Index");
    }

    // Edit/Update
    // GET animal to UPDATE
    public ActionResult Edit(int id) // animals/edit - GET
    {
      Animal foundAnimal = _db.Animals.FirstOrDefault(animal => animal.Id == id);
      return View(foundAnimal);
    }

    [HttpPost]
    public ActionResult Edit(Animal animal)
    {
      _db.Animals.Update(animal);
      _db.SaveChanges();
    }
  }
}


