namespace MauiApp3;

public partial class App : Application
{
    public static List<CalendarEvent> Events { get; set; } = new List<CalendarEvent>();

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}

public class CalendarEvent
{
    public string Title { get; set; }
    public DateTime StartTime { get; set; }
    public double Duration { get; set; }
    public string EventType { get; set; }
}