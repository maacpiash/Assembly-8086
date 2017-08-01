using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System.Model
{
    public class Student
    {
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private string _name;

        public string StdID
        {
            get => _stdid;
            set => _stdid = value;
        }
        private string _stdid;

        public string TagID
        {
            get => _tagid;
            set => _tagid = value;
        }
        private string _tagid;

        public Student(string n, string i, string t)
        {
            _name = n;
            _stdid = i;
            _tagid = t;
        }


        public static bool Okay(string tagID, List<Student> allStudents, out Student newcomer)
        {
            newcomer = null;
            foreach (Student s in allStudents)
            {
                if (tagID.Contains(s.TagID))
                {
                    newcomer = s;
                    return true;
                }
            }
            return false;
        }
    }
}
