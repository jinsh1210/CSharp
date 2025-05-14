using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Project8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//9번 문제
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
            //최대,최소 처리
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
            Console.WriteLine(result);*/

            /*Random r;
            r = new Random();
            Console.Write("로또 구입 금액 입력: ");
            int won = int.Parse(Console.ReadLine());

            for (int j = 1; j <= won / 1000; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    int lottery = r.Next(1, 45);
                    Console.Write(lottery + "\t");
                }
                Console.WriteLine();
                if (j % 5 == 0) { Console.WriteLine(); }
            }*/

            /*List<string> Netflix = new List<string>();
            Console.WriteLine("요소의 개수: " + Netflix.Count);
            String item = "";
            while (true)
            {
                Console.WriteLine("보고싶은 넷플릭스 드라마 이름: ");
                item = Console.ReadLine();
                if (item == "exit") break;
                Netflix.Add(item);
            }
            Console.WriteLine("요소의 개수: " + Netflix.Count);
            Console.WriteLine("보고싶은 드라마 목록: ");
            foreach (var drama in Netflix)
            {
                Console.WriteLine(drama);
            }
            Console.WriteLine("-------------------------------------");
            Netflix.Clear();
            foreach (var drama in Netflix)
            {
                Console.WriteLine(drama);
            }*/

            /*//Math m = new Math(); ====> 정적클래스는 객체 생성 불가능.
            Console.WriteLine(Math.PI);
            double a = 53.678;
            Console.WriteLine(a + "의 Ceiling 결과" + Math.Ceiling(a)); // Ceiling = 반올림
            Console.WriteLine(a + "의 Floor 결과" + Math.Floor(a)); // Floor = 내림
            Console.WriteLine(a + "의 Round 결과" + Math.Round(a)); // Round = 올림*/

        }
    }
}
