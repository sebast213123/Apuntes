
namespace MosqueraAnthonny_TareaApuntes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

        }

        public static List<NuevaNotaPage.Nota> Notas { get; internal set; }
    }

}
