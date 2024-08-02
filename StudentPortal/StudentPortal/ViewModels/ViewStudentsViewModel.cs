
using System.Collections.ObjectModel;
using StudentPortal.Models;
using System.Windows.Input;
using StudentPortal.Services;
using StudentPortal.Views;

namespace StudentPortal.MVVM.ViewModels
{
    public class ViewStudentsViewModel : BaseViewModel
    {
        private Student _selectedStudent;

        public ObservableCollection<Student> Students { get; }
        public Student SelectedStudent
        {
            get => _selectedStudent;
            set => SetProperty(ref _selectedStudent, value);
        }

        public ICommand EditStudentCommand { get; }
        public ICommand DeleteStudentCommand { get; }

        public ViewStudentsViewModel()
        {
            Students = new ObservableCollection<Student>(Database.GetAllStudents());
            EditStudentCommand = new RelayCommand<Student>(EditStudent);
            DeleteStudentCommand = new RelayCommand<Student>(DeleteStudent);
        }

        private void EditStudent(Student student)
        {
            var editStudentView = new EditStudentView
            {
                DataContext = new EditStudentViewModel(student)
            };
            editStudentView.ShowDialog();
            Students.Clear();
            foreach (var std in Database.GetAllStudents())
            {
                Students.Add(std);
            }
        }

        private void DeleteStudent(Student student)
        {
            Database.DeleteStudent(student);
            Students.Remove(student);
        }
    }
}
