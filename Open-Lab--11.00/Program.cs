using System;

namespace Open_Lab__11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schooLibrary = new Library();
            schooLibrary.studentsList.Add("Poul");

            schooLibrary.booksList.Add(new Book("Vlastnou hlavou", 248, "kravina", "Marek Vagovič", 2016));
            schooLibrary.booksList.Add(new Book("Gauč alebo šťastie", 264, "cvicenie", "Maroš Molnár", 2020));

            schooLibrary.studentsList.Add("John");
            
            schooLibrary.booksList.Add(new Book("Zrkadlový muž", 464, "dobrodružné", "Lars Kepler", 2020));
            schooLibrary.booksList.Add(new Book("Varíme diabetikom", 192, "varenie", "Mária Štefáková", 201));

            schooLibrary.Show();
        }
    }
}
