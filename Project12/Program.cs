using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{
    /*class Box
    {
        private int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) this.width = value;
                else Console.WriteLine("양수 값을 입력해");
            }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) this.width = value;
                else Console.WriteLine("양수 값을 입력해");
            }
        }

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int Area()
        {
            return this.width * this.height;
        }
    }

    class Circle
    {
        private int radius;
        public int Radius
        {
            get { return radius; }
            set
            {
                if (value > 0) this.radius = value;
                else Console.WriteLine("양수 값을 입력해");
            }
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return radius * radius * Math.PI;
        }*/

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("냠냠 먹어요");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 자요");
        }
    }
    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈 짖어요"); }
    }

    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("냥냥 웁니다"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // C#
            /*Box box = new Box(10, 10);
            Console.WriteLine("현재 너비는 " + box.Width +
                " 현재 높이는 " + box.Height);
            Console.WriteLine("현재 면적은 " + box.Area());
            box.Width = 20;
            box.Height = 30;
            Console.WriteLine("현재 너비는 " + box.Width +
                " 현재 높이는 " + box.Height);
            Console.WriteLine("현재 면적은 " + box.Area());*/

            /*Circle c1 = new Circle(10);
            Console.WriteLine("현재 반지름 " + c1.Radius);
            Console.WriteLine("현재 원의 면적 " + c1.Area());
            c1.radius = 100;
            Console.WriteLine("현재 반지름 " + c1.Radius);
            Console.WriteLine("현재 원의 면적 " + c1.Area());*/

            /*Animal a1 = new Animal();
            a1.Eat();
            a1.Sleep();
            //a1.Bark();
            Dog d1 = new Dog();
            d1.Eat();
            d1.Sleep();
            d1.Bark();
            Animal a2 = new Dog();
            a2.Eat();
            a2.Sleep();
            //(a2 as Dog).Bark();
            ((Dog)a2).Bark();*/

            List<Animal> a1 = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in a1)
            {

                if (item is Dog)
                {
                    Console.WriteLine("강아지는 이런 일을 합니다.");
                    item.Eat();
                    item.Sleep();
                    (item as Dog).Bark();
                }
                else if (item is Cat)
                {
                    Console.WriteLine("고양이는 이런 일을 합니다.");
                    item.Eat();
                    item.Sleep();
                    ((Cat)item).Meow();
                }
            }

        }
    }
}
