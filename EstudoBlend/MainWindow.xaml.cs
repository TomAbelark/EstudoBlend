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
using System.Windows.Media.Animation;

namespace EstudoBlend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard MinhaAnimacao = new Storyboard();

        public MainWindow()
        {
            InitializeComponent();
            MinhaAnimacao = this.FindResource("Animacao1") as Storyboard;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MinhaAnimacao.Begin();
        }

        private void regularPolygon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           MinhaAnimacao.Pause();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }
    }
}
