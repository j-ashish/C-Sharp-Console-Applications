using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Song.songCount); // We can call and get the value of the songCount, because it is the attribute that is associated with class and it is an class object, we can't call rest of the attributes this way, because they are associated with the instances.


            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);


            Console.WriteLine(holiday.title);

            // So now we have put that songCount static attribute inside the constructor so we create the instance two times so that songCount must have been increased.
            Console.WriteLine(Song.songCount); // Here we get the value that how much time the instances have been created.


            // So we created an method so we can access the count of calls, that returns that how much time the instances have been created.
            Console.WriteLine(kashmir.getsongCount());


        }
    }
}
