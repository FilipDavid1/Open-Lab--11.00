using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab__11._00
{
    class Library
    {
        private int numberOfBooks = 4;
        private int numberOfStudents = 2;

        public  List<string> studentsList = new List<string>() {};
        public  List<Book> booksList = new List<Book>() {};



        public int NumberOfBooks
        {
            get => numberOfBooks;

            set => numberOfBooks = value;
        }

        public int NumberOfStudents
        {
            get => numberOfStudents;

            set => numberOfStudents = value;
        }

        public void Show()
        {
            Console.WriteLine("numberOfBooks:" + numberOfBooks);
            Console.WriteLine("numberOfStudents:" + numberOfStudents);
            Console.WriteLine(" ");
            foreach (var Student in studentsList)
            {
                Console.WriteLine(Student);
            }

            Console.WriteLine(" ");

            foreach (var Book in booksList)
            {
                Book.Show();
            }

        }
    }
}
