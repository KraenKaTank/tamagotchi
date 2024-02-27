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

        public Pet(string name)
        {
            this.name = name;
            this.hunger = 70;
            this.sleepy = 70;
            this.bored = 70;
            this.age = "0";
            this.born = DateTime.Now;
            this.health = 70;
            this.hygiene = 70;
            this.social = 70;
            this.harndrang = 70;
        }

        public void Sleep()
        {
            Random random = new Random();
            if( random.Next(10) < 3)
            {
                this.sleepy += 10;
                Console.WriteLine("Didnt sleep well");
            }
            this.sleepy = 100;
        }
        public void Feed()
        {
            Random random = new Random();
            if( random.Next(10) < 2)
            {
                this.hunger -= 10;
                Console.WriteLine("Foood was spoiled");
            }
            this.hunger += 30;

        }
        public void Play()
        {
            TimeSpan fiveYears = TimeSpan.FromDays(365 * 5);
            if(DateTime.Now - this.born > fiveYears)
            {
                this.bored += 15;
            }
            this.bored += 30;
        }
        public String Age()
        {

            timeSpan = DateTime.Now - this.born;
            this.age = timeSpan.ToString();

            if(DateTime.Now.Day == this.born.Day)
            {
                Console.WriteLine("Wee making Party, cause it's your birtday.");
            }
            return this.age;
        }
        
        public Boolean Sick()
        {
            if(this.hygiene <20)
                return true;
            return false;
        }

    }
}