using System.Runtime.Serialization.Formatters;

namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bodyParts = new string[] 
            {
                "  -----\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n      |\r\n      |\r\n      |\r\n      |\r\n-------",
                "  -----\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n      |\r\n      |\r\n      |\r\n-------",
                "  -----\r\n  |   |\r\n  O   |\r\n ---  |\r\n  |   |\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n-------",
                "  -----\r\n  |   |\r\n  O   |\r\n ---  |\r\n/ |   |\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n-------",
                "  -----\r\n  |   |\r\n  O   |\r\n ---  |\r\n/ | \\ |\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |\r\n-------",
                "  -----\r\n  |   |\r\n  O   |\r\n ---  |\r\n/ | \\ |\r\n  |   |\r\n ---  |\r\n/     |\r\n|     |\r\n      |\r\n-------",
                "  -----\r\n  |   |\r\n  O   |\r\n ---  |\r\n/ | \\ |\r\n  |   |\r\n ---  |\r\n/   \\ |\r\n|   | |\r\n      |\r\n-------"
            };

            Console.WriteLine("Welcome to HangMan Application");

            int numOfTries = 6;

            string rightWord = "ebrahem";

            string[] checkedArray = new string[rightWord.Length];

            PrintCheckedArray(checkedArray);

            int remainingCharcters = 0;

            string endGame;

              
            string charcterToEnter;
            do
            {
                Console.WriteLine($"You Have {numOfTries} left");

                Console.WriteLine("please enter a charcter: ");

                charcterToEnter = Console.ReadLine();

                //Check if charcter is valid and return bool
                bool isValidCharcter = CheckIfCharFound(charcterToEnter, rightWord, checkedArray ,ref remainingCharcters);

                if (!isValidCharcter) 
                {
                    int temp = 6;

                    numOfTries--; //decrease number of tries by one 
                    Console.WriteLine(bodyParts[temp - numOfTries]);
                }
                remainingCharcters = CheckIfNull(checkedArray);

                PrintArray(checkedArray);
            }
            while (numOfTries > 0 && remainingCharcters < rightWord.Length);

            endGame = remainingCharcters == rightWord.Length ? "WellDone You Complete The Challneage" : "Please Try again..";

            Console.WriteLine(endGame);
        }


        static void PrintArray(string[] arr) 
        {

            foreach (string x in arr)
            {
                Console.Write(x);
            }
            Console.WriteLine();
        }

        static bool CheckIfCharFound(string charcter , string word , string[] checkedArray , ref int remainingChars) 
        {
            bool isValidCharcter = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString() == charcter)
                {
                    checkedArray[i] = charcter;
                    isValidCharcter = true;
                    
                }

            }

            return isValidCharcter;
        }

        static void PrintCheckedArray(string[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "-";
            }


            foreach (string charc in arr)
            {
                Console.Write(charc);
            }
            Console.WriteLine();
        }

        static int CheckIfNull(string[] arr) 
        {
            int counter = 0;
            foreach(string charc in arr) 
            {
                if(charc != "-") 
                {
                    counter++;
                }
            }
            return counter;
        }



        
    }
}
