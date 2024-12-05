namespace MauiApp3;

public partial class MainPage : TabbedPage
{
    public DateTime SelectedDate { get; set; } = DateTime.Now;
    public string CurrentView { get; set; } = "Month"; // Default view

    public MainPage()
    {
        InitializeComponent();
        UpdateButtonColors();
    }

    private void OnTodayButtonClicked(object sender, EventArgs e)
    {
        SelectedDate = DateTime.Now;
        // Update the view to reflect the current date
    }

    private void OnDayViewButtonClicked(object sender, EventArgs e)
    {
        CurrentView = "Day";
        UpdateButtonColors();
    }

    private void OnWeekViewButtonClicked(object sender, EventArgs e)
    {
        CurrentView = "Week";
        UpdateButtonColors();
    }

    private void OnMonthViewButtonClicked(object sender, EventArgs e)
    {
        CurrentView = "Month";
        UpdateButtonColors();
    }

    private void OnYearViewButtonClicked(object sender, EventArgs e)
    {
        CurrentView = "Year";
        UpdateButtonColors();
    }

    private void UpdateButtonColors()
    {
        DayViewButtonColor = CurrentView == "Day" ? "#3A75C4" : "#F2F2F2";
        WeekViewButtonColor = CurrentView == "Week" ? "#3A75C4" : "#F2F2F2";
        MonthViewButtonColor = CurrentView == "Month" ? "#3A75C4" : "#F2F2F2";
        YearViewButtonColor = CurrentView == "Year" ? "#3A75C4" : "#F2F2F2";
    }

    public string DayViewButtonColor { get; set; }
    public string WeekViewButtonColor { get; set; }
    public string MonthViewButtonColor { get; set; }
    public string YearViewButtonColor { get; set; }
}