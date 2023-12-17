using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;



namespace MealStoreApi.Controllers
{
    [ApiController]
    [Route("api/meals")]
    public class MealsController : ControllerBase
    {
        // private readonly List<Meal> meals = new List<Meal>
         private readonly List<Meal> meals = new List<Meal>
        {
            new Meal (1, "Chicken Fajitas","https://assets.bonappetit.com/photos/57b1646653e63daf11a4f061/master/w_1280,c_limit/cilantro-lime-chicken-fajitas-with-grilled-onions-940.jpg", 241, "https://www.bonappetit.com/recipe/cilantro-lime-chicken-fajitas-with-grilled-onions"),
            new Meal (2, "Apple Crumble","https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQZijJwxtus5wGRjdIzRC8yDYlfmsF2Ge2UAw&amp;usqp=CAU", 115, "https://www.delicious.com.au/recipes/granny-lanes-famous-apple-crumble/vhdz3dvr"),
            new Meal (3, "Carrot Cake","https://natashaskitchen.com/wp-content/uploads/2023/03/Carrot-Cake-SQ1.jpg", 139, "https://natashaskitchen.com/carrot-cake-recipe/"),
            new Meal (4, "Beef Stew","https://www.joyousapron.com/wp-content/uploads/2018/10/stovetop-beef-stew-sq-pic.jpg", 210, "https://www.joyousapron.com/beef-stew/"),
            new Meal (5, "Pad Thai","https://inquiringchef.com/wp-content/uploads/2023/02/Authentic-Pad-Thai_square-1908-500x375.jpg", 132, "https://inquiringchef.com/authentic-pad-thai/")
     

        };


        [HttpGet]
        public IActionResult GetMeals()
        {
            return Ok(meals);
        }
    }

    record Meal(
        int id,
        string MealName,
        string MealThumbnail,
        int Votes,
        string Link
    );
}

// had to run the local host url specifically with '/api/meals' at the end and it works! i.e. http://localhost:5090/api/meals
