using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad.");
        }

        public virtual void MakeSpecialDish() // This method is virtual which means other classes can inherit and change the value of this methods as per their need.
        {
            Console.WriteLine("The chef makes BBQ ribs.");
        }
          


    }
}
