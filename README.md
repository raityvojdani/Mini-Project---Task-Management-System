# Task Management System

This is a simple **Task Management System** developed using C#. It allows users to manage tasks using collections such as `List<T>`, `Dictionary<TKey, TValue>`, and `Queue<T>`. Users can add, remove, edit, categorize, and process tasks efficiently.

## Features
- Add new tasks with details such as title, description, priority, and category.
- Remove tasks by their ID.
- Edit tasks and update their details.
- View all tasks or filter tasks by category.
- Process tasks in a First-In-First-Out (FIFO) queue.
  
## Technologies
- **Language**: C#
- **Collections Used**:
  - `List<T>`: To store all tasks.
  - `Dictionary<TKey, TValue>`: To categorize tasks.
  - `Queue<T>`: To handle task execution in a queue.

## Project Structure

```plaintext
TaskManagementSystem/
│
├── Program.cs           # Main application logic
├── Task.cs              # Task class definition
└── TaskManager.cs       # TaskManager class to handle task operations
