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

namespace CourseVoiliers
{
    /// <summary>
    /// Logique d'interaction pour GestionEquipage.xaml
    /// </summary>
    public partial class GestionEquipage : Window
    {
        public GestionEquipage()
        {
            InitializeComponent();
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nom = new Inscription();
            nom.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
