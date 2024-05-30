namespace AppSebastianLargo_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.SL_NotePage), typeof(Views.SL_NotePage));

		}
    }
}
