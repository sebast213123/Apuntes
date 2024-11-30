
namespace MosqueraAnthonny_TareaApuntes
{
    public partial class App : Application
    {
        public static List<NuevaNotaPage.Nota> Notas { get; internal set; } //tal vez esta linea sea necesario borrar despues
        public static BaseDeDatos Database { get; private set; }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notas.db3");
            Database = new BaseDeDatos(dbPath);

            // Inicializar la lista de notas para evitar que se inicialice en automatico y provoque errores
            Notas = new List<NuevaNotaPage.Nota>(); //creo que esta tambien habrá que borrar después
        }
    }



    /*COSAS QUE ME FALTAN AGREGAR AL TRABAJO
     -LAS IMAGENES DE LOS TAPS NO FUNCIONAN POSIBLEMENTE SEA PORQUE TIENEN QUE SER PNG
    -AGREGAR UN TAB PARA PODER VER LAS NOTAS
    -MEJORAR LA ESTETICA DEL PROEYCTO
    -AGREGAR LOS FLYOUTS (PUEDES PONER EN EL ABOUT EN UNO TU NOMBRE Y EN EL OTRO TU DESCRIPCIÓN)
    -DEBE TENER EN EL ENCABEZADO MI NOMBRE*/

}
