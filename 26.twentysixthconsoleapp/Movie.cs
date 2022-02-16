using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_and_setters
{

    // Getters and setters are basically two types of method, basically we define inside the classes, it controls the access to the attributes.
    // When we set certain attribute to private, that attribute can be only accessed inside the class.
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle , string aDirector , string aRating) // Here the user can put any value he wants to enter, so to block or let him go through the conditions we put down in the class we have to set i their by declaring that method name in constructor as a value holder.
        {
            this.title = aTitle;
            this.director = aDirector;
            this.Rating = aRating;  // Here we didn't used rating  we used Rating method to make sure user enter certain values defined by setters.
        }

        public string Rating  // When we want to access certain private attributes in the class we have to use this naming convention, use the same name but capitalize.
        {
            get { return rating; } // get will allow us to access that element which is private by this. Just to return the value not to modify, we can audit it but can't change the values once they are set.
            set // set will allow user to modify these values but with some conditions.
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R"  || value == "NR") // value represents the value provided by the user.
                {   // If the entered value is one of these it can change the value.
                    rating = value;
                }
                else // But if the value provided by the user in none of the above so as default it will be alloted as "NR" 
                {
                    rating = "NR";
                }
            }
        }

        // So basically getter is allowing us to audit the private attributes value, and setter is allowing us to set the value but with certain conditions.



    }
}
