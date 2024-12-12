namespace MauiApp3;

public partial class HelpPage : ContentPage
{
    public HelpPage()
    {
        InitializeComponent();
        var faqList = new List<FaqItem>
        {
            new FaqItem { Question = "Frage 1", Answer = "Antwort 1" },
            new FaqItem { Question = "Frage 2", Answer = "Antwort 2" }
        };
        FaqCollectionView.ItemsSource = faqList;
    }
}

public class FaqItem
{
    public string Question { get; set; }
    public string Answer { get; set; }
    public bool IsVisible { get; set; }
}