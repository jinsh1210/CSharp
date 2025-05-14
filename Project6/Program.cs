using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] baseball = { "LG", "삼성", "SSG", "롯데", "기아" };

            Console.Write("야구구단명 : ");

            foreach (string b in baseball)
            {
                if (b != "기아")
                    Console.Write(b + ", ");
                else
                    Console.WriteLine(b);
            }

            for (int i = 0; i < baseball.Length; i++)
            {
                if (baseball[i] != "기아")
                    Console.Write(baseball[i] + ", ");
                else
                    Console.WriteLine(baseball[i]);
            }
            
            for(int a = 1; a <= 10; a++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int a = 10; a >= 1; a--)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            
            for (int a = 1; a <= 10; a++)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int a = 9; a >= 0; a--)
            {
                for (int i = 1; i <= a; i++)
                    Console.Write("  ");
                for (int j = 1; j <= 10 - a; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }

            for (int hak = 1; hak <= 2; hak++)
            {
                for (int ban = 1; ban <= 4; ban++)
                {
                    Console.WriteLine(hak + "학년 " + ban + "반 ");
                }
            }
            
            for (int j = 2; j <= 5; j++)
            {
                for (int i = 1; i <= 9; i++)
                {
                    Console.Write(j + " * " + i + " = " + j * i + "\t");
                }
                Console.WriteLine();
            }
            
            while (true)
            {
                Console.Write("아이디 입력 : ");
                string id = Console.ReadLine().Trim();
                Console.Write(id + "로 가입하시나요?(Y/N) : ");
                string ans = Console.ReadLine();

                if (ans == "Y" || ans == "y")
                {
                    Console.WriteLine(id + "로 가입 성공");
                }
                else if (ans == "N" || ans == "n")
                {
                    Console.WriteLine("가입 취소");
                }
                else
                {
                    Console.WriteLine("잘못입력");
                    break;
                }
            }
            
            Console.Write("주소 입력 : ");
            string address = Console.ReadLine();

            string[] addrData = address.Split(new char[] { ' ' });

            foreach (var data in addrData)
            {
                Console.Write(data + "::");
            }
            
            Console.Write("휴대폰 번호 입력 : ");
            string phone = Console.ReadLine();

            string[] phonedata = phone.Split(new char[] { '-' });

            foreach (var data in phonedata)
            {
                Console.Write(data + "::");
            }
            Console.WriteLine();

            Console.WriteLine(string.Join("::", phonedata));
            */

            Console.Write("SetCursorPosition 호출 전");
            Console.SetCursorPosition(10, 5);
            Console.Write("SetCursorPosition 호출 후");

            Thread.Sleep(2000);

            Console.Clear();
            Console.WriteLine("새로운 화면 시작");

            for (int i = 1; i <= 100; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, 3);
                Console.Write("안녕");
                Thread.Sleep(500);
            }
        }
    }
}
