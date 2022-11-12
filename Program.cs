using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Csharp
{
    internal class Program
    {
        public struct Books
        {
            public int bookId;
            public string title;
            public double price;
            public BookType bookType;
        }

        public enum BookType
        {
            Articles,
            Magazines,
            Novels,
            Miscellaneous
        }

        static void Main(string[] args)
        {
            Calculator();
            //HighestMarks();
            //int[] arr = { 10, 15, 20, 25, 30};
            //ArraySummation(arr);
            //SwapTwoIntegers(50, 60);
            //Circle(10);
            //AcceptBookDetails();
        }

        public static void Calculator()
        {
            int a, b;
            Console.WriteLine("Enter the first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition of two numbers : " + (a + b));
            Console.WriteLine("Subtraction of two numbers : " + (a - b));
            Console.WriteLine("Multiplication of two numbers : " + (a * b));
            Console.WriteLine("Division of two numbers : " + (a / b));
        }

        public static void HighestMarks()
        {
            int[] marks = new int[5];
            int temp = 0;
            Console.WriteLine("Enter the marks of the 5 students : ");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] > temp)
                    temp = marks[i];
            }
            Console.WriteLine("Highest marks obtained : " + temp);
        }

        public static void ArraySummation(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Summation of all the elements in the array : " + sum);
        }

        public static void SwapTwoIntegers(int a, int b)
        {
            Console.WriteLine("Numbers before swapping :  a = {0}, b = {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Numbers after swapping :  a = {0}, b = {1}", a, b);
        }

        public static void Circle(double r)
        {
            double area = Math.PI * Math.Pow(r, 2);
            double circum = 2 * Math.PI * r;
            Console.WriteLine("Area of the circle : {0}", area);
            Console.WriteLine("Circumference of the circle : {0}", circum);
        }

        public static void AcceptBookDetails()
        {
            int id, n; string title; double price;
            Console.WriteLine("Enter the details - ");
            Console.WriteLine("Enter the book id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the title of the book : ");
            title = Console.ReadLine();
            Console.WriteLine("Enter the price of the book : ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the type of the book (1.Articles ; 2.Magazines ; 3.Novels ; 4.Miscellaneous) : ");
            n = Convert.ToInt32(Console.ReadLine());
            Books book = new Books();
            book.bookId = id;
            book.title = title;
            book.price = price;
            book.bookType = (BookType)n - 1;
            DisplayBookDetais(book.bookId, book.title, book.price, book.bookType);
        }

        public static void DisplayBookDetais(int id, string title, double price, BookType type)
        {
            Console.WriteLine();
            Console.WriteLine("Book Details - ");
            Console.WriteLine("Book Id : " + id);
            Console.WriteLine("Book Title : " + title);
            Console.WriteLine("Book Price : " + price);
            Console.WriteLine("Book Type : " + type);
        }
    }
}
