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
            int leftPos = 20; // Posici�n en X.
            int topPos = 20; // Posici�n en Y.
            int rows = 0; // Cantidad de fichas en filas.

            // Crearemos un ciclo for mediante filas las acciones que realizar�n las im�genes.

            for (int i = 0; i < 12; i++)
            {
                PictureBox nuevaFoto = new PictureBox(); // Foto o imagen.
                nuevaFoto.Height = 50; // Altura de la foto.
                nuevaFoto.Width = 50; // Ancho de la foto.
                nuevaFoto.BackColor = Color.Gold; // Color de fondo para la foto.
                nuevaFoto.SizeMode = PictureBoxSizeMode.StretchImage; // Para fijar el tama�o de la foto.
                nuevaFoto.Click += NuevaFoto_Click; // Para cliquear cualquier foto del tablero.
                imagenes.Add(nuevaFoto); // A�adir fotos.

                // Vamos a crear condiciones if mediante cantidad de filas.

                if (rows < 3) // Si la cantidad de filas es menor que 3.
                {
                    rows++; // Se incrementa la cantidad de filas.
                    nuevaFoto.Left = leftPos; // Posici�n en X de la foto.
                    nuevaFoto.Top = topPos; // Posici�n en Y de la foto.
                    this.Controls.Add(nuevaFoto); // A�adir controles a la foto.
                    leftPos = leftPos + 60; // La posici�n en X se incrementa a 60.
                }

                if (rows == 3) // Si la cantidad de filas es igual que 3.
                {
                    leftPos = 20; // Posici�n en X estar� en 20.
                    topPos += 60; // Posici�n en Y se incrementa desde 60.
                    rows = 0; // Cantidad de filas vac�a.
                }
            }
            RestartGame(); // Para reinicar el juego mediante llamado del m�todo anterior.
        }

        // M�todo extra para cliquear una foto incluida una excepci�n.
        private void NuevaFoto_Click(object? sender, EventArgs e)
        {
            // throw new NotImplementedException(); // Excepci�n no controlada.
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