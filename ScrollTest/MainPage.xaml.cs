using ScrollTest.ViewModels;

namespace ScrollTest;

public partial class MainPage : ContentPage
{
    private MainViewModel _vm;

    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        _vm = vm;
        BindingContext = vm;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if (_vm.Quotes.Count == 0)
            await _vm.LoadDataCommand.ExecuteAsync(null);
    }
}

