namespace MauiApp3;

public partial class InputPage : ContentPage
{
    public InputPage()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text))
        {
            ErrorMessage.Text = "Name darf nicht leer sein.";
            ErrorMessage.IsVisible = true;
        }
        else
        {
            ErrorMessage.IsVisible = false;
            // Handle valid input
        }
    }
}