using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance_Books_Toys_SportEquipment.Classes
{
    public class Creator
    {
        private Random rand = new Random();
        public List<Product> product;

        public Creator()
        {
            product = new List<Product>();
        }

        public void GenerateToys()
        {
            Toy toy = new Toy();
            toy.Name = ((ForToys)rand.Next(0, 3)).ToString();
            toy.Price = rand.Next(100, 999);
            toy.Material = (Materials)rand.Next(0, 3);
            toy.Producer = rand.Next(1000, 9999);
            toy.Age = rand.Next(1, 7);

            product.Add(toy);
        }

        public void GenerateBooks()
        {
            Book book = new Book();
            book.Name = ((Books)rand.Next(0, 4)).ToString();
            book.Price = rand.Next(800, 2500);
            book.Producer = rand.Next(1000, 9999);
            book.Author = (Authors)rand.Next(0, 4);
            book.Age = rand.Next(6, 55);

            product.Add(book);
        }

        public void GenerateSportEquipments()
        {
            SportsEquipment sport = new SportsEquipment();
            sport.Name = ((SportsEquip)rand.Next(0, 3)).ToString();
            sport.Price = rand.Next(20000, 150000);
            sport.Producer = rand.Next(1000, 9999);
            sport.Age = rand.Next(6, 25);

            product.Add(sport);
        }

        public void PrintAll()
        {

            foreach (Product item in product)
            {
                item.PrintInfo();
            }

        }

        public void Fined(Type type)
        {
            foreach (Product item in product)
            {
                if (item.GetType() == type)
                {
                    item.PrintInfo();
                }
            }

        }

    }
}
