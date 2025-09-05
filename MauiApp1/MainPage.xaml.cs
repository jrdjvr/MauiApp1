using System;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    DateTime _currentDate = DateTime.Today;

    public MainPage()
    {
        InitializeComponent();
        UpdateDateLabel();
    }

    void OnPreviousDayClicked(object sender, EventArgs e)
    {
        _currentDate = _currentDate.AddDays(-1);
        UpdateDateLabel();
    }

    void OnNextDayClicked(object sender, EventArgs e)
    {
        _currentDate = _currentDate.AddDays(1);
        UpdateDateLabel();
    }

    void OnDateTapped(object sender, EventArgs e)
    {
        DisplayAlert("Date tapped", $"You tapped on {_currentDate:D}", "OK");
    }

    void UpdateDateLabel()
    {
        CurrentDateLabel.Text = _currentDate.ToString("MMMM dd, yyyy");
    }
}

