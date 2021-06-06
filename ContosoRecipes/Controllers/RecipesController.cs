using ContosoRecipes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")] //    /api/recipes
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes([FromQuery] int count)

        {
            Recipe[] recipes = {
                new() {Title = "Oxtail" },
                new() {Title = "Curry Chicken" },
                new() {Title = "Dumplings" }

            };
            if (!recipes.Any())
                return NotFound();

            return Ok(recipes.Take(count));

        }

        [HttpPost]
        public ActionResult CreateNewRecipe([FromBody] Recipe newRecipe) {

            //validate and save to database
            bool badThingsHappended = false;

            if (badThingsHappended)
                return BadRequest();

            return Created("", newRecipe);
        }

        [HttpDelete("{id}")] // api/recipes/{id}
        public ActionResult DeleteRecipes(string id)
        {
            bool badThingsHappended = false;

            if (badThingsHappended)
                return BadRequest();
            return NoContent();
        }
    }
}
