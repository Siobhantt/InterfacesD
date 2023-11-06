namespace Tema07.Views;

public partial class Pagina4 : ContentPage
{
#region Constructores
	public Pagina4()
	{
		InitializeComponent();
	}
	public Pagina4(clsPersona clsPersona)
	{
		
		InitializeComponent();

		lblNombre.Text = clsPersona.Nombre;
		lblApellido.Text = clsPersona.Apellido;
    }

	private async void 
}