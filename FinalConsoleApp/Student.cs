using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Student:Person
    {
        public DateTime EnrollDate { get; set; }

        public string Major { get; set; }

        // when there is a get only, it is a "read-only" variable because we cannot set it.
        public string StudentName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
    }
}
