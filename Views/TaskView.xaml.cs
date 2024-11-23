using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusApp.DataClasses;
using FocusApp.ViewModels;

namespace FocusApp.Views;

public partial class TaskView : ContentView
{
    private TasksViewModel tasksModel;
    public TaskView(TasksViewModel viewModel)
    {
        InitializeComponent();
        tasksModel = viewModel;
        BindingContext = viewModel;
    }

    public void OnPlusButtonClicked()
    {
        tasksModel.AddTask(new PlanTask());
    }

    public void OnTaskClicked(object sender, )
    {
        
    }
}