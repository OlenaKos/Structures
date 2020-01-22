using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void ClassTaker(MyClass my)
        {
            my.Change = "Changed";
        }

        static void StructTaker(MyStruct my)
        {
            my.Change = "Changed";
        }
        
        static void Main(string[] args)
        {
            //Task1
            Notebook notebook = new Notebook( "ThinkPad", "Lenovo", 45454);
            notebook.PrintAll();

            //Task2
            Train train1 = new Train("Paris", 2, new DateTime(2020, 1, 21, 18, 45, 00));
            Train[] trains = Train.CreateTrainArray();
            Train.PrintTrain(trains);

            //Task3
            MyStruct mystruct = new MyStruct();
            mystruct.Change = "Not Changed";
            MyClass myclass = new MyClass();
            myclass.Change = "Not Changed";

            StructTaker(mystruct);
            ClassTaker(myclass);

            Console.WriteLine("MyStruct " + mystruct.Change);
            Console.WriteLine("MyClass " + myclass.Change);

            //Task4
            CalculateDaysAmountTillNextBD();

            //Task5
            MyPrint.Print("The cake is a lie!", 12);
            
            //Task6

            Console.ReadLine();
        }

        private static void CalculateDaysAmountTillNextBD()
        {
            Console.WriteLine("Enter your birthday in format YYYY/mm/dd");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int BDYear = birthday.Year;
            DateTime current = DateTime.Now;
            int currentYear = current.Year;

            DateTime nextBD = birthday.AddYears(currentYear - BDYear);
            int tillNextBD = (nextBD - current).Days;

            Console.WriteLine("Your next birthday is {0}", tillNextBD);

            
        }
    }
}
