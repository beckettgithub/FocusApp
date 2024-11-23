using System.Collections.Generic;
using System.Linq;
using FocusApp.DataInterfaces;

namespace FocusApp.DataClasses;

public class ToDoList : IGUIObject
{
    
    private List<PlanTask> tasks;
    public delegate void OnCompleteTaskDelegate(PlanTask task);
    public event OnCompleteTaskDelegate onCompleteTaskEvent;
    #region GUIObjectImplementation

    public void Initialize()
    {
        tasks = new List<PlanTask>();
    }
    public void Remove()
    {
        
    }

    public void Draw()
    {
        
    }

    public void Update()
    {
        
    }

    public void OnClicked()
    {
        
    }

    public void OnDragged()
    {
        
    }
    #endregion
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