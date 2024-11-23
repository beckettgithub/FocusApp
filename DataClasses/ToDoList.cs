namespace FocusApp.DataClasses;

public class ToDoList
{
    public ToDoList(PlanTask[] tasks)
    {
        this.tasks = tasks;
    }
    private PlanTask[] tasks;
    public delegate void OnCompleteTaskDelegate(PlanTask task);
    public event OnCompleteTaskDelegate OnCompleteTaskEvent;
}