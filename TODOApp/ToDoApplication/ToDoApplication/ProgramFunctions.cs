using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class ProgramFunctions
{


    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static void Welcome()
    {
        Console.WriteLine("Welcome To TODO Application");
    }

    public static string GetUserName()
    {
        Console.Write("PLease enter Your name: ");

        string? userName = Console.ReadLine();

        Print($"Welcome {userName}");

        return userName!;


    }

    public static int GetTasksLength() 
    {
        Print("How Many Tasks you want to add: ");

        bool isValidNumber = int.TryParse(Console.ReadLine(), out int output);

        return output;
    }

    public static int DisplayMenu()
    {
        Print("1 - Add Task \n2- Finished Tasks \n3- Unfinished Tasks");

        bool isValidChoice = int.TryParse(Console.ReadLine(), out int choice);

        return choice;
    }



    public static void RedirectUserTo(int number , string[] finished , string[] unfinished)
    {
        switch (number)
        {
            case 1:
                GetTaskInfo(unfinished);
                break;
            case 2:
                DisplayFinishedTasks(finished);
                break;
            case 3:
                DisplayUnfinishedTasks(unfinished);
                break;
            default:
                Console.WriteLine("PLease enter a valid choice");
                break; 
        }
    }



    public static void DisplayUnfinishedTasks(string[] unfinished)
    {
        bool ArrayHasItem = CheckArrLength(unfinished);

        if (ArrayHasItem) 
        {
            foreach (string task in unfinished)
            {
                Console.WriteLine(task);
            }
        }
        else 
        {
            Print("There is no Tasks yet..");

            Print("Wanna Add a task y or n: ");
        }

       

    }

    public static void DisplayFinishedTasks(string[] finished)
    {
        bool ArrayHasItem = CheckArrLength(finished);

        if (ArrayHasItem) 
        {
            foreach (string task in finished)
            {
                Console.WriteLine(task);
            }
        }
        else 
        {
            Print("Please finish some tasks first..");
           
        }

      
    }



    public static void GetTaskInfo(string[] UnfinishedTasks)
    {
        int counter = 0;

        char userChoiceToAddAnotherTask;
        do
        {
            Print($"PLease enter task {counter + 1 }: ");

            string? taskName = Console.ReadLine();

            AddTaskToUnFinished(taskName, UnfinishedTasks);

            Console.Write("Wanna add another task y or n: ");

            char.TryParse(Console.ReadLine(),out userChoiceToAddAnotherTask); 

            counter++;

        } while (userChoiceToAddAnotherTask == 'y' && counter < UnfinishedTasks.Length);


    }



    public static void AddTaskToUnFinished(string taskName , string[] unfinishedTasks) 
    {
       for(int i = 0; i < unfinishedTasks.Length; i++) 
        {
            if (unfinishedTasks[i] == null) 
            {
                unfinishedTasks[i] = taskName;
                break;
            }
        }

    }




    public static bool CheckArrLength(string[] arr) 
    {
        bool isValidLength = true;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == null) 
            {
                isValidLength = false;
            }
        }
        return isValidLength;
    }


}

