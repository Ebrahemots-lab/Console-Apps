using static ProgramFunctions;

namespace ToDoApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Welcome();

            string userName = GetUserName();

            int length = GetTasksLength();

            string[] finishedTasks = new string[length];

            string[] unFinishedTasks = new string[length];


            int userChoice = DisplayMenu();

            RedirectUserTo(userChoice , finishedTasks , unFinishedTasks);

           








        }
    }
}
