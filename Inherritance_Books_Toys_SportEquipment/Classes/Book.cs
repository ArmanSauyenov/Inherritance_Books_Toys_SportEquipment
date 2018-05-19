using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance_Books_Toys_SportEquipment.Classes
{
    public enum Authors { Rick, John, Mark, Stefani, Liam }
    public enum Books { FairyTale, Fantasy, Poetry, Poem, Comics }

    public class Book : Product
    {
        private Random rand = new Random();
        public Authors Author { get; set; }

        public Book()
        {
            Author = (Authors)rand.Next(0, 3);
        }

        public override void Check(Type type)
        {
            Console.WriteLine(type.GetType());
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\n Author: {Author}\n Price: {Price}\n Manufacturer: {Producer}\n Age: {Age}\n");
        }
    }
}
