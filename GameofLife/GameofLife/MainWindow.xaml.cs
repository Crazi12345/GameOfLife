using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace GameofLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GridHandler gridHandler = new GridHandler(10, 10);
        public bool isOpening = true;
        public bool isLoading = true;
        public StackPanel[] stackPanels = new StackPanel[50];
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < stackPanels.Length; i++)
            {
                stackPanels[i] = new StackPanel();
            }

          
           isLoading = false;


        }

        public void printGrid(int xOffset, int yOffset, int scale)
        {
          
            int x = gridHandler.getX() ;
            int y = gridHandler.getY() ;
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
                  //  stackPanels[x % stackPanels.Length].Children.Remove(b);
                    
                       

                        stackPanels[x % stackPanels.Length].Children.Add(b);
                       
                      
                    
                  


                }
               
            }
        }

        public void RemoveGrid()
        {

            int x = gridHandler.getX();
            int y = gridHandler.getY();
            GridPanel.Children.Clear();
            gridHandler = new GridHandler(300,300);

          

            }

        public void ClearScreen()
        {
            int x = gridHandler.getX();
            int y = gridHandler.getY();
            for (int i = 1; i < x - 1; i++)
            {

                for (int j = 1; j < y - 1; j++)
                {
                    Button b = gridHandler.getButton(i, j);
                    if (((SolidColorBrush)b.Background).Color == Colors.White)
                    {
                        b.Background = new SolidColorBrush(Colors.Black);
                    }
                }
            }
        }
        




        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (isLoading == false)
            { var aliveCells = new List<int>();
                int val = (int)ScaleSlider.Value;
                SliderVal.Content = val.ToString();
                int x = gridHandler.getX();
                int y = gridHandler.getY();
                for (int i = 1; i < x - 1; i++)
                {

                    for (int j = 1; j < y - 1; j++)
                    {
                        Button b = gridHandler.getButton(i, j);
                        if (((SolidColorBrush)b.Background).Color == Colors.White)
                        {
                            aliveCells.Add(i);
                            aliveCells.Add(j);
                        }
                    }
                }
                RemoveGrid();
                printGrid(0, 0, val);
                gridHandler.ReColor(aliveCells);
                aliveCells.Clear();
            }
        }

        private void StartBut_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i< 10; i++)
            {
                gridHandler.step();
            }
           
            
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

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClearScreen();
        }
    }

      





    }


