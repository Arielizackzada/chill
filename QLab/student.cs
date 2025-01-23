using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLab
{
    public class Student
    {
        //מאפייני התלמיד
        public string name;
        private int grade;
        //פונקצייה בונה
        public Student(string name,int grade)
        {
            this.name = name;
            this.grade = grade;
        }

        // פונקציית דריסה
        public override string ToString()
        {
            return name + " (" + grade + ")";

        }
        public int GetGrade()
        {
            return grade;
        }

    }
}
