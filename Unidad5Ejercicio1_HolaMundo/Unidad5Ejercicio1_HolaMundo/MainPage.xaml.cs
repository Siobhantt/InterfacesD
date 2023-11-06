using Biblioteca;
using System.Diagnostics;

namespace Unidad5Ejercicio1_HolaMundo
{

    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
          
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            clsPersona p1 = new clsPersona();

            p1.Nombre = txtNombre.Text;
            await DisplayAlert("Mensaje", $"Hola {p1.Nombre}", "Vale");

            p1.Apellido = await DisplayPromptAsync($"Hola {p1.Apellido}", "Escribe tu apellido:");

            await DisplayAlert("Saludo", $"Hola {p1.NombreCompleto}", "Hola!");

            var progressBAr = new ProgressBar
            {
                Progress = .2,
            };
            await progressBAr.ProgressTo(.75, 500, Easing.Linear);
            Debug.WriteLine("??");
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }

}