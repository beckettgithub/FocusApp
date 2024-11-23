namespace FocusApp.DataInterfaces;

public interface IGUIObject
{
    public void Initialize();
    public void Draw();
    public void Update();
    public void Remove();
    public void OnClicked();
}