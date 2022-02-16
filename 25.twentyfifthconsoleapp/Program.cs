using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            // Now that we have created method inside the clas we can use them with our instances.

            // We created hashonours method in class to determine that the student have the honours or not according to their gpa. This method returns boolean value. So if gpa is according to the condition it will return true otherwise it will simply return false.
            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());






        }
    }
}
