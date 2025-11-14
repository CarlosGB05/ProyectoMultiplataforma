using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DialogHostAvalonia;
using ProyectoMultiplataforma.Models;

namespace ProyectoMultiplataforma.ViewModels;

public partial class RegistroViewModel:ViewModelBase
{
    [ObservableProperty] 
    private Usuario usuario = new();
    
    
    [RelayCommand]
    public void CloseRegistro()
    {
        DialogHost.Close("registro");
    }

    [RelayCommand]
    public void CreateUser()
    {
        if (Usuario.Validar())
        {
            CloseRegistro();
        }
    }
}