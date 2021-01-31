using System;
using System.Threading;

namespace Petshop
{
    class Cat
    {
        private string nickname;
        public string Nickname
        {
            get { return nickname; }
            set
            {
                if (!string.IsNullOrEmpty(nickname))
                {
                    nickname = value;
                }
            }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (age != 0) { age = value; }
            }
        }
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (!String.IsNullOrEmpty(gender))
                {
                    gender = value;
                }
            }
        }
        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {
                if (energy >= 0)
                {
                    energy = value;
                }
            }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (price != 0)
                {
                    price = value;
                }
            }
        }
        private int mealQuantity;
        public int MealQuantity
        {
            get { return mealQuantity; }
            set
            {
                if (mealQuantity <= 0)
                {
                    mealQuantity = value;
                }
            }
        }
public void Sleep(int minute) {
        
        }
        public void Play()
        {
            if (Energy != 0)
            {
                Console.WriteLine($"Hello my name is{Nickname}");
                Console.WriteLine("I want to play game with you");
                Console.WriteLine("Lets play hide and seek");
                Console.WriteLine("Go hide,i will count till 10");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                Console.WriteLine("Meow,meowww i am coming for you");
                Console.WriteLine("Where are you");
                Console.WriteLine("Oh my meow,you are here!");
                Energy = Energy - 10;
                if (Energy < 0) { Energy = 0; Sleep(); }
            }
            if (Energy == 0)
            {
                Console.WriteLine("Meow,meoww i need to sleep");
                Console.WriteLine("Let me sleep");
            }
        }

    }
}
