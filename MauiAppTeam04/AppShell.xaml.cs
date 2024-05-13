using MauiAppTeam04.Views;

namespace MauiAppTeam04
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(PlantjesPage), typeof(PlantjesPage));
            Routing.RegisterRoute(nameof(AddPlantjesPage), typeof(AddPlantjesPage));
        }
    }
}
