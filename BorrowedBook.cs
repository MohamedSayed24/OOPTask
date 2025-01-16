using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    public class BorrowedBook : LibraryItem
    {
        public Book BookDetails { get; set; }

        public string? BorrowerName { get; set; }

        public DateTime BorrowedDate { get; set; }
        public BorrowedBook(int id, Book Bookdetails , string? Borrowername , DateTime Borroweddate) : base(id)
        {
            BookDetails = Bookdetails;
            BorrowerName = Borrowername;
            BorrowedDate = Borroweddate;
        }
        public int CalculateBorrowDuration(DateTime Borrowdate)
        {
            int diffDate = DateTime.Now.Subtract(Borrowdate).Days;
            return diffDate;
        }
    }
}
