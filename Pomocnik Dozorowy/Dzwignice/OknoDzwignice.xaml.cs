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
using System.Windows.Shapes;

namespace Pomocnik_Dozorowy.Dzwignice
{
    /// <summary>
    /// Logika interakcji dla klasy OknoDzwignice.xaml
    /// </summary>
    public partial class OknoDzwignice : Window
    {
        public OknoDzwignice()
        {
            InitializeComponent();
        }
        // Pozwala na przeciąganie okna po kliknięciu i przytrzymaniu lewego przycisku myszy na obszarze Border
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        // Minimalizuje okno po kliknięciu przycisku minimalizacji
        private void Can_Minimalize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        // Zamyka okno po kliknięciu przycisku zamykania
        private void Cross_Exit_App(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
