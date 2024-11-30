
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



    /*COSAS QUE ME FALTAN AGREGAR AL TRABAJO
     -LAS IMAGENES DE LOS TAPS NO FUNCIONAN POSIBLEMENTE SEA PORQUE TIENEN QUE SER PNG
    -AGREGAR UN TAB PARA PODER VER LAS NOTAS
    -DEBE TENER EN EL ENCABEZADO MI NOMBRE*/

}
