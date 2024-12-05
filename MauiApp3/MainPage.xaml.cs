namespace MauiApp3;

public partial class MainPage : TabbedPage
{
    public DateTime SelectedDate { get; set; } = DateTime.Now;
    public string CurrentView { get; set; } = "Month"; // Default view

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTodayButtonClicked(object sender, EventArgs e)
    {
        SelectedDate = DateTime.Now;
        // Update the view to reflect the current date
    }

    private void OnViewChanged(object sender, EventArgs e)
    {
        // Logic to handle view change
    }
}