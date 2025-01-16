namespace OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book();
            DateTime BorrowDate = new DateTime(2024, 11, 15);
            BorrowedBook borrowedBook = new BorrowedBook(30 , book, "Mohamed", BorrowDate);

            

            Console.WriteLine("================When the Book Is Borrowed====================");
            borrowedBook.CheckOut();


            Console.WriteLine("================When the Book Is Returned====================");
            borrowedBook.ReturnItem();


            int Days = borrowedBook.CalculateBorrowDuration(BorrowDate);
            Console.WriteLine($"The Number of Days Since The Book Is Borrowed ==> {Days}");

            
        }
    }
}
