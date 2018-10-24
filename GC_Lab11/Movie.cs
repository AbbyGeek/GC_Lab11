using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab11
{
    class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }
        
        

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        public static void Search(string Term, List<Movie> Dir)
        {
            Dir = Dir.OrderBy(m => m.Title).ToList();
            foreach (Movie x in Dir)
            {
                if (x.Category.ToLower().Contains(Term))
                {
                    Console.WriteLine(x.Title);
                }
            }
            
        }
        
    }
}
