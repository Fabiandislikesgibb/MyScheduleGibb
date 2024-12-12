// MauiApp3/MainPage.xaml.cs
using Microsoft.Maui.Controls;

namespace MauiApp3
{
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
            foreach (var item in ToolbarItems)
            {
                if (item.Text == CurrentView)
                {
                    item.Style = (Style)Application.Current.Resources["SelectedToolbarItemStyle"];
                }
                else
                {
                    item.Style = (Style)Application.Current.Resources["ToolbarItemStyle"];
                }
            }
        }
    }
}