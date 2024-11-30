using static MosqueraAnthonny_TareaApuntes.NuevaNotaPage;

namespace MosqueraAnthonny_TareaApuntes;

public partial class NotasPage : ContentPage
{
	public NotasPage()
	{
		InitializeComponent();
        BindingContext = this;
		Notas = App.Notas;
    }

    public List<NuevaNotaPage.Nota> Notas { get; set; }


    private async void AgregarNota_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NuevaNotaPage());
    }



}