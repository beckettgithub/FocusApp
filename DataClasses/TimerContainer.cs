using FocusApp.DataInterfaces;
using System.Timers;
using Timer = System.Timers.Timer;

namespace FocusApp.DataClasses;

public class TimerContainer : IGUIObject
{
    private Timer timer;

    public delegate void OnTimerComplete();

    public event OnTimerComplete OnTimerCompleteEvent;

    public void Initialize()
    {
        throw new System.NotImplementedException();
    }
    public void Draw()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void OnClicked()
    {
        
    }

    public void OnDragged()
    {
        
    }
    

    public void Remove()
    {
        throw new NotImplementedException();
    }
}