namespace EjUnidad6
{
    public partial class MainPage : ContentPage
    {
        Boolean btYaExiste = false;

        public MainPage()
        {
            InitializeComponent();
           

        }


        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (btYaExiste==false)
            {
                Button bt3 = new Button
                {   
                    Text = "Boton 3",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    BackgroundColor = Color.FromArgb("#0000FF"),
                    WidthRequest = 200,
                    HeightRequest = 70,
                    FontFamily = "Verdana",
                    BorderColor = Color.FromArgb("#FFFF00"),
                    BorderWidth = 5,
                    IsEnabled = true
                };
                btYaExiste = true;
                vslBotones.Children.Add(bt3);
                bt3.Clicked += new EventHandler(eventobt3);
            }
        }
        private void eventobt3(object sender, EventArgs e)
        {
            vslBotones.Children.Remove(bt1);
            bt2.Text = "Crear controles en tiempo de ejecución mola";
        }

    }
}