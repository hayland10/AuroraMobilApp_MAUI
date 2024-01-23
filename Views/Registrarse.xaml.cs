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
        string constrase�a = lblContrase�a.Text;
        string veriContrase�a = lblContrase�aVeri.Text;

        if (constrase�a == veriContrase�a)
        {
            user newUser = new user()
            {
                usuario = userName,
                contrase�a = constrase�a

            };
            App.userRepo.Add(newUser);

            DisplayAlert("Registrado","El usuario a sido registrado con exito","Aceptar");
        }
        else {
            DisplayAlert("Error","Sus contrase�as no coinciden","ACEPTAR");
        }

    }
}