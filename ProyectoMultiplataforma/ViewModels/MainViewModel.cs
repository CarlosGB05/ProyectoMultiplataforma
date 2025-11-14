using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DialogHostAvalonia;
using ProyectoMultiplataforma.Views.Dialogs;

namespace ProyectoMultiplataforma.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Welcome to Avalonia!";

    [RelayCommand]
    public void OpenRegistro()
    {
        registro registro = new registro();
        registro.DataContext = new RegistroViewModel();
        DialogHost.Show(registro,"registro");
    }
}