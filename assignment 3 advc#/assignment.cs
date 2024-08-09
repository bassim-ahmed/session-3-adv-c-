using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace assignment_3_advc_
{
    public class book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {

            return $"{Title} by {Authors}";
        }
    }
    public class Bookfunction
    {
        public static string GetTitle(book B)
        {
            return B.Title;
        }

        public static string GetAuthors(book B)
        {
            return string.Join(", ", B.Authors);
        }

        public static string GetPrice(book B)
        {
            return B.Price.ToString("C"); 
        }
    }
    public delegate string BookInfoDelegate(book B);
    public class Library
    {
        public void ProcessBooks(List<book> books, BookInfoDelegate getInfo)
        {
            foreach (var book in books)
            {
                var info = getInfo(book);
                Console.WriteLine(info);
            }
        }
    }
    internal class assignment
    {
        
        


        static void Main(string[] args)
        {

    //        var booksList = new List<book>
    //        {
    // new book("233490", "The Secret Garden", new string[] { "Frances Hodgson Burnett" }, new DateTime(1911, 5, 1), 12.99m),
    //new book("2333", "To Kill a Mockingbird", new string[] { "Harper Lee" }, new DateTime(1960, 7, 11), 9.99m),
    //new book("97235", "Pride and Prejudice", new string[] { "Jane Austen" }, new DateTime(1813, 1, 28), 8.49m),

    //        };
    //        //  Func<book, string>
    //        Func<book, string> getTitleFunc = Bookfunction.GetTitle;
    //        Func<book, string> getAuthorsFunc = Bookfunction.GetAuthors;
    //        Func<book, string> getPriceFunc = Bookfunction.GetPrice;
    //        // Anonymous method 
    //        BookInfoDelegate getISBN = delegate (book B)
    //        {
    //            return B.ISBN;
    //        };
    //        // Lambda expression 
    //        BookInfoDelegate getPublicationDate = B => B.PublicationDate.ToString("yyyy-MM-dd");



    //        var processor = new Library();
    //        processor.ProcessBooks(booksList, getTitleFunc);
    //        processor.ProcessBooks(booksList, getAuthorsFunc);
    //        processor.ProcessBooks(booksList, getPriceFunc);
    //        processor.ProcessBooks(booksList, getISBN);
    //        processor.ProcessBooks(booksList, getPublicationDate);




        }
    }
}
