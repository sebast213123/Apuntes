namespace MosqueraAnthonny_TareaApuntes;

public partial class VerNotasPage : ContentPage
{
    public VerNotasPage()
    {
        InitializeComponent();
        CargarNotas();
    }

    public List<NuevaNotaPage.Nota> Notas { get; set; }

    private async Task CargarNotas()
    {
        Notas = await App.Database.ObtenerNotasAsync();
        BindingContext = null; // Reinicia el contexto para refrescar la UI
        BindingContext = this;
    }

    private async void RecargarNotas_Clicked(object sender, EventArgs e)
    {
        await CargarNotas();
    }
}

