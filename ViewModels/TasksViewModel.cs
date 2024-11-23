using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DittoMauiTasksApp.Utils;
using FocusApp.DataInterfaces;
using FocusApp.DataClasses;
namespace FocusApp.ViewModels;

public partial class TasksViewModel : ObservableObject
{
    private ObservableCollection<PlanTask> tasks = new ObservableCollection<PlanTask>();

    public TasksViewModel()
    {
        
    }
    public void AddTask(PlanTask task)
    {
        tasks.add(task);
    }
}