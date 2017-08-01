using Attendance_System.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Attendance_System.View
{
    public partial class Form2 : Form
    {
        string tagID;

        public Form2()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            tagID = serialPort1.ReadLine();
            string addr = Path.Combine(Directory.GetCurrentDirectory(), "Test.txt");
            File.WriteAllText(addr, tagID);

            Student s;
            if (Student.Okay(tagID, Program.students, out s))
            {
                Attendance at = new Attendance(s);
                Program.attendances.Add(at);
                MessageBox.Show("Name: " + s.Name + '\n' + "ID: " + s.StdID + '\n'
                    + "Time of entrance: " +  at.Stamp.ToString(), "Attendance recorded successfully!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Student record not found.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
