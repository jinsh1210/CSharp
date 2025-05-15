using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{

    public class Student
    {
        public string name;
        public int bYear;
        public const string DEP ="컴퓨터시스템과";
        public Student(string name, int bYear)
        {
            this.name = name;
            this.bYear = bYear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("홍길동", 2006);
            Student s2 = new Student("홍길자", 2005);
            Student s3 = new Student("홍길순", 2004);

            Console.WriteLine(s1.name + " 학생의 출생년도는 " + s1.bYear);
            Console.WriteLine(s2.name + " 학생의 출생년도는 " + s2.bYear);
            Console.WriteLine(s3.name + " 학생의 출생년도는 " + s3.bYear);

            Console.WriteLine(s1.name + " 학생의 학과는 " + Student.DEP);
            Console.WriteLine(s2.name + " 학생의 학과는 " + Student.DEP);

        }
    }
}
