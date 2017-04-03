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
using System.Data.SqlClient;
using CourseVoiliers.Classes;
using System.Data;

namespace CourseVoiliers
{
    /// <summary>
    /// Logique d'interaction pour ListeCourse.xaml
    /// </summary>
    public partial class ListeCourse : Window
    {
        public ListeCourse()
        {
            InitializeComponent();

           
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=PC-JEREMIE;Initial Catalog=Projet_VOILIERS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Courses";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();


            
            List<Course> listCourses = new List<Course>();
            Console.WriteLine(Courses());
            this.DataContext = listCourses;
        }

        public List<Course> Courses()
        {
            List<Course> courses = new List<Course>();
            using (var db = new DbCourseVoiliersContext())
            {
                foreach (Course c in db.Courses)
                {
                    courses.Add(c);
                }
            }
            return courses;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nom = new NouvelleCourse();
            nom.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var nom = new Accueil();
            nom.Show();
            this.Close();
        }
    }
}
