using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300871455_Baten__ASS_2
{
    class Program
    {
      
        public delegate void delBookLibrary(List<BookLibrary> libraries);
        static void Main(string[] args)
        {
            int ch = 0, price;
            string title, author, typeofcover;
            List<BookLibrary> libraries = new List<BookLibrary>();
            delBookLibrary delBook;



            do
            {
                Console.WriteLine(" Select the below options");
                Console.WriteLine("1.Enter the employee details" + "\t 2. the soft cover books and their average price."
                    + "3.most expensive book." + "4. Sort Books");

                ch = Convert.ToInt32( Console.ReadLine());
                switch (ch)
                {
                    case 1:     Console.WriteLine("Enter the title");
                                title = Console.ReadLine();
                                Console.WriteLine("Enter the author");
                                author = Console.ReadLine();
                                Console.WriteLine("Enter the price");
                                price = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the type of cover");
                                typeofcover = Console.ReadLine();
                        libraries.Add(new BookLibrary() { Title = title, Author = author, Price = price, TypeOfCover = typeofcover });
                                                             
                        break;

                    case 2: delBook = sortCoverBooks;
                            delBook(libraries);
                             break;

                    case 3:
                            delBook = expensiveBook;
                            delBook(libraries);
                            break;
                    case 4: delBook = sortBook;
                             delBook(libraries);
                            break;

                    


                    default: Console.WriteLine("Please check");
                            break;
                }


            } while (ch != 5);


            
        }
        public static void sortCoverBooks(List<BookLibrary> bookLibraries)
        {
            int count = 0, price = 0;
            foreach (BookLibrary book in bookLibraries)
            {
                if (book.TypeOfCover == "soft")
                {
                    Console.WriteLine(book.Title);
                    price += book.Price;
                    count++;
                }
            }

            int avg = price / count;
            Console.WriteLine("Average price :"+ avg);
        }


        public static void expensiveBook(List<BookLibrary> bookLibraries)
        {
            int maxbOOK = bookLibraries.Max(t => t.Price);

            foreach(var book in bookLibraries)
            {
                if (maxbOOK.Equals(book.Price))
                {
                    Console.WriteLine("Most Expensive book is :" + book.Title, maxbOOK);
                }
            }
            
        }


        public static void sortBook(List<BookLibrary> bookLibraries)
        {

            List<BookLibrary> books = bookLibraries.OrderBy(t => t.Price).ToList();
            //Console.WriteLine(books.ToString());

            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }


        }
    }

   
}
