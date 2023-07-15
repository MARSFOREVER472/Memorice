namespace HacerParejas
{
    public partial class Form1 : Form
    {
        // Ac� vamos a declarar las variables fundamentales para este problema.

        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string primeraOportunidad; // Primera oportunidad.
        string ultimaOportunidad; // �ltima oportunidad.
        int intentos; // N�mero de intentos.
        List<PictureBox> imagenes = new List<PictureBox>(); // Para las im�genes importadas.
        PictureBox imagenA; // Para la primera imagen (Primera pareja).
        PictureBox imagenB; // Para la segunda imagen (Segunda pareja).
        int tiempoTotal = 30; // Comienza el juego durante 30 segundos.
        int cuentaRegresiva; // Parte desde 30, 29, 28, 27, 26, 25, etc...
        bool gameOver = false; // Cuando no termina el juego.
        // M�todo de ejecuci�n inicial de la interfaz.
        public Form1()
        {
            InitializeComponent(); // Llamado del m�todo inicial.
            LoadPictures(); // Para poder estar las im�genes al ejecutar, hay que cargarlas mediante edici�n.
        }

        // M�todo de evento del temporizador.
        private void TimeEvent(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }

        // M�todo de evento de reiniciar el juego.
        private void RestartGameEvent(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }

        // M�todo para cargar im�genes.
        private void LoadPictures()
        {
            // EN INSTANTES...
        }

        // M�todo para reiniciar el juego.
        private void RestartGame()
        {
            // EN INSTANTES...
        }

        // M�todo para revisar im�genes.
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            // EN INSTANTES...
        }

        // M�todo para terminar la partida.

        private void GameOver()
        {
            // EN INSTANTES...
        }
    }
}