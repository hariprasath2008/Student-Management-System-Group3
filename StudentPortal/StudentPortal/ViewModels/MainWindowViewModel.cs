using System.Windows.Input;

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
            var addStudentView = new Views.AddStudentView     
            {
                DataContext = new AddStudentViewModel()
            };
            addStudentView.ShowDialog();
        }

        private void NavigateToViewStudents()
        {
            var viewStudentsView = new Views.ViewStudentsView
            {
                DataContext = new ViewStudentsViewModel()
            };
            viewStudentsView.ShowDialog();
        }

        private void NavigateToAddAttendance()
        {
            var addAttendanceView = new Views.AddAttendanceView
            {
                DataContext = new AddAttendanceViewModel()
            };
            addAttendanceView.ShowDialog();
        }

        private void NavigateToViewAttendance()
        {
            var viewAttendanceView = new Views.ViewAttendanceView
            {
                DataContext = new ViewAttendanceViewModel()
            };
            viewAttendanceView.ShowDialog();
        }
    }
}
