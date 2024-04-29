namespace ControlDam_YounesSlamani;

public partial class Bravo : ContentPage
{
    private int nb;

    public Bravo(int nb)
    {


        this.nb = nb;

        InitializeComponent();

        counterLabel.Text = "nombre de passe word juste est " + nb.ToString() + " fois";
    }

   
    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}