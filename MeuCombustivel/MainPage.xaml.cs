namespace MeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if(etanol <= (gasolina * 0.7))
                {
                    msg = "Abasteça com Etanol!";
                }
                else
                {
                    msg = "Abasteça com Gasolina!";
                }

                DisplayAlert("Calculado", msg, "OK");
            }
            catch(Exception ex)
            {
               DisplayAlert("Ops!", $"Ocorreu um erro: {ex.Message}", "OK");
            }

        } //Fecha método Button_Clicked
    } //Fecha classe MainPage
} //Fecha namespace MeuCombustivel
