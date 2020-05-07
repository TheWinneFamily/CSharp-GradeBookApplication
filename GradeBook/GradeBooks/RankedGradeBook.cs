using GradeBook.Enums;
using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            double twentyPercentOfCount = Students.Count / 5;
            int studentsWithHigherGrades = Students.Count(s => s.AverageGrade > averageGrade);
            if (studentsWithHigherGrades < twentyPercentOfCount)
            {
                return 'A';
            }
            else if (studentsWithHigherGrades < twentyPercentOfCount * 2)
            {
                return 'B';
            }
            else if (studentsWithHigherGrades < twentyPercentOfCount * 3)
            {
                return 'C';
            }
            else if (studentsWithHigherGrades < twentyPercentOfCount * 4)
            {
                return 'D';
            }
            return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }    

            base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}
