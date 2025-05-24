using MauiApp1Hotel.Models;

namespace MauiApp1Hotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            

             new Quarto()
            {
                 //Inclusão do quarto Suíte Presidencial
                Descricao = "Suíte Presidencial",
                ValorDiariaAdulto = 950.0,
                ValorDiariaCrianca = 425.0
            },
              new Quarto()
            {
                //Inclusão do quarto Suíte Master
                Descricao = "Suíte Master",
                ValorDiariaAdulto = 700.0,
                ValorDiariaCrianca = 350.0
            },
              new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 600.0,
                ValorDiariaCrianca = 300.0
            },
              new Quarto()
            {
                //Inclusão do quarto Suíte Premium
                Descricao = "Suíte Premium",
                ValorDiariaAdulto = 500.0,
                ValorDiariaCrianca = 250.0
            },
              new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 350.0,
                ValorDiariaCrianca =175.0
                //Exclusão do último quarto, pois está fora do padrão do negócio
            }
        }; 
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState) 
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
