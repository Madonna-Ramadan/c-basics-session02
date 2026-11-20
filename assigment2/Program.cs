using assignment2;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            //Book book = new Book("c# basics", 421);
            //object obj = book;
            //Console.WriteLine(obj);
            #endregion

            #region question 2
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion

            #region question 3
            //int pages = "464";
            //compile-time error
            //corriction : int pages = 464;
            #endregion

            #region question 4
            //try
            //{
            //    int x= 10;
            //    int y = 0;
            //    int z = x / y;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Error: Division by zero is not allowed.");
            //}
            //finally
            //{
            //    Console.WriteLine("Execution completed.");
            //}
            #endregion

            #region question 5
            //int pages = 300;
            //double pagesDouble=  pages;
            //Console.WriteLine(x); 
            #endregion

            #region question 6

            //double price = 49.99;
            //int priceInt = (int)price; 
            //Console.WriteLine(priceInt); 
            #endregion

            #region question 7

            //string pagesText = "464";
            //int pagesTextInt= Convert.ToInt32(pagesText);
            //Console.WriteLine(pagesTextInt);
            #endregion

            #region question 8
            //string yearText = "2023";
            //int YearInt= int.Parse(yearText);
            //Console.WriteLine(YearInt);
            //Console.WriteLine(YearInt.GetType());
            #endregion

            #region question 9
            //int pages = 464;
            //string pagesText = pages.ToString();
            //Console.WriteLine(pagesText);
            //Console.WriteLine(pagesText.GetType());
            #endregion

            #region question 10
            //int copies = 100;
            //object copiesObj = copies;
            //int copiesInt = (int)copiesObj;
            //Console.WriteLine(copiesObj);
            //Console.WriteLine(copiesInt);
            #endregion
        }
    }
}