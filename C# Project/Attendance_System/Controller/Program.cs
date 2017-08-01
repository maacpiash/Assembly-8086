using Attendance_System.Model;
using Attendance_System.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System
{
    class Program
    {
        public static List<Student> students;
        public static List<Attendance> attendances;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            students = new List<Student>();
            attendances = new List<Attendance>();

            ReadStudentsData();

            Application.Run(new Form2());

            WriteAttendanceRecords();
        }

        static void ReadStudentsData()
        {
            string addr = Path.Combine(Directory.GetCurrentDirectory(), "Students.csv");

            try
            {
                List<string> Names = new List<string>();
                List<string> IDs = new List<string>();
                List<string> Tags = new List<string>();

                using (var reader = new StreamReader(File.OpenRead(addr)))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        Names.Add(values[0]);
                        IDs.Add(values[1]);
                        Tags.Add(values[2]);
                    }

                    for (int i = 1; i < Names.Count; i++)
                        students.Add(new Student(Names[i], IDs[i], Tags[i]));

                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetType().ToString());
            }
        }

        static void WriteAttendanceRecords()
        {
            string addr = Path.Combine(Directory.GetCurrentDirectory(), "Attendances.csv");
            var csv = new StringBuilder();

            foreach(Attendance a in attendances)
                csv.AppendLine(a.Std.Name + "," + a.Std.StdID + "," + a.Stamp);
            
            File.WriteAllText(addr, csv.ToString());
        }
    }
}
