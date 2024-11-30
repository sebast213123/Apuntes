namespace MosqueraAnthonny_TareaApuntes;

public partial class VerNotasPage : ContentPage
{
    public VerNotasPage()
    {
        InitializeComponent();

        // asignamos el contexto de datos a la lista de notas con el blindingcontext
        BindingContext = this;
        Notas = App.Notas; // se vincula con la lista de notas ya existente
    }

    public List<NuevaNotaPage.Nota> Notas { get; set; }
}
