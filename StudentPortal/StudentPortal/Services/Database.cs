using StudentPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentPortal.Services
{
    public static class Database
    {
        private static List<Student> Students { get; } = new List<Student>();
        private static List<Attendance> AttendanceRecords { get; } = new List<Attendance>();

        public static void AddStudent(Student student)
        {
            student.Id = Students.Count + 1;
            Students.Add(student);
        }

        public static List<Student> GetAllStudents()
        {
            return Students;
        }

        public static void AddAttendance(Attendance attendance)
        {
            attendance.Id = AttendanceRecords.Count + 1;
            AttendanceRecords.Add(attendance);
        }

        public static List<Attendance> GetAllAttendance()
        {
            return AttendanceRecords;
        }
    }
}
