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
        public readonly string DEP = "컴퓨터시스템과";
        public Student(string name, int bYear, string DEP)
        {
            this.name = name;
            this.bYear = bYear;
            this.DEP = DEP;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("홍길동", 2006, "컴퓨터시스템과");
            Student s2 = new Student("홍길자", 2005, "실내건축학과");
            Student s3 = new Student("홍길순", 2004, "컴퓨터정보과");

            Console.WriteLine(s1.name + " 학생의 출생년도는 " + s1.bYear);
            Console.WriteLine(s2.name + " 학생의 출생년도는 " + s2.bYear);
            Console.WriteLine(s3.name + " 학생의 출생년도는 " + s3.bYear);
            Console.WriteLine(s1.name + " 학생의 학과는 " + s1.DEP);
            //Student.DEP = "실내건축학과";
            //s1.DEP = "실내건축학과"; // readonly 속성은 생성자에서만 초기화 가능
            Console.WriteLine(s2.name + " 학생의 학과는 " + s2.DEP);

        }
    }
}
