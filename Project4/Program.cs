using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int age = 0;
            Console.Write("나이 입력 : ");
            age = int.Parse(Console.ReadLine());
            int point = (age / 10) * 100;
            Console.WriteLine(age + "살의 포인트 점수는 " + point + "점");

            age = (int)28.7852; //강제형변환, 데이터 손실
            Console.WriteLine(age + "살");

            double age2 = age;  //자동형변환, 데이터 손실 없음
            Console.WriteLine(age2.ToString("0.0000" + "살"));
            Console.WriteLine((63.13456789).ToString("0.000"));*/

            /*Console.Write("성별 입력(남/여) : ");
            string gender = Console.ReadLine();
            Console.Write("나이 입력 : ");
            int age = int.Parse(Console.ReadLine());

            //if else 조건문
            if ( gender == "남")
            {
                Console.WriteLine("오른쪽으로 가세요");
                if (age >= 20 && age <= 29)
                {
                    Console.WriteLine("1호관으로 이동");
                }
                else
                {
                    Console.WriteLine("2호관으로 이동");
                }
            }
            else
            {
                Console.WriteLine("왼쪽으로 가세요");
                if (age >= 20 && age <= 29)
                {
                    Console.WriteLine("3호관으로 이동");
                }
                else
                {
                    Console.WriteLine("4호관으로 이동");
                }
            }*/


            /*//if else if 조건문
            int jumsu;
            Console.Write("점수를 입력 : ");
            jumsu = int.Parse(Console.ReadLine());
            if (jumsu >= 90 && jumsu <= 100)
                Console.WriteLine("A학점");
            else if (jumsu >= 80)
                Console.WriteLine("B학점");
            else if (jumsu >= 70)
                Console.WriteLine("C학점");
            else
            {
                Console.WriteLine("F학점");
                Console.WriteLine("재수강필요");
            }*/

            /*//현재 날짜와 시간 정보를 추출하는 방법
            Console.WriteLine(DateTime.Now.Year + "년");
            Console.WriteLine(DateTime.Now.Month + "월");
            Console.WriteLine(DateTime.Now.Day + "일");
            Console.WriteLine(DateTime.Now.Hour + "시");
            Console.WriteLine(DateTime.Now.Minute + "분");
            Console.WriteLine(DateTime.Now.Second + "초");

            int h = 1; // DateTime.Now.Hour;
            if (h < 12)
            {
                Console.Write("오전");
                if (h < 9)
                    Console.WriteLine(" 영업전");
                else
                    Console.WriteLine(" 영업중");

            }
            else
            {
                Console.Write("오후");
                if (h < 15)
                    Console.WriteLine(" 1부 영업중");
                else if (h >= 15 && h <= 17)
                    Console.WriteLine(" 브레이크 타임");
                else if (h > 17 && h < 20)
                    Console.WriteLine(" 2부 영업중");
                else
                    Console.WriteLine(" 영업종료");
            }*/

            /*int m = DateTime.Now.Month;

            if (m == 3 || m == 4 || m == 5)
                Console.WriteLine("봄");
            else if (m >= 6 && m < 9)
                Console.WriteLine("여름");
            else if (m >= 9 && m < 12)
                Console.WriteLine("가을");
            else
                Console.WriteLine("겨울");*/

            int d = DateTime.Now.Day;

            if (d>=1 && d<11)
                Console.WriteLine("초순");
            else if (d >= 11 && d < 21)
                Console.WriteLine("중순");
            else
                Console.WriteLine("하순");
        }
    }
}
