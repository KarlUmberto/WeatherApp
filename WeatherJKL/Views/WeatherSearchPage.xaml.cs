namespace Views;

public partial class WeatherSearchPage : ContentPage
{
	public WeatherSearchPage()
	{
        InitializeComponent();
	}
    private async void OnSearchButtonPressed(object sender, EventArgs e)
    {
        var searchBar = (SearchBar)sender;
        var query = searchBar.Text;
        //var filteredCities = ViewModel.Cities.Where(c => c.Name.Contains(query)).ToList();
        //await Navigation.PushAsync(new SearchResultsPage(filteredCities));
    }
}