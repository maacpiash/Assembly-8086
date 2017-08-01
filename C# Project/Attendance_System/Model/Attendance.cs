using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.Model
{
    public class Attendance
    {
        public Student Std
        {
            get => _std;
            set => _std = value;
        }
        private Student _std;

        public DateTime Stamp
        {
            get => _stamp;
            set => _stamp = value;
        }
        private DateTime _stamp;

        public Attendance(Student s)
        {
            _std = s;
            _stamp = DateTime.Now;
        }

        public Attendance(Student s, DateTime dt)
        {
            _std = s;
            _stamp = dt;
        }
    }
}
