using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LoanCalculator2.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace LoanCalculator2.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;

        public MainViewModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<TodoModel>();
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<TodoModel> items;

        [ObservableProperty]
        string text;
        [ObservableProperty]
        string description;
        [ObservableProperty]
        string priority;


        [RelayCommand]
       async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Ooops!", "No Internet Connection", "O.K.");
                return;
            }

            Items.Add(new TodoModel(Text));
            //add our item
            Text = string.Empty;
        } 
        

        [RelayCommand]
        void Delete(string s)
        {
            TodoModel todo = new(s);
            if(Items.Contains(todo))
            {
                Items.Remove(todo);
            }
        }
        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }
    }
}
