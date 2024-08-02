
using System;
using System.Windows.Input;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class AddAttendanceViewModel : BaseViewModel
    {
        private int _studentId;
        private DateTime _date = DateTime.Today;
        private bool _present;

        public int StudentId
        {
            get => _studentId;
            set => SetProperty(ref _studentId, value);
        }

        public DateTime Date
        {
            get => _date;
            set => SetProperty(ref _date, value);
        }

        public bool Present
        {
            get => _present;
            set => SetProperty(ref _present, value);
        }

        public ICommand AddAttendanceCommand { get; }

        public AddAttendanceViewModel()
        {
            AddAttendanceCommand = new RelayCommand(AddAttendance);
        }

        private void AddAttendance()
        {
            Database.AddAttendance(new Models.Attendance
            {
                StudentId = StudentId,
                Date = Date,
                Present = Present
            });
        }
    }
}
