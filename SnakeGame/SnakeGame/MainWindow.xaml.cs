using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnakeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly int rows = 15, cols = 15;
        private readonly Image[,] gridImages;
        private GameState gameState;
        private readonly Dictionary<GridValues, ImageSource> gridValToImage = new()
        {
            {GridValues.Empty ,Images.Empty },
            {GridValues.Snake , Images.Body },
            {GridValues.Food , Images.Food }
        };

        public MainWindow()
        {
            InitializeComponent();
            gridImages = SetupGrid();
            gameState = new GameState(rows, cols);
        }

        private async void Window_Loade(object sender, RoutedEventArgs e)
        {
            Draw();
            await GameLoop();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameState.GameOver) return;

            switch (e.Key)
            {
                case Key.Left:
                    gameState.ChangeDirection(Directions.Left); break;

                case Key.Right:
                    gameState.ChangeDirection(Directions.Right);break;

                case Key.Up:
                    gameState.ChangeDirection(Directions.Up); break;

                case Key.Down:
                    gameState.ChangeDirection(Directions.Down); break;
            }
        }

        private async Task GameLoop()
        {
            while (!gameState.GameOver)
            {
                await Task.Delay(100);
                gameState.Move();
                Draw();
            }
        }
        private Image[,] SetupGrid()
        {
            Image[,] images = new Image[rows, cols];
            GameGrid.Rows = rows;
            GameGrid.Columns = cols;

            for(int r = 0; r <rows; r++) { 
                for(int c = 0 ; c <cols; c++)
                {
                    Image image = new Image
                    {
                        Source = Images.Empty
                    };
                    images[r, c] = image;
                    GameGrid.Children.Add(image);
                }
            }

            return images;
        }

        private void Draw()
        {
            DrawGrid();
        }

        private void DrawGrid()
        {
            for(int r = 0; r < rows; r++)
            {
                for(int c = 0; c < cols; c++)
                {
                    GridValues gridValue = gameState.Grid[r,c];
                    gridImages[r, c].Source = gridValToImage[gridValue];
                }
            }
        }


    }
}