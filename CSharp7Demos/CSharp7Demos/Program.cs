using System;
using static System.Console;
using static System.Math;
using static System.String;
using static CSharp7Demos.StaticClassExample;

//The using static directive was introduced in C# 6.

//To create an alias for a namespace or a type. This is called a using alias directive.
//using Project = PC.MyCompany.Project;

namespace CSharp7Demos
{
    class Program
    {
        public double Radius { get; set; }

        static void Main(string[] args)
        {
            string s = "\nInformation about the Static Directive :\n";
            //string s = "using static Directive Introduced in c Sharp 6 Features";
            // here Static Class is Math, so that we are access the static method with the Help of
            // ClassName in the prior version of C#
            //C#6 later version  using static directive access with the direct name of method 


            //WriteLine(Max(22, 45));

            //WriteLine(Max(22,45));

            //WriteLine(Sum(10, 10));


            s = s + String.Format("   sum: {0:N2}\n", Sum(10, 10));
            WriteLine(s);

            string date = Format("Today's date is {0}", DateTime.Now);
            WriteLine(date);

            /* *** String.Format with multiple objects **/
            string author = "Mahesh Chand";
            string book = "Graphics Programming with GDI+";
            int year = 2003;
            decimal price = 49.95m;
            string publisher = "APress";

            // Book details  
            string bookDetails = String.Format("{0} is the author of book {1} \n " +
            "published by {2} in year {3}. \n Book price is ${4}. ",
            author, book, publisher, year, price);
            WriteLine(bookDetails);



            // Number formatting  
            int num = 302;
            string numStr = String.Format("Number {0, 0:D5}", num);
            Console.WriteLine(numStr);
            ReadLine();
        }

        public double Diameter
        {
            get { return 2 * Radius; }
        }

    }
}
