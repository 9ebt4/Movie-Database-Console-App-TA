using Movie_Object;
using Validator_Object;

List<Movie> listMovies = new List<Movie>
        {
            new Movie("The Lion King", "animated", 88, 1994, "Roger Allers, Rob Minkoff"),
            new Movie("Toy Story", "animated", 81, 1995, "John Lasseter"),
            new Movie("The Incredibles", "animated", 115, 2004, "Brad Bird"),
            new Movie("Finding Nemo", "animated", 100, 2003, "Andrew Stanton, Lee Unkrich"),
            new Movie("The Godfather", "drama", 175, 1972, "Francis Ford Coppola"),
            new Movie("Forrest Gump", "drama", 142, 1994, "Robert Zemeckis"),
            new Movie("The Shawshank Redemption", "drama", 142, 1994, "Frank Darabont"),
            new Movie("Casablanca", "drama", 102, 1942, "Michael Curtiz"),
            new Movie("The Shining", "horror", 146, 1980, "Stanley Kubrick"),
            new Movie("Psycho", "horror", 109, 1960, "Alfred Hitchcock"),
            new Movie("A Nightmare on Elm Street", "horror", 91, 1984, "Wes Craven"),
            new Movie("The Silence of the Lambs", "horror", 118, 1991, "Jonathan Demme"),
            new Movie("Star Wars: Episode IV - A New Hope", "scifi", 121, 1977, "George Lucas"),
            new Movie("Blade Runner", "scifi", 117, 1982, "Ridley Scott"),
            new Movie("Interstellar", "scifi", 169, 2014, "Christopher Nolan"),
            new Movie("The Matrix", "scifi", 136, 1999, "Lana Wachowski, Lilly Wachowski"),
            new Movie("Die Hard", "action", 132, 1988, "John McTiernan"),
            new Movie("Mad Max: Fury Road", "action", 120, 2015, "George Miller"),
            new Movie("Gladiator", "action", 155, 2000, "Ridley Scott"),
            new Movie("The Dark Knight", "action", 152, 2008, "Christopher Nolan")
        };
bool runProgam = true;
List<Movie> movies = new List<Movie>();
while (runProgam)
{
    while (true)
    {
        Console.WriteLine("Please enter a category: 1) Action, 2) Animated, 3) Drama, 4) Horror, 5) Scifi");
        string input = null;
        bool invalid = false;
        do
        {
            input = Console.ReadLine().ToLower().Trim();
            invalid = false;
            if (int.TryParse(input, out int intCat))
            {
                switch (intCat)
                {
                    case 1:
                        input = "action";
                        break;
                    case 2:
                        input = "animated";
                        break;
                    case 3:
                        input = "action";
                        break;
                    case 4:
                        input = "action";
                        break;
                    case 5:
                        input = "action";
                        break;
                    default:
                        Console.WriteLine("Invalid input: Only enter numbers 1-5. Try again.");
                        invalid = true;
                        break;
                }
            }
        } while (invalid);

        movies = Movie.MoviesByCategory(input, listMovies);

        if (movies.Count < 1)
        {
            Console.WriteLine("Invalid input: Only enter 1) Action, 2) Animated, 3) Drama, 4) Horror, 5) Scifi. Use only numbers or letters.");
        }
        else
        {
            Console.WriteLine("These are the movies in that catergory.");
            foreach (Movie m in movies)
            {
                Console.WriteLine($"Title: {m.Title}, Runtime: {m.Runtime}, Year Released: {m.YearReleased}, Directed By: {m.Directors}");
            }

            break;
        }
    }
    Console.WriteLine("Look up more movies?");
    runProgam = Validator.Continue();
}
Console.WriteLine("GoodBye");