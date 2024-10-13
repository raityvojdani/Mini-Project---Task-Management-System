using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project___Task_Management_System;
public class TaskManager
{
    private List<Task> tasks = new List<Task>(); // For managing tasks
    private Dictionary<string, List<Task>> categorizedTasks = new Dictionary<string, List<Task>>(); // For categorizing tasks
    private Queue<Task> taskQueue = new Queue<Task>(); // For processing tasks
    private int nextId = 1; // To assign unique IDs to tasks

    // Add a task
    public void AddTask(string title, string description, string priority, string category)
    {
        Task task = new Task(nextId++, title, description, priority, category);
        tasks.Add(task);

        // Add to categorized tasks
        if (!categorizedTasks.ContainsKey(category))
        {
            categorizedTasks[category] = new List<Task>();
        }
        categorizedTasks[category].Add(task);

        // Add to queue
        taskQueue.Enqueue(task);

        Console.WriteLine("Task added successfully!");
    }

    // Remove a task
    public void RemoveTask(int taskId)
    {
        Task task = tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            tasks.Remove(task);

            // Remove from categorized tasks
            if (categorizedTasks.ContainsKey(task.Category))
            {
                categorizedTasks[task.Category].Remove(task);
            }

            Console.WriteLine("Task removed successfully!");
        }
        else
        {
            Console.WriteLine("Task not found!");
        }
    }

    // Edit a task
    public void EditTask(int taskId, string title, string description, string priority, string category)
    {
        Task task = tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            task.Title = title;
            task.Description = description;
            task.Priority = priority;

            // Handle category change
            if (task.Category != category)
            {
                categorizedTasks[task.Category].Remove(task);

                if (!categorizedTasks.ContainsKey(category))
                {
                    categorizedTasks[category] = new List<Task>();
                }
                categorizedTasks[category].Add(task);
            }
            task.Category = category;

            Console.WriteLine("Task updated successfully!");
        }
        else
        {
            Console.WriteLine("Task not found!");
        }
    }

    // View all tasks
    public void ViewAllTasks()
    {
        foreach (var task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    // View tasks by category
    public void ViewTasksByCategory(string category)
    {
        if (categorizedTasks.ContainsKey(category))
        {
            foreach (var task in categorizedTasks[category])
            {
                Console.WriteLine(task);
            }
        }
        else
        {
            Console.WriteLine("No tasks found in this category.");
        }
    }

    // Process next task in queue
    public void ProcessNextTask()
    {
        if (taskQueue.Any())
        {
            Task task = taskQueue.Dequeue();
            Console.WriteLine($"Processing task: {task.Title}");
        }
        else
        {
            Console.WriteLine("No tasks in the queue!");
        }
    }
}
