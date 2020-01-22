using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Structures
{
    struct Train
    {
        public string destination;
        public int number;
        public DateTime departingTime;


        public Train( string destin, int num, DateTime departure)
        {
            destination = destin;
            number = num;
            departingTime = departure;

        }

        public static Train CreateTrainFromConsole()
        { 
            Console.WriteLine("Please enter destination:");
            string destination = Console.ReadLine();

            Console.WriteLine("Please enter train Number");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter departure time in format YYYY/mm/dd hh:mm:ss");
            DateTime departure = DateTime.Parse(Console.ReadLine());

            return new Train(destination, num, departure);

        }


        public static Train CreateTrain()
        {
            Random random = new Random();
            string[] destination = new string[7] {"London", "LA", "Toronto", "New York", "Berlin", "Vienna", "Linz" };
            int[] num = new int[7] { 1, 2, 3, 4, 8, 54, 32 };
            DateTime departure = (new DateTime(2015, 7, 20, 18, 30, 25)).AddHours(random.Next(1, 100));

            return new Train(destination[random.Next(0, 7)], num[random.Next(0, 7)], departure);
        }

        public static Train[] CreateTrainArray()
        {
            Train[] myTrainArr = new Train[8];

            for (int i = 0; i < myTrainArr.Length; i++)
            {
                myTrainArr[i] = i == 8 ? Train.CreateTrainFromConsole() : Train.CreateTrain();
            }

            return myTrainArr;
        }

        public void PrintAll()
        {
            Type TrainType = typeof(Train);
            FieldInfo[] fields = TrainType.GetFields();
            foreach (var field in fields)
            {
                Console.WriteLine("There is field {0} and its value {1}", field.Name, field.GetValue(this));
            }
        }
        public static void PrintTrain(Train [] trains)
        {
            Console.WriteLine("Enter number of train you want to get information about");

            int exNum = Int32.Parse(Console.ReadLine());

            bool isFound = false;
            int IDFound = 0;
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].number == exNum)
                {
                    isFound = true;
                    IDFound = i;
                }
            }

            if (isFound == true)
            {
                Console.WriteLine("Train is found");
                trains[IDFound].PrintAll();
            }
            else
            {
                Console.WriteLine("Train is not found");
            }

        }
    }
}
