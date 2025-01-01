namespace MauiApp3;

public partial class CalendarPage : ContentPage
{
    public CalendarPage()
    {
        InitializeComponent();
        ShowDayView();
    }

    private void OnDayViewClicked(object sender, EventArgs e)
    {
        ShowDayView();
    }

    private void OnMonthViewClicked(object sender, EventArgs e)
    {
        ShowMonthView();
    }

    private void OnYearViewClicked(object sender, EventArgs e)
    {
        ShowYearView();
    }

    private void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        // Handle date selection if needed
    }

    private void ShowDayView()
    {
        var stackLayout = new StackLayout { Padding = 20, Spacing = 15 };
        for (int i = 0; i < 24; i++)
        {
            stackLayout.Children.Add(new Label { Text = $"{i}:00"});
        }
        CalendarContentView.Content = stackLayout;
    }

    private void ShowMonthView()
    {
        var grid = new Grid();
        for (int i = 0; i < 7; i++)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        }

        var days = new[] { "Mon", "Die", "Mit", "Don", "Fre", "Sam", "Son" };
        for (int i = 0; i < days.Length; i++)
        {
            var label = new Label { Text = days[i] };
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, i);
            grid.Children.Add(label);
        }
        // Add more rows for days
        for (int row = 1; row <= 5; row++)
        {
            for (int col = 0; col < 7; col++)
            {
                var boxView = new BoxView { Color = Colors.LightGray, HeightRequest = 50, WidthRequest = 50 };
                Grid.SetRow(boxView, row);
                Grid.SetColumn(boxView, col);
                grid.Children.Add(boxView);
            }
        }
        CalendarContentView.Content = grid;
    }

    private void ShowYearView()
    {
        var stackLayout = new StackLayout { Padding = 20, Spacing = 15 };
        stackLayout.Children.Add(new Button { Text = "2024", Command = new Command(() => OnYearSelected(2024)) });
        stackLayout.Children.Add(new Button { Text = "2025", Command = new Command(() => OnYearSelected(2025)) });
        CalendarContentView.Content = stackLayout;
    }

    private void OnYearSelected(int year)
    {
        // Handle year selection if needed
    }
}