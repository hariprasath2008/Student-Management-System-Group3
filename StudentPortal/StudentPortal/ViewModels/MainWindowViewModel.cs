using System.Windows.Input;
using StudentPortal.Views;
using StudentPortal.MVVM.ViewModels;

using StudentPortal;

namespace StudentPortal.MVVM.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ICommand NavigateToAddStudentCommand { get; }
        public ICommand NavigateToViewStudentsCommand { get; }
        public ICommand NavigateToAddAttendanceCommand { get; }
        public ICommand NavigateToViewAttendanceCommand { get; }

        public MainWindowViewModel()
        {
            NavigateToAddStudentCommand = new RelayCommand(NavigateToAddStudent);
            NavigateToViewStudentsCommand = new RelayCommand(NavigateToViewStudents);
            NavigateToAddAttendanceCommand = new RelayCommand(NavigateToAddAttendance);
            NavigateToViewAttendanceCommand = new RelayCommand(NavigateToViewAttendance);
        }

        private void NavigateToAddStudent()
        {
            var addStudentView = new AddStudentView
            {
                DataContext = new AddStudentViewModel()
            };
            addStudentView.ShowDialog();
        }

        private void NavigateToViewStudents()
        {
            var viewStudentsView = new ViewStudentsView
            {
                DataContext = new ViewStudentsViewModel()
            };
            viewStudentsView.ShowDialog();
        }

        private void NavigateToAddAttendance()
        {
            var addAttendanceView = new AddAttendanceView
            {
                DataContext = new AddAttendanceViewModel()
            };
            addAttendanceView.ShowDialog();
        }

        private void NavigateToViewAttendance()
        {
            var viewAttendanceView = new ViewAttendanceView
            {
                DataContext = new ViewAttendanceViewModel()
            };
            viewAttendanceView.ShowDialog();
        }
    }
}
