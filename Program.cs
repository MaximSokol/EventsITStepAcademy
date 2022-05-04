using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsITStepAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.PropertyChanged += Student_PropertyChanged;
            student.Name = "Alex";

        }

        private static void Student_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine($"The name was changed!\n");
        }
    }
}
