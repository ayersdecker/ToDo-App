using LoanCalculator2.ViewModel;

namespace LoanCalculator2;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}