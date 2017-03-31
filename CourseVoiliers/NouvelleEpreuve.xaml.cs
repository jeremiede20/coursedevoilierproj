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

namespace CourseVoiliers
{
    /// <summary>
    /// Logique d'interaction pour NouvelleEpreuve.xaml
    /// </summary>
    public partial class NouvelleEpreuve : Window
    {
        public NouvelleEpreuve()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // à revoir pour faire la redirection vers la course
            var nom = new NouvelleCourse();
            nom.Show();
            this.Close();
        }
    }
}
