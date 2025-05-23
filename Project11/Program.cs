using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11
{
    /*class Test
    {
        public int Power(int x)
        {
            return x * x;
        }
        public static int Abs(int x)
        {
            Console.WriteLine("정수 절대값 구하기");
            if (x < 0)
                return -x;
            else
                return x;
        }
        public static double Abs(double x)
        {
            Console.WriteLine("실수 절대값 구하기");
            if (x < 0)
                return -x;
            else
                return x;
        }
        public static long Abs(long x)
        {
            Console.WriteLine("Long형 정수 절대값 구하기");
            if (x < 0)
                return -x;
            else
                return x;
        }

        public string name;
        public int price;
        public int id;
        public static int count = 0;    //클래스변수

        public Test() { }
        public Test(string name, int price)
        {
            Test.count += 1;
            this.id = Test.count;
            this.name = name;
            this.price = price;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test t1;    //객체변수
            //t1 = new Test();    //객체생성
            //Console.WriteLine(t1.Power(3));
            //Test t2 = new Test();
            //Console.WriteLine(t2.Power(5));

            //Console.WriteLine(Test.Abs(-3));    //정적메소드 호출
            //Console.WriteLine(Test.Abs(-3.14));
            //Console.WriteLine(Test.Abs(300000000000000));

            Test t1 = new Test("감자", 2000);
            Test t2 = new Test("고구마", 3000);
            Test t3 = new Test("상추", 1000);
            Test t4 = new Test("애호박", 1500);

            Console.WriteLine("상품번호 " + t1.id + " : " + t1.name + "의 가격 : " + t1.price + "원");
            Console.WriteLine("상품번호 " + t2.id + " : " + t2.name + "의 가격 : " + t2.price + "원");
            Console.WriteLine("상품번호 " + t3.id + " : " + t3.name + "의 가격 : " + t3.price + "원");
            Console.WriteLine("상품번호 " + t4.id + " : " + t4.name + "의 가격 : " + t4.price + "원");
            Console.WriteLine("오늘 총 입고된 상품의 갯수는 " + Test.count + "개 입니다.");





        }
    }*/
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
