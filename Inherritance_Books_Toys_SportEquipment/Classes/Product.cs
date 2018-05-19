using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance_Books_Toys_SportEquipment.Classes
{
    public abstract class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Producer { get; set; }
        public int Age { get; set; }


        public abstract void PrintInfo();
        public abstract void Check(Type type);

    }
}
