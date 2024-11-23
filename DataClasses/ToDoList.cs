using System.Collections.Generic;

namespace FocusApp.DataClasses;

public class ToDoList
{
    private List<PlanTask> tasks;
    public delegate void OnCompleteTaskDelegate(PlanTask task);
    public event OnCompleteTaskDelegate onCompleteTaskEvent;
    
    public ToDoList()
    {
        tasks = new List<PlanTask>();
    }

    public void AddTask(PlanTask task)
    {
        tasks.Add(task);
    }

    public void CompleteTask(PlanTask task)
    {
        foreach (PlanTask i in tasks)
        {
            if(i == task) onCompleteTaskEvent?.Invoke(i);
            tasks.Remove(i);
        }
    }
}