
namespace MosqueraAnthonny_TareaApuntes
{
    public partial class App : Application
    {
        public static List<NuevaNotaPage.Nota> Notas { get; internal set; }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();

            // Inicializar la lista de notas para evitar que se inicialice en automatico y provoque errores
            Notas = new List<NuevaNotaPage.Nota>();
        }
    }


}
