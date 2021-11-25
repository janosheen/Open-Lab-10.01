using System;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.title = "Najlepsia kniha";
            Console.WriteLine(LOTR.title);
        }
        class Book
        {
            public string title;
            private string pages;
        }
    }
}
