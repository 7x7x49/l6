using System;

namespace Laba6
{
    internal class Program
    {
        class Animal
        {
            public string NameAnimal;
            public string food;
            public string location;

            public Animal(string NameAnimal, string food, string location)
            {
                this.NameAnimal = NameAnimal;
                this.food = food;
                this.location = location;
            }
            public void eat()
            {
                Console.WriteLine("ест");
            }
            public void makeNoise()
            {
                Console.WriteLine("издает звуки");
            }
            public void sleep()
            {

                Console.WriteLine("дрыхнет");
            }
        }
        class Dog : Animal
        {
            public string NameAnimal;

            public Dog(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} лает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит");
            }
        }

        class Cat : Animal
        {
            public string NameAnimal;

            public Cat(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} мяукает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит");
            }
        }

        class Hourse : Animal
        {
            public string NameAnimal;

            public Hourse(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} шумит");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит");
            }
        }

        class Veterenar
        {
            public void treatAnimal(Animal animal)
            {
                Console.Title = "Инфа о животных";
                Console.WriteLine("Сейчас на приёме у Ветеринара " + animal.NameAnimal);
                Console.WriteLine(animal.NameAnimal + " ест: " + animal.food);
                Console.WriteLine("Обитает: " + animal.location + ".\n");
            }
        }
        static void Main(string[] args)
        {
            Veterenar veterenar = new Veterenar();

            Dog dog = new Dog("Собака Ким", "мясо", "в домике");
            Cat cat = new Cat("Кот Ариана", "цветок", "на лежанке");
            Hourse hourse = new Hourse("Пони Тейлор", "яблоки", "в загоне");

            veterenar.treatAnimal(dog);
            veterenar.treatAnimal(cat);
            veterenar.treatAnimal(hourse);
        }
    }
}