using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmHelpers;

namespace ScrollTest.ViewModels
{
    public partial class MainViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {

        public MainViewModel()
        {
            Title = "TestTitle";
        }

        [ObservableProperty]
        string title;

        [ObservableProperty]
        ObservableRangeCollection<string> quotes = new();

        [RelayCommand]
        Task LoadData()
        {
            Quotes.Clear();
            Quotes.AddRange(Jeffsum.Goldblum.ReceiveTheJeff(50, Jeffsum.JeffsumType.Quotes));

            return Task.CompletedTask;
        }
    }
}