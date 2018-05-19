using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance_Books_Toys_SportEquipment.Classes
{
    public enum SportsEquip { Bicycle, Ski, Ball, Skateboard }

    public class SportsEquipment : Product
    {

        public override void Check(Type type)
        {
            Console.WriteLine(type.GetType());
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Price: {Price}\n Manufacturer: {Producer}\n Age: {Age}\n");
        }
    }
}
