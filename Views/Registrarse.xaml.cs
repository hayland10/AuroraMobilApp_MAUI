using AuroraApp_MAUI.Models;

namespace AuroraApp_MAUI.Views;

public partial class Registrarse : ContentPage
{
	public Registrarse()
	{
		InitializeComponent();
	}
    private void Regresar_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void registrarse_CLicked(object sender, EventArgs e)
    {
        string userName = lblUser.Text;
        string constraseņa = lblContraseņa.Text;
        string veriContraseņa = lblContraseņaVeri.Text;

        if (constraseņa == veriContraseņa)
        {
            user newUser = new user()
            {
                usuario = userName,
                contraseņa = constraseņa

            };
            App.userRepo.Add(newUser);

            DisplayAlert("Registrado","El usuario a sido registrado con exito","Aceptar");
        }
        else {
            DisplayAlert("Error","Sus contraseņas no coinciden","ACEPTAR");
        }

    }
}