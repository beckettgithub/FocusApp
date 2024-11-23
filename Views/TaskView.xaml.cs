using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusApp.DataClasses;
using FocusApp.DataInterfaces;
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
        PlanTask task = new PlanTask();
        Frame addTaskFrame = new Frame
        {

            CornerRadius = 10,
            Content = Entry taskEntry = new Entry { Placeholder = "enter task here"
            };
        
            
        }
        taskEntry.ReturnCommand = task.UpdateText(taskEntry.Text);
        string newTaskText = taskEntry.Text;
        task.Text = newTaskText;
    }

    public void OnTaskClicked(object sender, EventArgs args)
    {
        if (sender == null) return;
        IGUIObject target = sender as IGUIObject;
        target?.OnClicked();
    }
}