using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    public class LibraryItem
    {
        public int ID { get; set; }

        public bool isAvailable { get; set; }

        public LibraryItem()
        {
            
        }
        public LibraryItem(int id)
        {
            ID = id;
            isAvailable = true;
        }
        public void CheckOut()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine($"The Item {ID} is Checked Out");
            }
            else
                Console.WriteLine($"The Item {ID} is Not Available");
        }

        public void ReturnItem()
        {
            if (!isAvailable)
            {
                isAvailable = true;
                Console.WriteLine($"The Item {ID} is Returned");
            }
            else
                Console.WriteLine($"The Item {ID} is Already Available");
        }
    }
}
