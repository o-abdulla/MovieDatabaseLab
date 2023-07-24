// Movie Database Lab

//create a List<Movie> and store at least 10 movies there.
//You can use literals to construct the movies. Make sure to have a mixture of categories.

using CircleObjectsLab;
using MovieDatabaseLab;

Console.WriteLine("There are 10 movies in the list\n");

List<Movie> movies = new List<Movie>
{
    new Movie("Step Brothers", "Comedy"),
    new Movie("Halloween", "Horror"),
    new Movie("Avatar", "SciFi"),
    new Movie("The Hangover", "Comedy"),
    new Movie("Excorcist", "Horror"),
    new Movie("Star Wars", "Sci-Fi"),
    new Movie("The Wizard of Oz", "Fantasy"),
    new Movie("Scream", "Horror"),
    new Movie("Insidious", "Horror"),
    new Movie("Casablanca", "Romance")

};

//When the user enters a category, the program should read through all of the movies in the List
//and display a line for any movie whose category matches the category entered by the user
bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("What category are you interested in?");
    string genre = Console.ReadLine().Trim().ToLower();
    List<Movie> movie = movies.Where(m => m.Category.ToLower() == genre).ToList();
    foreach (Movie m in movie)
    {
        Console.WriteLine(m.Title);
    }

    runProgram = Validator.GetContinue("Would you like to continue?");
         
}