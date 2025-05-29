using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("쿨쿨 잡니다.");
        }
    }
    class Dog : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("멍멍 잡니다.");
        }
        public override void Eat()
        {
            Console.WriteLine("강아지 사료를 먹습니다.");
        }
    }
    class Cat : Animal
    {
        public void Sleep()
        {
            Console.WriteLine("야옹야옹 잡니다.");
        }
        public override void Eat()
        {
            Console.WriteLine("고양이 사료를 먹습니다.");
        }
    }
    abstract class Parent
    {
        abstract public void test();
    }
    class Child : Parent
    {
        public override void test()
        {
            Console.WriteLine("집 가고 싶다~");
        }
    }
    class FPlayer<T>
    {
        public T Value;

        public FPlayer(T value)
        {
            this.Value = value;
        }
    }
    class CircleArea
    {
        public double this[int r]
        {
            get { return Math.PI * r * r; }
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            Animal a1 = new Animal();
            Dog d1 = new Dog();
            Cat c1 = new Cat();

            a1.Eat(); // Animal 클래스의 Eat 메서드 호출
            d1.Eat(); // Dog 클래스의 Eat 메서드 호출
            c1.Eat(); // Cat 클래스의 Eat 메서드 호출
            Animal a2 = new Dog(); // 업캐스팅
            Animal a3 = new Cat(); // 업캐스팅

            a2.Eat(); // Dog 클래스의 Eat 메서드 호출 (다형성)
            a2.Sleep(); // Animal 클래스의 Sleep 메서드 호출 (업캐스팅으로 인해 Animal 클래스의 Sleep 메서드가 호출됨)
            
            ((Animal)a3).Eat(); // Cat 클래스의 Eat 메서드 호출 (다형성)*/
            /*//Parent p1 = new Parent();
            Child c1 = new Child();
            c1.test(); // Child Method1 호출*/
            /*FPlayer<string> name = new FPlayer<string>("손흥민");
            FPlayer<int> wPay = new FPlayer<int>(190000);
            FPlayer<double> pSu = new FPlayer<double>(0.9);
            Console.WriteLine($"이름: {name.Value}, 주급: {wPay.Value} 파운드 패스성공률: {pSu.Value * 100}% 입니다.");*/
            CircleArea c = new CircleArea();
            Console.Write("반지름: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"반지름이 {r}인 원의 넓이는 {c[r]}입니다.");
        }
    }
}
