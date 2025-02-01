using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_advanasig3
{
    internal class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string ISBN, string Title, string[] Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = ISBN;
            Title = Title;
            Authors = Authors;
            PublicationDate = _PublicationDate;
            Price = Price;
        }

        public override string ToString()
        {
            return $"{Title} by {string.Join(", ", Authors)} (ISBN: {ISBN}) - {Price:C}";
        }
        
    }
}
