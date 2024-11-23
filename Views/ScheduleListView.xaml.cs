using FocusApp.Models;
using FocusApp.ViewModels;
using Microsoft.UI.Xaml;
using System.Drawing;
using System.Transactions;
using Windows.Media.Protection.PlayReady;
using static System.Net.Mime.MediaTypeNames;

namespace FocusApp.Views;

public partial class ScheduleListView : ContentView
{

    private bool _isPanelTranslated;
    ScheduleListViewModel viewModel;
    public ScheduleListView()
    {
        InitializeComponent();
        this.BindingContext = new ScheduleListViewModel();

        panelLeft.TranslateTo(-80, 0, 150);
        this.viewModel = (ScheduleListViewModel)this.BindingContext;
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        var viewModel = (ScheduleListViewModel)BindingContext;
        viewModel.BindDataToScheduleList();
    }
    async void onNewEventButtonClicked(object sender, EventArgs args)
    {

        var button = sender as Button;
        ScheduleModel newScheduleItem = new ScheduleModel()
        {
            Title = "Schedule Item",
            Description = "Enter Description",
            StartDateTime = ((ScheduleListViewModel)BindingContext).CurrentDate,
            EndDateTime = ((ScheduleListViewModel)BindingContext).CurrentDate,
            BackgroundColor = new Microsoft.Maui.Graphics.Color(0,0,0),
            Location = ""

        };
        Frame frame = new Frame
        {
            CornerRadius = 10,
            Content = new Entry{Text = "Event Title:\nEvent Description:"},  
            
        };
        
        viewModel.AddToSchedule(newScheduleItem);
    }
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (_isPanelTranslated)
        {
            panelLeft.TranslateTo(-80, 0, 150);
        }
        else
        {
            panelLeft.TranslateTo(0, 0, 150);
        }

        _isPanelTranslated = !_isPanelTranslated;
    }
}