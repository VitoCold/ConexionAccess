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
using WPF.DataAccess;
using WPF.Entities;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public EstudianteDA _alumnoDA;
        public List<Estudiante> Alumnos { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            _alumnoDA = new EstudianteDA();
            Alumnos = new List<Estudiante>();

            Alumnos= _alumnoDA.GetAlumnos();

            dgAlumnos.ItemsSource = Alumnos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var alumno = new Estudiante { Nombre = txtNombre.Text, Apellido = txtApellido.Text };

            if (_alumnoDA.AddAlumno(alumno) > 0)
            {
                txtApellido.Text = "";
                txtNombre.Text = "";
            }

        }
    }
}
