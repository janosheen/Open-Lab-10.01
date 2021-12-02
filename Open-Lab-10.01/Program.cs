using System;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Title = "Najlepšia kniha";
            LOTR.Cathegory = "SciFi";
            LOTR.ReleaseDate = 1863;
            LOTR.Author = "Yanko";
            LOTR.Pages = 12;
            LOTR.Write();
        }
        public class Book
        {
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