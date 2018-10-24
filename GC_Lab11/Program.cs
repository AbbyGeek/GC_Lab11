using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GC_Lab11
{
    class Program
    {
        public static List<Movie> Directory = new List<Movie>
            {
                new Movie ("Professor Marston and his wonder women", "Romance"),
                new Movie ("Blade Runner", "SciFi"),
                new Movie("Howl's Moving Castle","Fantasy"),
                new Movie("Spirited Away","Fantasy"),
                new Movie("The Matrix","Action"),
                new Movie("Forrest Gump","Drama"),
                new Movie("The Terminator","SciFi"),
                new Movie("Ferris Bueller's Day OFf","Comedy"),
                new Movie("Indiana Jones","Action"),
                new Movie("Scream", "Horror"),
                new Movie("Dirty Dancing","Romance")

            };
        


        static void Main(string[] args)
        {

            



            // store list of 10 movies. Display by category
            // user chooses category and program displays  movies in that category
            //ask to continue

            //each movie is object of type Movie
            //movie class has two private fields: Title and Category
            //constructor that accepts a title and categoty as parameters and uses values passed to initialize its fields.

            Console.WriteLine("Welcome to the movie class program thingy!");
            while (true)
            {
                
                Console.WriteLine($"\n\nThere are {Directory.Count} movies in our list.\nWhat category are you interested in?");

                Console.WriteLine("Genre options are as follows:\n1) Action \n2) Romance \n3) SciFi\n4) Fantasy\n5) Drama \n6) Comedy\nYou may enter a number or the specific genre.");
                string SearchTerm = Console.ReadLine().ToLower();
                if (SearchTerm == "1") { SearchTerm = "action"; }
                if (SearchTerm == "2") { SearchTerm = "romance"; }
                if (SearchTerm == "3") { SearchTerm = "scifi"; }
                if (SearchTerm == "4") { SearchTerm = "fantasy"; }
                if (SearchTerm == "5") { SearchTerm = "drama"; }
                if (SearchTerm == "6") { SearchTerm = "comedy"; }

                Movie.Search(SearchTerm, Directory);

                Console.WriteLine("\nContinue? (y/n)");
                string cont = Console.ReadLine();
                if (cont == "n") { break; }
            }
            
            

            
            

        }
    }
    
}
