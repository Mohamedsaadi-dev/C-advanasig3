using static C_advanasig3.BookFunctions;

namespace C_advanasig3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
        {
            new Book("1234567890", "oop", new string[] { "mohamed"}, new DateTime(2021, 5, 1), 22.88m),
            new Book("0987654321", "database", new string[] { "ahmed" }, new DateTime(2021, 8, 15), 15.99m)
        };

            Console.WriteLine("Using User-Defined Delegate (GetTitle):");
            BookFunction titleDelegate = new BookFunction(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books, titleDelegate);

            Console.WriteLine("\nUsing BCL Delegate (GetAuthors):");
            Func<Book, string> authorDelegate = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, authorDelegate);

            Console.WriteLine("\nUsing Anonymous Method (GetISBN):");
            Func<Book, string> isbnDelegate = delegate (Book B)
            {
                return B.ISBN;
            };
            LibraryEngine.ProcessBooks(books, isbnDelegate);

            Console.WriteLine("\nUsing Lambda Expression (GetPublicationDate):");
            Func<Book, string> dateDelegate = B => B.PublicationDate.ToShortDateString();
            LibraryEngine.ProcessBooks(books, dateDelegate);
        }      
    }
    }

