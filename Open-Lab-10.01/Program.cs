using System;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Názov("Najlepšia kniha");
            LOTR.Žáner("SciFi");
            LOTR.Vydanie("prosinec");
            LOTR.Autor("Yanko");
            LOTR.Strany(12);
        }
        class Book
        {
            private string title;
            private string cathegory;
            private string releaseDate;
            private string author;
            private int pages;
            public void Názov(string novýNázov) { title = novýNázov; }
            public void Žáner(string novýŽáner) { cathegory = novýŽáner; }
            public void Vydanie(string novéVydanie) { releaseDate = novéVydanie; }
            public void Autor(string novýAutor) { author = novýAutor; }
            public void Strany(int novéStrany) { pages = novéStrany; }

            public void NapíšPremenné()
            {
                Console.WriteLine("Názov: " + title);
                Console.WriteLine("Počet strán: " + pages);
                Console.WriteLine("Žáner: " + cathegory);
                Console.WriteLine("Autor: " + author);
                Console.WriteLine("Dátum vydania: " + releaseDate);
            }
        }
    }
}