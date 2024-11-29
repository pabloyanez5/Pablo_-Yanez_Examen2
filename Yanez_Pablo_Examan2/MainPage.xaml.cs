using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace Yanez_Pablo_Examen2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Student> Students { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Students = new ObservableCollection<Student>
            {
                new Student { Id = 1, Nombre = "Juan Perez", Carrera = "Ingeniería de Software" },
                new Student { Id = 2, Nombre = "María Lopez", Carrera = "Diseño Gráfico" }
            };
            BindingContext = this;
        }

        private void OnAddStudentClicked(object sender, EventArgs e)
        {
            Students.Add(new Student { Id = Students.Count + 1, Nombre = "Nuevo Estudiante", Carrera = "Carrera X" });
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
    }
}