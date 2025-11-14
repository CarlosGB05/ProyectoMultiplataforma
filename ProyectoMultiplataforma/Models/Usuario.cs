using System;
using System.ComponentModel.DataAnnotations;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ProyectoMultiplataforma.Models;

public partial class Usuario:ObservableValidator
{
    [ObservableProperty]
    [Required(ErrorMessage = "El nombre es obligatorio")] 
    private string nombre = String.Empty;
    
    [ObservableProperty]
    [Required(ErrorMessage = "El correo es obligatorio")]
    private string correo = String.Empty;
    
    [ObservableProperty]
    [Required(ErrorMessage = "La contraseña es obligatorio")]
    private string contrasena = String.Empty;
    
    [ObservableProperty]
    [Required(ErrorMessage = "La contraseña es incorrecta")]
    private string verificarContrasena = String.Empty;

    [ObservableProperty] 
    [Required(ErrorMessage = "La fecha es obligatorio")]
    private DatePicker fechaNacimiento;
    
    [ObservableProperty]
    [Required(ErrorMessage = "El telefono es obligatorio")]
    private string telefono = String.Empty;

    [ObservableProperty] 
    [Required(ErrorMessage = "Las condiciones es obligatorio")]
    private bool condiciones = false;

    public bool Validar()
    {
        ValidateAllProperties();
        return !HasErrors;
    }

}