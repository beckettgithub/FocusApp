using FocusApp.DataInterfaces;

namespace FocusApp.DataClasses;

public class Notepad : IGUIObject
{
    #region  GUIOBjectImplementation

    public void Draw()
    {
        
    }

    public void Update()
    {
        
    }

    public void Remove()
    {
        
    }

    public void Initialize()
    {
        
    }

    public void OnClicked()
    {
        
    }
    #endregion
    private string[] lines;

    public void EditLine(int line, string text)
    {
        lines[line] = text;
    }
}