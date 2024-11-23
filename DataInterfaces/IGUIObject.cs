namespace FocusApp.DataInterfaces;

public interface IGUIObject
{
    public abstract void Draw();
    public abstract void Update();
    public abstract void Remove();
    public abstract void OnClicked();
}