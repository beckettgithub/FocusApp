using FocusApp.ViewModels;
using Microsoft.UI.Xaml;
using System.Transactions;
using Windows.Media.Protection.PlayReady;

namespace FocusApp.Views;

public partial class ScheduleListView : ContentView
{

    private bool _isPanelTranslated;
    public ScheduleListView()
    {
        InitializeComponent();
        this.BindingContext = new ScheduleListViewModel();

        panelLeft.TranslateTo(-80, 0, 150);
    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        var viewModel = (ScheduleListViewModel)BindingContext;
        viewModel.BindDataToScheduleList();
    }
    //async void OnClick(object sender, EventArgs args)
    //{

        //var button = sender as Button;
        
    //}
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