namespace GrabnGoApp.Views;

public partial class FavouritesPage : ContentPage
{
	public FavouritesPage(FavouritesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
