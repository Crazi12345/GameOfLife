using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameofLife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {       
            InitializeComponent();
            Image im = new Image();
            
            
            for (int i = 0; i < 10000; i++)
            {
                for(int j = 0; j < 10000; j++)
                {
                    if(i == j)
                    {
                       
                     
                    }
                   
                }
            }
           
        }
    }
}
