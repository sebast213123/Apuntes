namespace MosqueraAnthonny_TareaApuntes;

public partial class NotasPage : ContentPage
{
    public NotasPage()
    {
        InitializeComponent();
        CargarNotas();
    }

    public List<NuevaNotaPage.Nota> Notas { get; set; }

    private async void CargarNotas()
    {
        Notas = await App.Database.ObtenerNotasAsync();
        BindingContext = null; // Reinicia el contexto para refrescar la UI
        BindingContext = this;
    }

    private async void AgregarNota_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NuevaNotaPage());
    }
}
