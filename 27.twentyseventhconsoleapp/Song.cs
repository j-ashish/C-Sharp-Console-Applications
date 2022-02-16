using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_attributes
{   // static attributes are similar for all the instances created by class and for all objects in the class. unlike the rest attributes this attribute is associated with class not with the instance.
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aTitle , string aArtist , int aDuration) // So this time whenever the constructor is called to create an instance we are going to increase the value of the songCount so we can now how much instances have been created.
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;
            songCount++;
        }

        // We can create the function too, that return the value, that tells how much time the instances have been created.

        public int getsongCount()
        {
            return songCount;
        }

    }
}
