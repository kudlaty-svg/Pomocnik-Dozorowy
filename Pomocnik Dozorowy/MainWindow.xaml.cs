using Pomocnik_Dozorowy.Dzwignice;
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

namespace Pomocnik_Dozorowy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Otwier okno z informacjami o dźwignicach
        private void Btn_Dzwignice_Click(object sender, RoutedEventArgs e)
        {
            OknoDzwignice oknoDzwignice = new OknoDzwignice();
            oknoDzwignice.Show();
            this.Close();
        }
        //Otwier okno z informacjami o wózkach jezdniowych
        private void Btn_WozkiJezdniowe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("W fazie rozwoju. Proszę o cierpliwość.", "Wózki Jezdniowe", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        //Otwier okno z informacjami o programie
        private void Btn_Pomoc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("W fazie rozwoju. Proszę o cierpliwość.", "Pomoc", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        //Zamyka aplikację
        private void Btn_Wyjscie_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}