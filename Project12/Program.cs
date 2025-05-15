using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{

    public class Student
    {
        public string name;
        public int bYear;
        public string major;
        public Student(string name, int bYear, string major)
        {
            this.name = name;
            this.bYear = bYear;
            this.major = major;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("홍길동", 2006, "컴퓨터시스템과");
            Student s2 = new Student("홍길자", 2005, "컴퓨터시스템과");
            Student s3 = new Student("홍길순", 2004, "컴퓨터시스템과");

            Console.WriteLine(s1.name + " 학생의 출생년도는 " + s1.bYear);
            Console.WriteLine(s2.name + " 학생의 출생년도는 " + s2.bYear);
            Console.WriteLine(s3.name + " 학생의 출생년도는 " + s3.bYear);
        }
    }
}
