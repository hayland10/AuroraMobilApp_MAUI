namespace AuroraApp_MAUI.Views;

public partial class MenuPrincipal : ContentPage
{
    public MenuPrincipal()
    {
        InitializeComponent();

    }

    private void IniciarSesion_Clicked(object sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(IniciarSesion));
    }
    private void Registrarse_Clicked(object sender, EventArgs e) {
        Shell.Current.GoToAsync(nameof(Registrarse));
    }
}