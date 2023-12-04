using Task_Tracker;

Console.WriteLine("Task Tracker");

while (true)
{
    Console.WriteLine("Select an option:\n" +
                      "1. Add Task\n" +
                      "2. Update Task Status\n" +
                      "3. View All Tasks\n" +
                      "4. Exit");
    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
        {
            TaskTracker.AddTask();
            break;
        }
        case "2":
        {
            TaskTracker.UpdateTaskStatus();
            break;
        }
        case "3":
        {
            TaskTracker.ListAllTasks();
            break;
        }
        case "4":
        {
            Console.WriteLine("Exiting application");
            return;
        }
        default:
        {
            Console.WriteLine("Wrong option, try again.");
            break;
        }
    }
}