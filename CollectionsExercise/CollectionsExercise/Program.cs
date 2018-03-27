using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            //Console.WriteLine(car1.ToString());

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            //Console.WriteLine(car2.ToString());

            Car car3 = new Car();
            car3.Make = "Holden";
            car3.Model = "vk";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            //Console.WriteLine(b1.ToString());

            Book b2 = new Book();
            b2.Author = "Miah Wilson";
            b2.Title = "LifeGruad Life";
            b2.ISBN = "1-111-11111-1";

            Book b3 = new Book();
            b3.Author = "Dylan Mitchell";
            b3.Title = "TeamLeader LifeGruad Life";
            b3.ISBN = "2-222-22222-2";

            ArrayList CarList = new ArrayList();
            CarList.Add(car1);
            CarList.Add(car2);
            CarList.Add(car3);

            PrintCar(CarList);

            ArrayList BookList = new ArrayList();
            BookList.Add(b1);
            BookList.Add(b2);
            BookList.Add(b3);

            PrintBook(BookList);

            SortedDictionary<int, Car> CarDictionary = new SortedDictionary<int, Car>();

            CarDictionary.Add(1, car1);
            CarDictionary.Add(2, car2);
            CarDictionary.Add(3, car3);

            PrintCarDictionary(CarDictionary);

            SortedDictionary<int, Book> BookDictionary = new SortedDictionary<int, Book>();

            BookDictionary.Add(1, b1);
            BookDictionary.Add(2, b2);
            BookDictionary.Add(3, b3);

            PrintBookDictionary(BookDictionary);

            Console.ReadLine();
        }

        public static void PrintCar(ArrayList list1)
        {
            foreach (Car i in list1)
                Console.WriteLine(i.ToString());            
        }

        public static void PrintBook(ArrayList list1)
        {
            foreach (Book i in list1)
                Console.WriteLine(i.ToString());
        }

        public static void PrintCarDictionary(SortedDictionary<int, Car> Dictionary1)
        {
            foreach (KeyValuePair<int, Car> pair in Dictionary1)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }
        }

        public static void PrintBookDictionary(SortedDictionary<int, Book> Dictionary2)
        {
            foreach (KeyValuePair<int, Book> pair in Dictionary2)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }
        }
                
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public override string ToString()
        {
            return Make + "   " + Model;
        }
    }


    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public override string ToString()
        {
            return Title + "   " + Author + "  " + ISBN;
        }
    }
}
