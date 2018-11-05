using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace WeeklyProject3_v2
{

    class Program
    {

        static void Main(string[] args)
        {


            //TODO : Check which is better, readalltext? line? convert to list?
            string studentData = File.ReadAllText(@"C:\Users\giorg\Documents\Coding\AFDEmp\C#\Bi-Weakly Project 3\Lab3.txt");
            string[] lineData = studentData.Split();

            List<Student> students = new List<Student>();

            Console.WriteLine(lineData[1]);

            /*foreach (string element in lineData)
            {
                Student newStudent = new Student();
                newStudent.FirstName
            }*/


            Console.ReadKey();
        }
    }

}
