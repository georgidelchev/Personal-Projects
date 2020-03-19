using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsRanking
{
    class InputClass
    {
        public string studentFirstName, studentSecondName, studentThirdName,university;
        public double studentGrade;
        public int studentCourse;       
        
        public InputClass (string studentFirstName,string studentSecondName,string studentThirdName,double studentGrade , int studentCourse,string university)
        {
            this.studentFirstName = studentFirstName;
            this.studentSecondName = studentSecondName;
            this.studentThirdName = studentThirdName;
            this.studentGrade = studentGrade;
            this.studentCourse = studentCourse;
            this.university = university;
        }
    }
}
