using static MosqueraAnthonny_TareaApuntes.NuevaNotaPage;

namespace MosqueraAnthonny_TareaApuntes;

public partial class NotasPage : ContentPage
{
	public NotasPage()
	{
		InitializeComponent();
        BindingContext = this;
    }


	public List<Nota> Notas => App.Notas;

private async void AgregarNota_Clicked(object sender, EventArgs e)
{
    await Navigation.PushAsync(new NuevaNotaPage());
}


}