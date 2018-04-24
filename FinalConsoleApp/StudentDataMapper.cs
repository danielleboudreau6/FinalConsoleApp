using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FinalConsoleApp
{
    public class StudentDataMapper : IDataMapper<Student>
    {
        private string path;
        public StudentDataMapper()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Students.txt";
        }

        private List<Student>GetStudents()
        {
            List<Student> students = new List<Student>();

            // Read from Student.txt
            if (File.Exists(path))
            {
                var sr = new StreamReader(path);
                string line;

                // for as long as there are lines to read, we are going to loop
                while((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(','); // create array from Comma Seperated Values file
                    var student = new Student
                    {
                        ID = Int16.Parse(elems[0]),
                        FirstName = elems[1],
                        LastName = elems[2],
                        Address = elems[3],
                        City = elems[4],
                        Province = elems[5],
                        PostalCode = elems[6],
                        Phone = elems[7],
                        Email = elems[8],
                        EnrollDate = DateTime.Parse(elems[9]),
                        Major = elems[10]
                    };
                    // Add each new student (one for each line in Students.txt) to the list
                    students.Add(student);
                }
            }
            return students;
        }

        public List<Student> Find(string LastName)
        {
            // first get all the students
            var searchStudents = GetStudents();

            // find students containing the searched LastName using LINQ - Language Integrity Query
            // Note: we will need to convert IEnumerable back to a List. 

            return searchStudents.Where(s => s.LastName.Contains(LastName)).ToList();
        }

        public List<Student> Select()
        {
            return GetStudents();
        }
    }
}
