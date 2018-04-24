using System;
using System.Collections.Generic;
using System.Text;

namespace FinalConsoleApp
{
    public class Instructor:Person
    {
        public DateTime HireDate { get; set; }

        private string _rank; // private field. only lives inside this class . incapsulation

        public string Rank
        {
            get
            {
                int years = YearsOfWork(this.HireDate);
                if(years >= 25)
                {
                    _rank = Ranking.DistinguishedProfessor.ToString();
                }
                else if (years >= 20)
                {
                    _rank = Ranking.FullProfessor.ToString();
                }
                else if (years >= 15)
                {
                    _rank = Ranking.AssociateProfessor.ToString();
                }
                else if (years >= 10)
                {
                    _rank = Ranking.AssistantProfessor.ToString();
                }
                else
                {
                    _rank = Ranking.Instructor.ToString();
                }
                return _rank;
            }
            set
            {
                _rank = value; // built in variable
            }
        }

        // ranking enum
        private enum Ranking : byte
        {
            Instructor = 1,
            AssistantProfessor = 2,
            AssociateProfessor = 3,
            FullProfessor = 4,
            DistinguishedProfessor = 5
        }

        private static int YearsOfWork(DateTime HireDate)
        {
            DateTime today = DateTime.Today;
            int yearsExp = today.Year - HireDate.Year;
            if (HireDate.AddYears(yearsExp) > today)
                yearsExp--;

            return yearsExp;
        }
    }
}
