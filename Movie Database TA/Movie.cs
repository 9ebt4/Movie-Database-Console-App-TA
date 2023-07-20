using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Object
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Runtime { get; set; }
        public int YearReleased { get; set; }
        public string Directors { get; set; }



        public Movie(string title, string category, int runtime, int yearReleased, string directors)
        {
            Title = title;
            Category = category;
            Runtime = runtime;
            YearReleased = yearReleased;
            Directors = directors;
        }

        public static List<Movie> MoviesByCategory(string category, List<Movie> movies)
        {
            
            return movies.Where(c => c.Category.ToLower().Contains(category)).OrderBy(m => m.Title).ToList();
            
        }
        
    }
}
