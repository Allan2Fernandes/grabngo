﻿namespace GrabnGoApp.Views;

public partial class MenuPage : ContentPage
{
	public MenuPage(MenuViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
