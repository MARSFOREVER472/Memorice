using System.DirectoryServices;

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
            cuentaRegresiva--; // Se inicializa en cuenta regresiva el temporizador.

            lblTimeLeft.Text = " Tiempo restante: " + cuentaRegresiva;

            if (cuentaRegresiva < 1) // Cuando llega a 0 el temporizador...
            {
                GameOver("Se acab� el tiempo, Perdi� la partida! :("); // Perdi� la partida.

                // Crearemos un ciclo foreach mediante un algoritmo que no visualice primero las im�genes extra�das de un archivo o de un directorio.

                foreach (PictureBox x in imagenes)
                {
                    if (x.Tag != null)
                    {
                        x.Image = Image.FromFile("pics/" + (string)x.Tag + ".png"); // Las im�genes tienen que estar en formato .png.
                    }
                }
            }
        }

        // M�todo de evento de reiniciar el juego.
        private void RestartGameEvent(object sender, EventArgs e)
        {
            RestartGame(); // Llamado del m�todo de reinicio para este m�todo.
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

            // Cuando termina la partida...

            if (gameOver)
            {
                // No se registrar� un click si se acaba la partida.
                return;
            }

            // Si se juega durante la primera oportunidad...

            if (primeraOportunidad == null)
            {
                // Esto debe de hacerlo con la primera imagen.
                imagenA = sender as PictureBox;

                // Se reconocer� desde la secci�n del archivo "pics" las fotos de las figuras.

                if (imagenA.Tag != null && imagenA.Image == null) // Si es una imagen pero no una etiqueta.
                {
                    imagenA.Image = Image.FromFile("pics/" + (string)imagenA.Tag + ".png"); // La imagen extra�da de un archivo tiene que estar en formato .png.
                    primeraOportunidad = (string)imagenA.Tag; // Esto se asocia con la primera oportunidad al jugar.
                }
            }

            // En caso contrario si hacemos otro intento...

            else 
            
            if (ultimaOportunidad == null)
            {
                // Esto debe de hacerlo con la segunda imagen.
                 imagenB = sender as PictureBox;

                // Se reconocer� desde la secci�n del archivo "pics" las fotos de las figuras.

                 if (imagenB.Tag != null && imagenB.Image == null) // Si es una imagen pero no una etiqueta.
                 {

                    imagenB.Image = Image.FromFile("pics/" + (string)imagenB.Tag + ".png"); // La imagen extra�da de un archivo tiene que estar en formato .png.
                    ultimaOportunidad = (string)imagenB.Tag; // Esto se asocia con la �ltima oportunidad al jugar.
                 }
            }

            // En caso contrario si es que no se cumplen con ninguna de estas dos condiciones...

            else
            {
                CheckPictures(imagenA, imagenB); // Se revisan las dos parejas de im�genes al mismo tiempo.
            }
        }

        // M�todo para reiniciar el juego.
        private void RestartGame()
        {
            // Aleatoriza la lista original.

            var randomList = numbers.OrderBy(x => Guid.NewGuid()).ToList();

            // Asigna la lista aleatoria con respecto a la original.

            numbers = randomList;

            // Crearemos un ciclo for para importar fotos.

            for (int i = 0; i < imagenes.Count; i++)
            {
                imagenes[i].Image = null; // Sin im�genes importadas.
                imagenes[i].Tag = numbers[i].ToString(); // Im�genes se asocian con n�meros al emparejar por cada movimiento.
            }

            intentos = 0; // Inicializa el n�mero de intentos.
            lblStatus.Text = "Emparejaste: " + intentos + " veces."; // Emparejaste n veces.
            lblTimeLeft.Text = "Tiempo restante: " + tiempoTotal; // Tiempo restante: 30 segundos.
            gameOver = false; // Que empiece el juego.
            Temporizador.Start(); // Comienza con un contador de tiempo en segundos.
            cuentaRegresiva = tiempoTotal; // El tiempo comienza en cuenta regresiva.
        }

        // M�todo para revisar im�genes.
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            if (primeraOportunidad == ultimaOportunidad) // Si se juegan al mismo tiempo con las parejas de im�genes...
            {
                A.Tag = null; // Imagen A.
                B.Tag = null; // Imagen B.
            }
            else // En caso contrario...
            {
                intentos++; // La cantidad de intentos se incrementa.
                lblStatus.Text = "Emparejaste " + intentos + " veces."; // Emparejaste n veces.
            }

            primeraOportunidad = null; // Primera oportunidad.
            ultimaOportunidad = null; // Segunda y �ltima oportunidad.

            // Crearemos un ciclo foreach para agregar im�genes en una lista.

            foreach (PictureBox pics in imagenes.ToList())
            {
                if (pics.Tag != null) // Cuando no se etiqueta una imagen pero s� se asocia con esta misma.
                {
                    pics.Image = null;
                }
            }

            // Ahora vamos a comprobar si todos los elementos se han resuelto.

            if (imagenes.All(o => o.Tag == imagenes[0].Tag))
            {
                GameOver("Felicitaciones, has ganado la partida! :)");
            }
        }

        // M�todo para terminar la partida.

        private void GameOver(string msg)
        {
            Temporizador.Stop(); // Paraliza el tiempo.
            gameOver = true; // Se acaba la partida.
            MessageBox.Show(msg + " Presiona el bot�n de Reiniciar para jugar otra partida.", "Esto ser�a infinito... ");
        }
    }
}