﻿using System;
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
    /// Logique d'interaction pour NouvelleCourse.xaml
    /// </summary>
    public partial class NouvelleCourse : Window
    {
        public NouvelleCourse()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nom = new NouvelleEpreuve();
            nom.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nom = new ListeCourse();
            nom.Show();
            this.Close();
        }
    }
}