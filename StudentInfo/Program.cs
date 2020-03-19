using System;

namespace StudentsRanking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Students Count: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            var students = new InputClass[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("First Name: ");
                string studentFirstName = Console.ReadLine();

                Console.Write("Second Name: ");
                string studentSecondName = Console.ReadLine();

                Console.Write("Third Name: ");
                string studentThirdName = Console.ReadLine();

                Console.Write("Course: ");
                int studentCourse = int.Parse(Console.ReadLine());

                Console.Write("Grade: ");
                double studentGrade = int.Parse(Console.ReadLine());

                Console.Write("University: ");
                string university = Console.ReadLine();

                Console.WriteLine();

                var studentInfo = new InputClass(studentFirstName, studentSecondName, studentThirdName, studentGrade, studentCourse, university);

                students[i] = studentInfo;
            }
            Console.WriteLine("Type 'check' to see your info or 'close' to end the program!");
            string command = Console.ReadLine();
            if (command == "check")
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"" +
                        $"Name: {student.studentFirstName} {student.studentSecondName} {student.studentThirdName}{Environment.NewLine}" +
                        $"Course: {student.studentCourse}{Environment.NewLine}" +
                        $"Grade: {student.studentGrade}{Environment.NewLine}" +
                        $"From: {student.university}");
                }
            }
            else if (command == "close")
            {
               
            }

        }
    }
}
