using System;

namespace Open_Lab_10._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            Book LOTR2 = new Book("NF",420);
            Book LOTR3 = new Book("REAL", 410, 1945, "Nate","reálny");
            Book HOBIT = new Book();
            LOTR.Write();
            LOTR2.Write();
            LOTR3.Write();
            HOBIT.Write();
        }
        public class Book
        {
            public Book()
                {
                Title = "-1";
                Cathegory = "-1";
                ReleaseDate = -1;
                Author = "-1";
                Pages = -1;
                }     

            public Book(string title, int pages)
                {
                Title = title;
                Pages = pages;
                Author = "-1";
                Title = "-1";
                Cathegory = "-1";
                }

            public Book(string title, int pages, int releaseDate, string author, string cathegory)
                {
                Title = title;
                Pages = pages;
                Author = author;
                Cathegory = cathegory;
                ReleaseDate = releaseDate;
                }

            public string Title { get; set; }
        private int pages;
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Cathegory { get; set; }
        public string Author { get; set; }
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value <= 2021 && value >= 1450)
                    {
                releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
        }

            public void Write()
            {
                Console.WriteLine("Názov: " + Title);
                Console.WriteLine("Počet strán: " + Pages);
                Console.WriteLine("Žáner: " + Cathegory);
                Console.WriteLine("Autor: " + Author);
                Console.WriteLine("Dátum vydania: " + ReleaseDate);
            }
        }
    }
}