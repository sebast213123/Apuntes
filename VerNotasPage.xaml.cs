namespace MosqueraAnthonny_TareaApuntes;

public partial class VerNotasPage : ContentPage
{
    public VerNotasPage()
    {
        InitializeComponent();

        // asignamos el contexto de datos a la lista de notas con el blindingcontext
        BindingContext = this;

        Notas = App.Notas.OrderBy(n => n.FechaHora).ToList(); // se vincula con la lista de notas ya existente y se ordena por fecha
        
    }

    public List<NuevaNotaPage.Nota> Notas { get; set; }





    private void RecargarNotas_Clicked(object sender, EventArgs e)
    {
        Notas = App.Notas.OrderBy(n => n.FechaHora).ToList();
        BindingContext = null; // pa reiniciar
        BindingContext = this;
    }
}
