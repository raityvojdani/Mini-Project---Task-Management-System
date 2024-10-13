namespace Mini_Project___Task_Management_System;

internal class Program
{
    static void Main(string[] args)
    {
        {
            TaskManager taskManager = new TaskManager();

            // Adding tasks
            taskManager.AddTask("Finish project", "Complete the project by the end of the week", "High", "Work");
            taskManager.AddTask("Buy groceries", "Buy milk, bread, and eggs", "Low", "Personal");

            // Viewing all tasks
            taskManager.ViewAllTasks();

            // Editing a task
            taskManager.EditTask(1, "Finish project report", "Complete the project and submit the report", "High", "Work");

            // Viewing tasks by category
            taskManager.ViewTasksByCategory("Work");

            // Removing a task
            taskManager.RemoveTask(2);

            // Processing tasks in queue
            taskManager.ProcessNextTask();
        }

    }
}
