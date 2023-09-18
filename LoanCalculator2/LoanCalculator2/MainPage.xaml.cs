using LoanCalculator2.ViewModel;
using CommunityToolkit.Maui;

namespace LoanCalculator2;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	
}

