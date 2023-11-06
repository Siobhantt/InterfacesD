namespace Tema07.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new PaginaTabbed());
	}
    private async void ClickedPag4(object sender, EventArgs e)
    {
        clsPersona clsPersona = new clsPersona();
            clsPersona.Nombre = entryNombre.Text;
        clsPersona.Apellido = entryApellidos.Text;
    
        await Navigation.PushAsync(new Pagina4(clsPersona));
    }
    private async void ClickedPag5(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pagina5());
    }
}