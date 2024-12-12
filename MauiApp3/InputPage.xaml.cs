namespace MauiApp3;

public partial class InputPage : ContentPage
{
    public InputPage()
    {
        InitializeComponent();
        EventDatePicker.Date = DateTime.Now;
        DurationSlider.ValueChanged += OnDurationSliderValueChanged;
        ReminderSwitch.Toggled += OnReminderSwitchToggled;
    }

    private void OnDurationSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        DurationLabel.Text = $"Dauer: {e.NewValue} Stunde{(e.NewValue > 1 ? "n" : "")}";
    }

    private void OnReminderSwitchToggled(object sender, ToggledEventArgs e)
    {
        ReminderTimePicker.IsVisible = e.Value;
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        bool isValid = ValidateInputs();
        if (isValid)
        {
            // Save the event and navigate to the calendar page
            // Display a confirmation message if needed
        }
    }

    private void OnResetClicked(object sender, EventArgs e)
    {
        TitleEntry.Text = string.Empty;
        EventDatePicker.Date = DateTime.Now;
        EventTimePicker.Time = new TimeSpan(8, 0, 0);
        DurationSlider.Value = 1;
        EventTypePicker.SelectedIndex = -1;
        ReminderSwitch.IsToggled = false;
        DescriptionEntry.Text = string.Empty;
        TitleError.IsVisible = false;
        DateTimeError.IsVisible = false;
        EventTypeError.IsVisible = false;
    }

    private bool ValidateInputs()
    {
        bool isValid = true;

        if (string.IsNullOrWhiteSpace(TitleEntry.Text))
        {
            TitleError.IsVisible = true;
            isValid = false;
        }
        else
        {
            TitleError.IsVisible = false;
        }

        DateTime selectedDateTime = EventDatePicker.Date + EventTimePicker.Time;
        if (selectedDateTime <= DateTime.Now)
        {
            DateTimeError.IsVisible = true;
            isValid = false;
        }
        else
        {
            DateTimeError.IsVisible = false;
        }

        if (EventTypePicker.SelectedIndex == -1)
        {
            EventTypeError.IsVisible = true;
            isValid = false;
        }
        else
        {
            EventTypeError.IsVisible = false;
        }

        return isValid;
    }
}