
using System;
using System.Windows.Input;
using StudentPortal.Services;

namespace StudentPortal.MVVM.ViewModels
{
    public class AddStudentViewModel : BaseViewModel
    {
        private string _name;
        private string _email;
        private DateTime _dateOfBirth;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => SetProperty(ref _dateOfBirth, value);
        }

        public ICommand AddStudentCommand { get; }

        public AddStudentViewModel()
        {
            AddStudentCommand = new RelayCommand(AddStudent);
        }

        private void AddStudent()
        {
            Database.AddStudent(new Models.Student
            {
                Name = Name,
                Email = Email,
                DateOfBirth = DateOfBirth
            });
        }
    }
}
