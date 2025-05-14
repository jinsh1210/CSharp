using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("인하공업전문대학");  //Console.Write() or Writeline() 출력
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("컴퓨터시스템공학과");
            Console.Write("이름을 입력하세요 : ");
            string sName = Console.ReadLine();      //Console.ReadLine()  입력
            Console.WriteLine("당신의 이름은 : " + sName);
            Console.Write("나이를 입력하세요 : ");
            int Age = int.Parse(Console.ReadLine());    //int.Parse(Console.ReadLine()); 정수형으로 변환
            Console.WriteLine("당신의 나이는 : " + Age);

            
            
        }
    }
}
