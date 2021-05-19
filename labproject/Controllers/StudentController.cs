using labproject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace labproject.Controllers
{
    public class StudentController : ApiController
    {
        [HttpPost]
        public bool AddStudent(Student obj)
        {
            try
            {
                StreamWriter writer = new StreamWriter("G:/Test.txt", true);
                writer.WriteLine(obj.Name + "," + obj.RegistrationNumber + "," + obj.DateOfBirth);
                writer.Flush();
                writer.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        [HttpGet]
        public List<Student> AllStudents()
        {
            List<Student> data = new List<Student>();

            StreamReader reader = new StreamReader("G:/Test.txt");

            String line = reader.ReadLine();

            while (line != null)
            {
                String[] arr = line.Split(',');
                Student s = new Student();
                s.Name = arr[0];
                s.RegistrationNumber = arr[1];
                s.DateOfBirth = DateTime.Parse(arr[2]);
                data.Add(s);

                line = reader.ReadLine();
            }
            return data;
        }
    }
}
