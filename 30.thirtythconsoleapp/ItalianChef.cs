using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    // To inherit all the functionallity and methods of the parent class Chef class we just have to put colon : after the class name and after colon we have to define which class is going to inherited. In this case ItalianChef class in inheriting and the methods of chef and on the contrary it's also allowing user to use this class own methods.

    internal class ItalianChef : Chef   // This is the way the parent class methods are inherited
    {

        public void makePasta()
        {
            Console.WriteLine("Making Italian Pasta");
        }
        public override void MakeSpecialDish() // To use this inherited virtual method, we can modify as per class need, we just have to make some changes. Instead of calling virtual we have to specify it as override.
        {
            Console.WriteLine("Making special dish Italian Fish");
        }

    }
}
