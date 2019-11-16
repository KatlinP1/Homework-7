using System;

namespace Homework7
{
    public class Animal
    {
        public string name;
        public int age = 0;
        public double weight;
        public int lifespan =0;
        private static string[] Food = new string[5]{"carrot", "seeds","apple","tomato","pizza"};
        private static string[] Workouts = new string[5]{"runs", "does street workout","does push ups","dances","lifts weights"};
        
        
        public Animal(string _name, double _weight, int _age=0, int _lifespan=0)
        {
            name = _name;
            age = _age;
            weight = _weight;
            lifespan = _lifespan;

        }

        public void PrintAnimalBaseInfo()
        {
            Console.WriteLine($"Name:{name}");
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Weight:{weight}");
            Console.WriteLine($"Lifespan:{lifespan}");
        }

        public void PrintLifespan()
        {
            Console.WriteLine($"Lifespan:{lifespan}");
        }
        
        public void PrintWeight()
        {
            Console.WriteLine($"Weight:{weight}");
        }

        public void Eat()
        {
            weight += 0.2;
            Console.WriteLine($"{name} eats {GetRandomFood()} and now weights {weight}");
        }

        public void Exercise()
        {
            weight -= 0.1;
            Console.WriteLine($"{name} {GetRandomWorkout()} and now weights {weight}");
        }

        public string GetRandomFood()
        {
            Random rnd= new Random();
            int random=rnd.Next(Food.Length);
            return Food[random];
        }

        public string GetRandomWorkout()
        {
            Random rnd=new Random();
            int random = rnd.Next(Workouts.Length);
            return Workouts[random];
        }
        
    }
}