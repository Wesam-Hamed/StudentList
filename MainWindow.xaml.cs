using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace StudentList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        int count;
        public ObservableCollection<Student> Students { get; set; }
        public int Counter
        {
            get { return count; }


            set
            {
                count = value;
                OnPropertyChanged("Counter");
            }

        }
        public MainWindow()
        {
            this.DataContext = this;
            Students = new ObservableCollection<Student>()
            {
                new Student(){Id=10,Name="Mohamed",Grade="4",Image="./img4.jpg",Gender="Male"},
                new Student(){Id=20,Name="Wessam",Grade="2",Image="./img6.jpg",Gender="Female"},
                new Student(){Id=30,Name="Hoor",Grade="3",Image="./img6.jpg" ,Gender="Female"},
                new Student(){Id=40,Name="Ali",Grade="7",Image="./img4.jpg" ,Gender="Male"},

            };



            InitializeComponent();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = null)
        {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));


            //private void Button_Click(object sender, RoutedEventArgs e)
            //{
            //    Counter++;//Counter=Counter+1;

            //    //  count += 1;

            //}


        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {

            Student stu = new Student() { Id = 70, Name = "Ahmed", Image = "./img4.jpg", Gender = "Male" };

            Students.Add(stu);


        }

        private void RemoveStudent(object sender, RoutedEventArgs e)
        {
            if (lst.SelectedItem != null)
                Students.Remove((Student)lst.SelectedItem);
            else
                MessageBox.Show("Please Select Item");
        }
    }
}
