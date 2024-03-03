using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Pet
    {
        private string name;
        private int hunger;
        private int sleepy;
        private int bored;
        private string age;
        private int health;
        private int hygiene;
        private int social;
        private int harndrang;
        private DateTime born;

        private DateTime dateTime;
        private TimeSpan timeSpan;

        public string Name { get => name; set => name = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public int Sleepy { get => sleepy; set => sleepy = value; }
        public int Bored { get => bored; set => bored = value; }
        public string Age { get => age; set => age = value; }
        public int Health { get => health; set => health = value; }
        public int Hygiene { get => hygiene; set => hygiene = value; }
        public int Social { get => social; set => social = value; }
        public int Harndrang { get => harndrang; set => harndrang = value; }
        public DateTime Born { get => born; set => born = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public TimeSpan TimeSpan { get => timeSpan; set => timeSpan = value; }

        public Pet(string name)
        {
            this.name = name;
            hunger = 70;
            sleepy = 70;
            bored = 70;
            age = "0";
            born = DateTime.Now;
            health = 70;
            hygiene = 70;
            social = 70;
            harndrang = 70;
        }

        public void Sleep()
        {
            Random random = new Random();
            if( random.Next(10) < 3)
            {
                sleepy += 10;
                Console.WriteLine("Didnt sleep well");
            }
            System.Console.WriteLine("z Z");
            sleepy = 100;
        }
        public void Feed()
        {
            Random random = new Random();
            if( random.Next(10) < 2)
            {
                hunger -= 10;
                Console.WriteLine("Foood was spoiled");
            }
            hunger += 30;

        }
        public void Play()
        {
            TimeSpan fiveYears = TimeSpan.FromDays(365 * 5);
            if(DateTime.Now - born > fiveYears)
            {
                bored += 15;
            }
            bored += 30;
        }
        public void Aged()
        {

            timeSpan = DateTime.Now - born;
            age = timeSpan.ToString();

            if(DateTime.Now.Day == born.Day)
            {
                Console.WriteLine("Wee making Party, cause it's your birtday.");
            }
        }
        
        public Boolean Sick()
        {
            if(hygiene <20)
                return true;
            return false;
        }

    }
}