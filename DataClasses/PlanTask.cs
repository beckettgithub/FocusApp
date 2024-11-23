using FocusApp.DataInterfaces;

namespace FocusApp.DataClasses;

public class PlanTask: IGUIObject
{
    public bool completed;
    #region GUIObjectImplementation
    
    public void Initialize()
    {
        completed = false;
    }
    
    public void Draw()
    {
        throw new NotImplementedException();
    }

    public void Remove()
    {
        throw new NotImplementedException();
    }

    public void OnDragged()
    {
        
    }
    public void OnClicked()
    {
        //toggle completed
        completed = !completed;
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
    #endregion 
    public int priority;
    public Color color;
    public string description = "Task";
}