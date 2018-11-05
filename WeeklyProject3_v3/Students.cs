using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject3_v2
{
    public class Student
    {
        //TODO : add conduct behavior? list? enum?
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private byte Age { get; set; }
        private float Height { get; set; }
        private decimal Tuition { get; set; }
        private string Date { get; set; }
        private int Phone { get; set; }



        Student(string name, string lastName, byte age, float height, decimal tuition, string date, int phone)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
            Height = height;
            Tuition = tuition;
            Date = date;
            Phone = phone;
        }
    }


}
