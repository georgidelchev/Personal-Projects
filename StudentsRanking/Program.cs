using System;

namespace SimpleStudentsRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Students students = new Students();
            Console.Write("Enter number of students: ");
            int n = students.numbersOfStudents();

            string[] studentsName = new string[n];
            double[] studentsGrade = new double[n];

            for (int i = 1; i <= students.numberOfStudents; i++)
            {
                Console.Write("Enter name of the student and his grade: " + Environment.NewLine);

                Console.Write("Name: ");
                string name = students.namesOfStudents();
                studentsName[counter] = name;

                Console.Write("Grade: ");
                double grade = students.studentsGrades();
                studentsGrade[counter] = grade;

                counter++;
            }
            Console.WriteLine($"Enter command 'check' to check all of students and their grades. {Environment.NewLine}Or 'continue' to close the program!{Environment.NewLine}");
            Console.Write(">>");
            string command = Console.ReadLine();
            if (command == "check")
            {
                int c = 0;
                foreach (var name in studentsName)
                {
                    Console.WriteLine("Name: " + name + " " + Environment.NewLine + "Grade: " + studentsGrade[c] + Environment.NewLine);
                    c++;
                }
            }
            else if (command == "continue")
            {
            }
        }
    }
    public class Students
    {
        public int numberOfStudents;
        public double grades;
        public string nameOfStudents;

        public int numbersOfStudents()
        {
            numberOfStudents = int.Parse(Console.ReadLine());
            return numberOfStudents;
        }

        public string namesOfStudents()
        {
            nameOfStudents = Console.ReadLine();
            return nameOfStudents;
        }

        public double studentsGrades()
        {
            grades = double.Parse(Console.ReadLine());
            return grades;
        }
    }
}
