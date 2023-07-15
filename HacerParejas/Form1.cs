namespace HacerParejas
{
    public partial class Form1 : Form
    {
        // Acá vamos a declarar las variables fundamentales para este problema.

        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string primeraOportunidad; // Primera oportunidad.
        string ultimaOportunidad; // Última oportunidad.
        int intentos; // Número de intentos.
        List<PictureBox> imagenes = new List<PictureBox>(); // Para las imágenes importadas.
        PictureBox imagenA; // Para la primera imagen (Primera pareja).
        PictureBox imagenB; // Para la segunda imagen (Segunda pareja).
        int tiempoTotal = 30; // Comienza el juego durante 30 segundos.
        int cuentaRegresiva; // Parte desde 30, 29, 28, 27, 26, 25, etc...
        bool gameOver = false; // Cuando no termina el juego.
        // Método de ejecución inicial de la interfaz.
        public Form1()
        {
            InitializeComponent(); // Llamado del método inicial.
            LoadPictures(); // Para poder estar las imágenes al ejecutar, hay que cargarlas mediante edición.
        }

        // Método de evento del temporizador.
        private void TimeEvent(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }

        // Método de evento de reiniciar el juego.
        private void RestartGameEvent(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }

        // Método para cargar imágenes.
        private void LoadPictures()
        {
            // EN INSTANTES...
        }

        // Método para reiniciar el juego.
        private void RestartGame()
        {
            // EN INSTANTES...
        }

        // Método para revisar imágenes.
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            // EN INSTANTES...
        }

        // Método para terminar la partida.

        private void GameOver()
        {
            // EN INSTANTES...
        }
    }
}