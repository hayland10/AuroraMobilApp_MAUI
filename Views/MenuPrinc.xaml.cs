namespace AuroraApp_MAUI.Views;

public partial class MenuPrinc : ContentPage
{
	public MenuPrinc()
	{
		InitializeComponent();
	}
    private void Regresar_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void Reservar_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(ReservaPage));
    }
}