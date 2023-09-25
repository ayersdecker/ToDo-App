using LoanCalculator2.ViewModel;
using CommunityToolkit.Maui;
using LoanCalculator2.Models;

namespace LoanCalculator2;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}


    public void Save_Clicked(object sender, EventArgs e)
    {
       
       
        
        
    }
}

