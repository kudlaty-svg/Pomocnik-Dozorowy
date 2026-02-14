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

namespace Pomocnik_Dozorowy.OknaPomocnicze
{
    /// <summary>
    /// Logika interakcji dla klasy OknoPomoc.xaml
    /// </summary>
    public partial class OknoPomoc : Window
    {
        public OknoPomoc()
        {
            InitializeComponent();
            MessageBox.Show("To okno jest w fazie rozwoju. Proszę o cierpliwość.", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Btn_Zamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
