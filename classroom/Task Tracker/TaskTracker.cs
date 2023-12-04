namespace Task_Tracker;

public static class TaskTracker
{
    private static Dictionary<string, string> tasks = new Dictionary<string, string>();

    public static void ListAllTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine($"- {task.Key}: {task.Value}");
        }
    }

    public static void AddTask()
    {
        Console.Write("Enter task description: ");
        var description = Console.ReadLine();

        tasks.Add(description, "pending");

        Console.WriteLine($"Task '{description}' added with status 'pending'.\n");
    }

    public static void UpdateTaskStatus()
    {
        Console.Write("Enter task description to update: ");
        var description = Console.ReadLine();
        Console.Write("Enter new status: ");
        var status = Console.ReadLine();
        if (!tasks.ContainsKey(description))
        {
            Console.WriteLine($"Task not found.");
            return;
        }

        tasks[description] = status;
        Console.WriteLine($"Task '{description}' status updated to '{status}'.\n");
    }
}