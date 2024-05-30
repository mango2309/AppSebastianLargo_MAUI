namespace AppSebastianLargo_MAUI.Views;

public partial class AboutPage_SL : ContentPage
{
	public AboutPage_SL()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
		if (BindingContext is SL_Models.SL_About about)
		{
			await Launcher.Default.OpenAsync("https://aka.ms/maui");
		}
			
    }
}