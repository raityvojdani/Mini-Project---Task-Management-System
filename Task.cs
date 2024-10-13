using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project___Task_Management_System;
public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Priority { get; set; } // e.g., High, Medium, Low
    public string Category { get; set; }

    public Task(int id, string title, string description, string priority, string category)
    {
        Id = id;
        Title = title;
        Description = description;
        Priority = priority;
        Category = category;
    }
}
