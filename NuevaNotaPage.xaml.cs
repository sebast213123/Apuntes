namespace MosqueraAnthonny_TareaApuntes;

public partial class NuevaNotaPage : ContentPage
{
	public NuevaNotaPage()
	{
		InitializeComponent();
	}




    public class Nota
    {
        //si no están marcadas como opcionales o requeridas no se por que pero no funciona asi que vamos a permitir valores null
        public  string? Titulo { get; set; }
        public  string? Contenido { get; set; }
    }



    public static List<Nota> Notas { get; set; } = new List<Nota>();







    private async void GuardarNota_Clicked(object sender, EventArgs e)
    {
        string titulo = TituloEntry.Text;
        string contenido = ContenidoEditor.Text;

        if (!string.IsNullOrWhiteSpace(titulo) && !string.IsNullOrWhiteSpace(contenido))
        {
            App.Notas.Add(new Nota { Titulo = titulo, Contenido = contenido });
            await DisplayAlert("Nota Guardada", "Tu nota ha sido guardada con éxito.", "OK");
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
        }
    }

}