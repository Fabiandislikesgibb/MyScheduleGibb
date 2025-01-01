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
        var selectedDate = CalendarDatePicker.Date;
        var stackLayout = new StackLayout { Padding = 20, Spacing = 15 };
        stackLayout.Children.Add(new Label { Text = $"Day View for {selectedDate:MMMM dd, yyyy}", FontSize = 20, HorizontalOptions = LayoutOptions.Center });

        for (int i = 0; i < 24; i++)
        {
            stackLayout.Children.Add(new Label { Text = $"{i}:00", HorizontalOptions = LayoutOptions.Start });
        }

        CalendarContentView.Content = stackLayout;
    }

    private void ShowMonthView()
    {
        var grid = new Grid
        {
            RowSpacing = 20, // Add spacing between rows
            ColumnSpacing = 10 // Add spacing between columns if needed
        };
        for (int i = 0; i < 4; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        }
        for (int i = 0; i < 3; i++)
        {
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        }

        var months = new[] { "Jan", "Feb", "Mär", "Apr", "Mai", "Jun", "Jul", "Aug", "Sep", "Okt", "Nov", "Dez" };
        var colors = new[] { Color.FromArgb("#8B0000"), Color.FromArgb("#00008B"), Color.FromArgb("#FF8C00") }; // Darker shades of red, blue, and orange

        for (int i = 0; i < months.Length; i++)
        {
            var label = new Label
            {
                Text = months[i],
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Colors.White
            };
            var boxView = new BoxView
            {
                Color = colors[i % colors.Length].WithAlpha(0.5f), // Set transparency
                HeightRequest = 50,
                WidthRequest = 50
            };
            var frame = new Frame
            {
                Content = boxView,
                BorderColor = colors[i % colors.Length], // Full color border
                CornerRadius = 10, // Rounded corners
                Padding = 0,
                HasShadow = false,
                HeightRequest = 50,
                WidthRequest = 50
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => OnMonthTapped(i + 1); // Add tap event
            frame.GestureRecognizers.Add(tapGestureRecognizer);

            var stackLayout = new StackLayout
            {
                Children = { frame, label },
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Grid.SetRow(stackLayout, i / 3);
            Grid.SetColumn(stackLayout, i % 3);
            grid.Children.Add(stackLayout);
        }

        CalendarContentView.Content = grid;
    }

    private void OnMonthTapped(int month)
    {
        try
        {
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, month, 1);
            CalendarDatePicker.Date = firstDayOfMonth;
            ShowDayView();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in OnMonthTapped: {ex.Message}");
            // Optionally, display an alert to the user
            DisplayAlert("Error", "An error occurred while navigating to the selected month.", "OK");
        }
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