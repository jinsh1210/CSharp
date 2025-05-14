using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//1번 문제
            string day;
            Console.Write("요일: ");
            day = Console.ReadLine();

            switch (day)
            {
                case "월":
                case "화":
                case "수":
                case "목":
                    Console.WriteLine("출근");
                    break;
                default:
                    Console.WriteLine("휴일");
                    break;
            }*/

            /*//2번 문제
            Console.Write("점수 입력: ");
            int score = int.Parse(Console.ReadLine());

            if (score < 0 || score > 100)
            {
                Console.WriteLine("잘못된 점수입니다");
            }
            else
            {
                if (score >= 90 && score <= 100)
                {
                    Console.WriteLine("A");
                }
                else if (score >= 80 && score < 90)
                {
                    Console.WriteLine("B");
                }
                else if (score >= 70 && score < 80)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }*/

            /*//3번 문제
            Console.Write("x값 : ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y값 : ");
            int y = int.Parse(Console.ReadLine());

            int sum = 0;

            if (x > y)
            {
                for (int i = y; i <= x; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"{y}에서 {x}까지의 합: {sum}");
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"{x}에서 {y}까지의 합: {sum}");
            }*/

            /*//4번 문제
            Console.Write("몇 개 숫자 입력: ");
            int n = int.Parse(Console.ReadLine());
            int[] num = new int[n];
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("숫자 입력: ");
                num[i - 1] = int.Parse(Console.ReadLine());
                sum += num[i - 1];
            }
            Console.WriteLine($"입력하신 숫자들의 합: {sum}");*/

            /*//5번 문제
            Console.Write("n\t");
            for(int i = 1; i<=10; i++)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
            Console.Write("n제곱\t");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i*i + "\t");
            }
            Console.WriteLine();*/

            /*//6번 문제
            string pw = "aaaa";

            while (true)
            {
                Console.Write("암호 : ");
                string trypw = Console.ReadLine();

                if (trypw != "aaaa")
                {
                    Console.WriteLine("다시 입력하세요.");
                }
                else 
                {
                    Console.WriteLine("통과");
                    return; 
                }
            }*/

            /*//7번 문제
            while (true)
            {
                Console.Write("숫자 입력: ");
                string input = Console.ReadLine();

                if (input == "exit") { break; }
                if (input[0] == input[input.Length - 1])
                {
                    Console.WriteLine("성공");

                }
                else
                {
                    Console.WriteLine("다름");
                }
            }*/

            /*//8번 문제
            Console.Write("주민번호 입력(-없이): ");
            string humanId = Console.ReadLine();
            int size = humanId.Length;
            int gender = 0;
            int cent = 0;

            //13자리보다 적거나 많으면 잘못된 입력
            if (size != 13)
            {
                Console.WriteLine("잘못된 입력");
                return;
            }

            //남녀 구분
            if (humanId[6] == '1' || humanId[6] == '3') { gender = 1; }
            else if (humanId[6] == '2' || humanId[6] == '4') { gender = 2; }

            //2000년 이전 이후 구분
            if (humanId[6] == '1' || humanId[6] == '2') { cent = 1; }
            else if (humanId[6] == '3' || humanId[6] == '4') { cent = 2; }

            //주민번호출력
            Console.Write("주민번호정보: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(humanId[i]);
            }
            Console.Write("-");
            for (int i = 6; i < 13; i++)
            {
                Console.Write(humanId[i]);
            }
            Console.WriteLine();

            //생년월일 출력
            Console.Write("생년월일: ");
            if (cent == 1)
            {
                Console.Write("19");
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(humanId[i]);
                }
                Console.Write("년");
                for (int i = 2; i < 4; i++)
                {
                    Console.Write(humanId[i]);
                }
                Console.Write("월");
                for (int i = 4; i < 6; i++)
                {
                    Console.Write(humanId[i]);
                }
                Console.Write("일");
            }
            else if (cent == 2)
            {
                Console.Write("20");
                for (int i = 0; i < 2; i++)
                {
                    Console.Write(humanId[i]);
                }
                Console.Write("년");
                for (int i = 2; i < 4; i++)
                {
                    Console.Write(humanId[i]);
                }
                Console.Write("월");
                for (int i = 4; i < 6; i++)
                {
                    Console.Write(humanId[i]);
                }
                Console.Write("일");
            }
            Console.WriteLine();

            //성별 출력
            Console.Write("성별: ");
            if (gender == 1) { Console.WriteLine("남성"); }
            else if (gender == 2) { Console.WriteLine("여성"); }*/

            //9번 문제
            //숫자 입력
            Console.Write("숫자(최대 1,000,000): ");
            int num = int.Parse(Console.ReadLine());
            //문자열 배열
            string[] kor = { "", "일", "이", "삼", "사", "오", "육", "칠", "팔", "구" };
            string[] position = { "", "십", "백", "천", "만", "십" };

            //오류 처리
            if (num < 0 || num > 1000000)
            {
                Console.WriteLine("범위 오류");
                return;
            }
            //예외 처리
            if (num == 0)
            {
                Console.WriteLine("영");
                return;
            }
            else if (num == 1000000)
            {
                Console.WriteLine("백만");
                return;
            }

            //숫자를 문자열로 변환
            string strnum = num.ToString(); //ex) 999,999일 때 strnum = "999999"
                                            //한글 문자열 크기
            int size = strnum.Length;
            //결과값 초기화
            string result = "";

            //메인코드
            for (int i = 0; i < size; i++)
            {
                //인덱스 필드
                int digit = strnum[i] - '0';    // '1'-'0' = 1
                int pos = size - i - 1;         // 6 - 5 - 1 = 0 / 다섯 번째 자릿 수
                if (digit != 0)
                {
                    //10, 100, 1,000, 10,000, 100,000 경우 일 표시 x
                    if (digit == 1 && pos != 4 && pos != 0)
                    {
                        result += position[pos];
                    }
                    //십의 자리 뒤에 오는 건 표시
                    else if (digit == 1 && pos == 0)
                    {
                        result += kor[digit];
                    }
                    else
                    {
                        result += kor[digit] + position[pos];
                    }
                }
                else
                {
                    if (pos == 4 && result != "")
                    {
                        result += "만";
                    }
                }

            }
            //결과값 출력
            Console.WriteLine(result);

        }
    }
}
