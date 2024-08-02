
using System.Collections.ObjectModel;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class ViewStudentsViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Student> _students;

        public ObservableCollection<Models.Student> Students
        {
            get => _students;
            set => SetProperty(ref _students, value);
        }

        public ViewStudentsViewModel()
        {
            Students = new ObservableCollection<Models.Student>(Database.GetAllStudents());
        }
    }
}
