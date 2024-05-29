namespace AppSebastianLargo_MAUI;

public partial class AboutPage_SL : ContentPage
{
	public AboutPage_SL()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}