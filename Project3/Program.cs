using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int age;      //변수 선언
            age = 20;       //변수 데이터할당(대입, 저장)
            int h = 164;    //변수 선언 및 초기화

            Console.WriteLine(age + h);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("키 : " + h);
            char cData = 'a';
            Console.WriteLine((int)cData);
            string sData = "\'인\t하\t공업\n전문대학\'";
            Console.WriteLine(sData);
            Console.WriteLine(sData[5]);
            bool chk;
            chk = age >= 20; //true
            Console.WriteLine("당신은 성인 : " + chk);
            age = 15;
            chk = age >= 20;
            Console.WriteLine("당신은 성인 : " + chk);*/


            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);
            var input = "inha";             // var 변수 선언시 초기화 해주어야함.
            Console.WriteLine(input + " university");
        }
    }
}
