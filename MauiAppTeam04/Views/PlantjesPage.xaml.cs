
using ClassLibTeam04.Business.Entities;
using CommunityToolkit.Maui.Views;
using Newtonsoft.Json;


namespace MauiAppTeam04.Views;

public partial class PlantjesPage : ContentPage
{
    
    public PlantjesPage()
	{
		InitializeComponent();

        
	}
    List<Plant> plants;
    private const string REST_URL = "https://5v69rr6v-7194.euw.devtunnels.ms/api/";

    private void BtnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
		//Shell.Current.GoToAsync(nameof(AddPlantjesPage));
        LoadPlants();
        
    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        
    }

    private async void LoadPlants()
    {
        try
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{REST_URL}Plant");
                if(response.IsSuccessStatusCode)
                {

                    string json = await response.Content.ReadAsStringAsync();
                     plants = JsonConvert.DeserializeObject<List<Plant>>(json);
                     ListPlant.ItemsSource = plants;
                }
                else
                {
                    await DisplayAlert("fout", "kan geen gegevens ophalen","OK");
                }
               
            }
        }
        catch (Exception)
        {

            throw;
        }
        
    }

    private void BtnSound_Clicked(object sender, EventArgs e)
    {
      
        mediaElement.IsVisible = true;
        mediaElement.Play();
    }

}