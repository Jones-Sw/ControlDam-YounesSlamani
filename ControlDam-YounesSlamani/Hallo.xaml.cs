namespace ControlDam_YounesSlamani;

public partial class Hallo : ContentPage
{
    string Loginpassword = "DAM2024";
    public int nb = 0;
    public static int LoginSuccessCounter { get; set; } = 1;
    public Hallo()
	{
		InitializeComponent();
	}

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        if (passwordEntry.Text == Loginpassword)
        {
            nb++;
            this.Navigation.PushAsync(new Bravo(nb));

        }
        else
        {
            await DisplayAlert("Error password", "Password not valid", "Ok");
        }
    }
}