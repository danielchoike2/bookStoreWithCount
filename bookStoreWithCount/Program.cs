using System;
using System.Diagnostics.Metrics;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {

            book product1 = new book(1, "The Hobbit", "J.R.R. Tolkien");
            product1.SetTrans();
            Console.WriteLine($"ID = {product1.GetId()}, Title = {product1.GetTitle()}, Author = {product1.GetAuthor()}");
            


            book product2 = new book();
            product2.SetTrans();
            Console.WriteLine("Please enter the book's ID number:");
            product2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book's Title:");
            product2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book's Author:");
            product2.SetAuthor(Console.ReadLine());

            book product3 = new book(3, "It", "Steven King");
            product3.SetTrans();
            Console.WriteLine("Please enter the book's ID:");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book's title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book's Author: ");
            string tempAuthor = Console.ReadLine();
            
            book product4 = new book(tempID, tempTitle, tempAuthor);
            product4.SetTrans();

            printTransaction(product4);

            displayBooks(product1);
            displayBooks(product2);
            displayBooks(product3);
            displayBooks(product4);

        }// end of main method 

        static void printTransaction(book a)
        {
            Console.WriteLine($"The book store has {a.GetTrans()} new books");
            
        }

        static void displayBooks(book product)
        {
            Console.WriteLine("Here's your book information");
            Console.WriteLine($"Book ID: {product.GetId()}");
            Console.WriteLine($"Book Title: {product.GetTitle()}");
            Console.WriteLine($"Book Author: {product.GetAuthor()}");
        }

    }// end of class

    class book
    {

        private int _Id;
        private string _Title;
        private string _Author;

        public book()
        {
            _Id = 0;
            _Title = "";
            _Author = "";

        }// end of default constructor

        public book(int i, string userTitle, string userAuthor)
        {
            _Id = i;
            _Title = userTitle;
            _Author = userAuthor;

        }// end of parametric constructor

        public int GetId()
        {

            return _Id;

        }// end of get method - id 

        public string GetTitle()
        {
            return _Title;

        }// end of get method - title 

        public string GetAuthor()
        {
            return _Author;

        } // end of get method - Author 

        public void SetId(int identification)
        {
            _Id = identification;
        } // end of set ID

        public void SetTitle(string title)
        {
            _Title = title;
        } // end of set title 

        public void SetAuthor(string author)
        {

            _Author = author;

        }// end of set author

        private static int _transactions = 0;
        private string _accountName;

        public void SetTrans()
        {
            _transactions++;
        }// end of setrans

        public int GetTrans()
        {
            return _transactions;
        }// end of getrans 


    }// end of class book 

} // end of namespace


