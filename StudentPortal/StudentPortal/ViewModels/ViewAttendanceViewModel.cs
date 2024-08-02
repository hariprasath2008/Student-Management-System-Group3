using System.Collections.ObjectModel;
using System.Windows.Input;
using StudentPortal.Models;
using StudentPortal.Services;
using StudentPortal.Views;

namespace StudentPortal.MVVM.ViewModels
{
    public class ViewAttendanceViewModel : BaseViewModel
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
                EditStudentCommand = new RelayCommand(EditStudent, () => SelectedStudent != null);
                DeleteStudentCommand = new RelayCommand(DeleteStudent, () => SelectedStudent != null);
            }

            private void EditStudent()
            {
                var editStudentView = new EditStudentView
                {
                    DataContext = new EditStudentViewModel(SelectedStudent)
                };
                editStudentView.ShowDialog();
                Students.Clear();
                foreach (var student in Database.GetAllStudents())
                {
                    Students.Add(student);
                }
            }

            private void DeleteStudent()
            {
                Database.DeleteStudent(SelectedStudent);
                Students.Remove(SelectedStudent);
            }
        }
    }
}

