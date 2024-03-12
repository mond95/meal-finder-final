
# Recipe Finder

This is my final submission for the Foundry.
- The whole website is a single HTML page that looks like it uses several html files but is actually using Javascript functions to hide/display parts of the page
- They can search for a recipe in the search bar using a key word that is in the recipe name e.g. ‘chicken’
   - This returns results using an external API (MealDB API) and puts them in a CSS grid layout
    - Clicking on the recipe will automatically jump the user down to the recipe at the bottom of the results
    - They can see the ingredients, measurements and steps
- They can also click on the ‘Randomiser’ button which will again call the MealDB API to return a random recipe
- The user can click on the header at any point which will take them back to the landing page view (i.e. refreshes the page)
- On landing there is a carousel made with Boostrap which shows the ‘top recipes of the week’
    - This uses a web API made in C# with data I have created (but so that is easier for people to run and for the demo I have also put the default option as JSON data instead as C# requires you to type in the command 'dotnet run')
    - Clicking on the image takes them to an external recipe link



## Demo

You can view a demo of this on Netlify: https://meal-finder-final.netlify.app/


## API Reference

Meal DB API: https://www.themealdb.com/api.php


## Tech Stack

HTML, CSS, Javascript, C#, JSON, CSS Grid, Flexbox, Boostrap, API, Hosting

