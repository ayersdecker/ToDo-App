using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;


namespace LoanCalculator2.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [RelayCommand]
       void Add()
        {
            Text = string.Empty;
        }
    }
}
