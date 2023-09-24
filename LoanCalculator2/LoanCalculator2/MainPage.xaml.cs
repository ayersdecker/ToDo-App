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

    private void Picker_Unfocused(object sender, FocusEventArgs e)
    {
		string selected = (string)((Picker)sender).SelectedItem;
		TodoModel todo = sender as TodoModel;
        todo.Priority = selected;
    }

    private void Save_Clicked(object sender, EventArgs e)
    {
       
    }
}

