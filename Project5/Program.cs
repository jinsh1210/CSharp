using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*while (true)
            {
                Console.Write("점수 입력 : ");
                int num = int.Parse(Console.ReadLine());
                if (num < 0 || num > 100)
                {
                    Console.WriteLine("0 ~	100 사이 점수를 입력해주세요.");
                    return;
                }
                switch (num / 10)
                {
                    case 10:
                    case 9:
                        Console.WriteLine(num + "점은 A학점");
                        break;
                    case 8:
                        Console.WriteLine(num + "점은 B학점");
                        break;
                    default:
                        Console.WriteLine(num + "점은 F학점");
                        Console.WriteLine("재수강 필수");
                        break;
                }   //switch 끝
                
                //다시하기 선택
                Console.Write("계속하기 Y/N: ");
                String result = (Console.ReadLine());

                // Y or y 이면 while 처음으로
                if (result == "Y" || result == "y") { }
                
                // N or n 이면 while 밖으로
                else if (result == "N" || result == "n"){break;}

                // 잘못 입력할 경우 강제로 종료
                else
                {
                    Console.WriteLine("값이 정확하지 않아 강제로 종료합니다");
                    return;
                }
            }   //while 끝
            Console.WriteLine("안녕히 가세요.");*/

            /*while (true)
            {
                Console.Write("학년 : ");
                string hak = (Console.ReadLine());
                switch (hak[0])
                {
                    case '1':
                        Console.WriteLine("1학년 MT는 3월 2일부터 3월 4일까지 시행");
                        break;
                    case '2':
                        Console.WriteLine("2학년 MT는 3월 5일부터 3월 7일까지 시행");
                        break;
                    case '3':
                        Console.WriteLine("3학년 MT는 3월 8일부터 3월 10일까지 시행");
                        break;
                    default:
                        Console.WriteLine(hak + "학년은 없습니다.");
                        Console.WriteLine("다시 입력하세요.");
                        break;
                }   //switch 끝
                //다시하기 선택
                Console.Write("계속하기 Y/N: ");
                String result = (Console.ReadLine());

                // Y or y 이면 while 처음으로
                if (result == "Y" || result == "y") { }

                // N or n 이면 while 밖으로
                else if (result == "N" || result == "n"){break;}

                // 잘못 입력할 경우 강제로 종료
                else
                {
                    Console.WriteLine("값이 정확하지 않아 강제로 종료합니다");
                    return;
                }
            }   //while 끝*/

            /*while (true)
            {
                Console.Write("에스파 멤버 중 한 명의 이름 : ");
                string Mem = Console.ReadLine();
                string Aespa = "카리나,윈터,지젤,닝닝";

                switch (Aespa.Contains(Mem))
                {
                    case true:
                        Console.WriteLine(Mem + "는(은) 에스파 멤버가 맞습니다.");
                        break;
                    case false:
                        Console.WriteLine(Mem + "는(은) 에스파 멤버가 아닙니다.");
                        break;

                }   //swith 끝
                //다시하기 선택
                Console.Write("다시하기 Y/N: ");
                String result = (Console.ReadLine());

                // Y or y 이면 while 처음으로
                if (result == "Y" || result == "y") { }

                // N or n 이면 while 밖으로
                else if (result == "N" || result == "n") { break; }

                // 잘못 입력할 경우 강제로 종료
                else
                {
                    Console.WriteLine("값이 정확하지 않아 강제로 종료합니다");
                    return;
                }
            }   //while 끝*/

            /*Console.Write("키보드 아무 방향키를 누르시오 : ");

            //키보드 정보를 info에 저장
            ConsoleKeyInfo info = Console.ReadKey();
            
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위쪽 방향키");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래쪽 방향키");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽 방향키");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽 방향키");
                    break;
            }   //swith 종료*/

            /*string[] f = { "바나나", "사과", "딸기", "포도" };
            int[] price = { 1000, 2000, 3000, 4000 };

            for (int i = 0; i < 4; i++)
            {
                Console.Write(f[i] + "\t");
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(price[i] + "원\t");
            }
            Console.WriteLine();

            for (int i = 1; i <= 12; i++)
            {
                if (i == 12)
                {
                    Console.WriteLine(i + "월 ");
                }
                else
                {
                    Console.Write(i + "월 ");
                }
            }
            // foreach문 배열에서 유용
            foreach (string f2 in f)
            {
                Console.Write(f2 + "\t");
            }
            Console.WriteLine();
            foreach (int p2 in price)
            {
                Console.Write(p2 + "\t");
            }
            Console.WriteLine();*/


            /*Console.Write("몇 명의 친구가 있습니까 : ");
            int ans = int.Parse(Console.ReadLine());

            string[] sname = new string[ans];

            for (int i = 0; i < sname.Length; i++)
            {
                Console.Write((i + 1) + "번 친구이름 입력 : ");
                sname[i] = Console.ReadLine();
            }

            Console.Write("{ ");
            for (int i = 0; i < sname.Length; i++)
            {
                if (i == sname.Length - 1)
                {
                    Console.Write(sname[i] + " ");
                }
                else
                    Console.Write(sname[i] + ", ");
            }
            Console.WriteLine("}");*/

            Console.Write("메세지 내용을 입력 : ");
            string msg = Console.ReadLine();
            Console.Write(msg + "의 역순은 : ");
            for (int i = msg.Length - 1; i >= 0; i--)
            {
                Console.Write(msg[i]);
            }
            Console.WriteLine();
        }
    }
}
