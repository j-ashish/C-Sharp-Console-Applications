using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_methods
{
    internal class Student
    {

        public string name;
        public string major;
        public double gpa;

        public Student(string aName , string aMajor , double aGpa)
        {
            this.name = aName;
            this.major = aMajor;
            this.gpa = aGpa;
        }

        // We can create methods inside the object class to put the attributes in use to grow the program.

        public bool HasHonours() // This method depends on the instances, which instance is calling the method. And these method will behave according to the value of the instances provieded. In this case we are determining the instances on the basis of the gpa named variable.
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
