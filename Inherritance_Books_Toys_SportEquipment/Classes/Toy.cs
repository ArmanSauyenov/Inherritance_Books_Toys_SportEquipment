using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance_Books_Toys_SportEquipment.Classes
{
    public enum Materials { Metal, Plastic, Aluminum, Wood }
    public enum ForToys { Car, Doll, Lego, SuperHeroes }

    public class Toy : Product
    {
        public Materials Material { get; set; }


        public override void Check(Type type)
        {
            Console.WriteLine(type.GetType());
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Price: {Price}\n Manufacturer: {Producer}\n Material: {Material}\n Age: {Age}\n");
        }
    }   
}
