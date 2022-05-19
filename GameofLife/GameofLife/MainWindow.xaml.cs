using System.Windows;
using System.Windows.Controls;

namespace GameofLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GridHandler gridHandler = new GridHandler(300, 300);
        public bool isOpening = true;
        public StackPanel[] stackPanels = new StackPanel[50];
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < stackPanels.Length; i++)
            {
                stackPanels[i] = new StackPanel();
            }

            printGrid(0, 0,20);


        }

        public void printGrid(int xOffset, int yOffset, int scale)
        {
          
            int x = gridHandler.getX() ;
            int y = gridHandler.getY() ;
            GridPanel.Children.Clear();
            for (int i = x / 2; i < x; i++)
            {
                
                stackPanels[x%stackPanels.Length] = new StackPanel();
                stackPanels[x % stackPanels.Length].Orientation = Orientation.Horizontal;
               
                GridPanel.Children.Add(stackPanels[x % stackPanels.Length]);
             
            
                for (int j = y / 2; j < y; j++)
                {
                    Button b = gridHandler.getButton(i, j);
                    b.Height = scale;
                    b.Width = scale;
                    stackPanels[x % stackPanels.Length].Children.Remove(b);
                    if (isOpening == true)
                    {
                        stackPanels[x % stackPanels.Length].Children.Remove((Button)b);

                        stackPanels[x % stackPanels.Length].Children.Add(b);
                       
                      
                    }
                  


                }
               
            }
        }

       
      
        
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
           // printGrid(0, 0,(int)ScaleSlider.Value);
        }

        private void StartBut_Click(object sender, RoutedEventArgs e)
        {

            
        }
        public void reload()
        {
          
            for (int i = 0; i < stackPanels.Length; i++)
            {
                if (stackPanels[i].Children.Count > 0)
                {
                    stackPanels[i].Children.RemoveAt(stackPanels[i].Children.Count - 1);
                }
                stackPanels[i].Children.Clear();
                stackPanels[i] = new StackPanel();
            }
            GridPanel.Children.Clear();

        }
        private void stepBut_Click(object sender, RoutedEventArgs e)
        {
            gridHandler.step();
        }

        private void DownBut_Click(object sender, RoutedEventArgs e)
        {
            gridHandler.moveDown();

        }

    

        private void UpBut_Click_1(object sender, RoutedEventArgs e)
        {
            gridHandler.moveUp();
        }

        private void LeftBut_Click(object sender, RoutedEventArgs e)
        {
            gridHandler.moveLeft();
        }

        private void RIghtBut_Click(object sender, RoutedEventArgs e)
        {
            gridHandler.moveRight();
        }
    }

      





    }


