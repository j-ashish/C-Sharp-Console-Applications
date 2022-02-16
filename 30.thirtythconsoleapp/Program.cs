using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Inheritance is methods that let classes inherit other classes methods. Example: Parent class from child classes inherits values and methods. After that we can use parent class methods as well as child class methods too.



            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italian = new ItalianChef(); // Now that we have inherited the methods of the chef class inside the italianchef so now we are able to call the methods of chef with the instance of italianchef.
            italian.MakeChicken();


            italian.makePasta(); // So we saw that we are calling the chef class methods but here we can also call special methods or child class own methods too.


            // We can create as much methods we want but what some methods have special meaning and necessary but for other class it means something diffrent. In that case we use virtual.
            // These both given methods share same name but the functionallity is diffrent. We overrided the methods as per the class.
            chef.MakeSpecialDish();
            italian.MakeSpecialDish();


        }
    }
}
