using LoanCalculator2.ViewModel;

namespace LoanCalculator2;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	
}

