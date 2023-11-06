namespace Tema07.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
    private async void Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
