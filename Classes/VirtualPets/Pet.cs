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
        private double age;
        private int health;
        private int hygiene;
        private int social;
        private int harndrang;
        private bool awake;
        private bool alive;
        private bool sick;
        private bool hatched;
        private Random random = new Random();



        public Pet(string name)
        {
            this.name = name;
            hunger = 70;
            sleepy = 70;
            bored = 70;
            age = 0;
            health = 70;
            hygiene = 70;
            social = 70;
            harndrang = 30;
        }

        public void Sleep()
        {
            Random random = new Random();
            if( random.Next(10) < 3)
            {
                sleepy += 10;
                Console.WriteLine("Didn't sleep well");
            }
            Console.WriteLine("z Z");
            sleepy = 100;
        }
        public void Feed()
        {
            if( random.Next(10) < 2)
            {
                hunger -= 10;
                Console.WriteLine("Food was spoiled");
            }
            hunger += 30;

        }
        public void Play()
        {
            if(age > 5)
            {
                bored += 15;
            }
            bored += 30;
        }

        public void SimulateTime(){
            
                Thread.Sleep(6000);
                age += 0.10;
                hunger -= 1;
                hygiene -= 1;

                if(hygiene < 20){
                    if(random.Next(10) < 3){
                        sick = true;
                    }
                }

                if(awake){
                sleepy -= 1;
                }
        }
        
        public string Name { get => name; set => name = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public int Sleepy { get => sleepy; set => sleepy = value; }
        public int Bored { get => bored; set => bored = value; }
        public int Health { get => health; set => health = value; }
        public int Hygiene { get => hygiene; set => hygiene = value; }
        public int Social { get => social; set => social = value; }
        public int Harndrang { get => harndrang; set => harndrang = value; }

    }
}