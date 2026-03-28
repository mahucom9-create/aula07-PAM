namespace tipcalculator11;

public partial class SobrePage1 : ContentPage
{
	public SobrePage1()
	{
        InitializeComponent();
	}

    private void GitHubButton_Clicked(object sender, EventArgs e)
    {
		Launcher.OpenAsync("https://etechoracio.com.br/etechas/");
    }
}