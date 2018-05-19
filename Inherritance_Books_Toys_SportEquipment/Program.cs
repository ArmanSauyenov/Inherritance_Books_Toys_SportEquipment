using Inherritance_Books_Toys_SportEquipment.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance_Books_Toys_SportEquipment
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator creator = new Creator();

            creator.GenerateToys();
            creator.GenerateBooks();
            creator.GenerateSportEquipments();

            creator.PrintAll();

        }
    }
}
