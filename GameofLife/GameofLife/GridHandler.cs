using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace GameofLife
{
    internal class GridHandler
    {
        private Button[,] buttons;
        private int x;
        private int y;
        public GridHandler(int x, int y)
        {
            this.buttons = generateButtons(x, y);
            this.x = x;
            this.y = y;
        }

        private Button[,] generateButtons(int x, int y)
        {
            Button[,] button_list = new Button[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++) {
                  Button b = new Button();
                    b.Height = 50;
                    b.Width = 50;
                   
                    b.Background = new SolidColorBrush(Colors.Black);
                    b.Click += new EventHandler(ChangeColor).Invoke;
                    button_list[i, j] = b;
                }

            }
            return button_list;
        }

        public Button getButton(int x, int y)
        {
            return buttons[x, y];
        }

        public int getX()
        {
            return x;

        }

        public int getY()
        {
            return y;
        }
        private void ChangeColor(object sender, EventArgs e)
        {
            var but = sender as Button;

            if (((SolidColorBrush)but.Background).Color == Colors.Black)
            {
                but.Background = new SolidColorBrush(Colors.White);
            }
            else
            {
                but.Background = new SolidColorBrush(Colors.Black);
            }
        }

        public void moveDown()
        {
            for (int i = x - 1; i > 0; i--)
            {

                for (int j = 0; j < y; j++)
                {
                    Button b = buttons[i, j];
                    if (((SolidColorBrush)b.Background).Color == Colors.White)
                    {
                        buttons[i, j].Background = new SolidColorBrush(Colors.Black);
                        
                        buttons[i + 1, j].Background = new SolidColorBrush(Colors.White);
                    }
                }
            }
        }
            public void moveUp()
            {
                for (int i =0; i <x-1; i++)
                {

                    for (int j = 0; j < y; j++)
                    {
                        Button b = buttons[i, j];
                        if (((SolidColorBrush)b.Background).Color == Colors.White)
                        {
                            buttons[i, j].Background = new SolidColorBrush(Colors.Black);
                            buttons[i -1, j].Background = new SolidColorBrush(Colors.White);
                        }
                    }
                }
            }

        public void moveRight()
        {
            for (int i = 0; i < x; i++)
            {

                for (int j = y-1; j > 0; j--)
                {
                    Button b = buttons[i, j];
                    if (((SolidColorBrush)b.Background).Color == Colors.White)
                    {
                        buttons[i, j].Background = new SolidColorBrush(Colors.Black);
                        buttons[i, j+1].Background = new SolidColorBrush(Colors.White);
                      
                    }
                }
            }
        }
        public void moveLeft()
        {
            for (int i = 0; i < x; i++)
            {

                for (int j = 0; j < y-1; j++)
                {
                    Button b = buttons[i, j];
                    if (((SolidColorBrush)b.Background).Color == Colors.White)
                    {
                        buttons[i, j].Background = new SolidColorBrush(Colors.Black);
                        buttons[i, j - 1].Background = new SolidColorBrush(Colors.White);
                    }
                }
            }
        }

        public void step()
        {
            for(int i = 1; i< x-1; i++)
            {

                for( int j = 1; j < y-1; j++)
                {
                    Button b = buttons[i, j];
                    if (((SolidColorBrush)b.Background).Color == Colors.White)
                    {
                       if(cellChecker(i, j) < 2)
                        {
                            b.Background = new SolidColorBrush(Colors.Black);
                        }
                       else if(cellChecker(i, j) >= 4)
                        {
                            b.Background = new SolidColorBrush(Colors.Black);
                        }
                    }
                    else
                    {
                        if (cellChecker(i, j)==3)
                        {
                            b.Background = new SolidColorBrush(Colors.White);
                        }
                    }
                }
            }
        }

        public int cellChecker(int x, int y)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    Button b = getButton(x + i, y + j);

                    if (((SolidColorBrush)b.Background).Color == Colors.White)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

       
    }
    
}
