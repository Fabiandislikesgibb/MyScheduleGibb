namespace MauiApp3;

public partial class HelpPage : ContentPage
{
    public HelpPage()
    {
        InitializeComponent();
    }

    private void OnQuestionClicked(object sender, EventArgs e)
    {
        Button button = sender as Button;
        Label answerLabel = null;

        switch (button.Text)
        {
            case "Wie organisiere ich meine Termine und Aufgaben?":
                answerLabel = Answer1;
                break;
            case "Welche Funktionen fehlen mir in den aktuellen Tools?":
                answerLabel = Answer2;
                break;
            case "Wie nutze ich Erinnerungen und Benachrichtigungen?":
                answerLabel = Answer3;
                break;
            case "Welche Zielgruppen sprechen wir an?":
                answerLabel = Answer4;
                break;
            case "Wie sicher sind meine Daten in der App?":
                answerLabel = Answer5;
                break;
        }

        if (answerLabel != null)
        {
            answerLabel.IsVisible = !answerLabel.IsVisible;
        }
    }
}