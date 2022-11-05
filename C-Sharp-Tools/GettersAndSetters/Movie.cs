using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        public string FullDetails() => (title != null && director != null && rating != null)
            ? $"{title} By {director},\n Rating: {rating}" : "You're missing details" ;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        { 
            get => rating;
            set {
                // Expression bodied members doesn’t support block of code.
                // It supports only one statement with an expression, which is allowed.
                // If you need to use more than one statements, you may use the regular methods or properties.
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR" )
                    rating = value;
                else
                    rating = "NR";
            }
        }
    }
}
