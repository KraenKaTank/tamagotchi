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
        private bool awake= true;
        private bool alive = true;
        private bool sick = false;
        private bool hatched;
        private Random random = new Random();

        public string Name { get => name; set => name = value; }
        public int Hunger { get => hunger; set => hunger = value; }
        public int Sleepy { get => sleepy; set => sleepy = value; }
        public int Bored { get => bored; set => bored = value; }
        public double Age { get => age; set => age = value; }
        public int Health { get => health; set => health = value; }
        public int Hygiene { get => hygiene; set => hygiene = value; }
        public int Social { get => social; set => social = value; }
        public int Harndrang { get => harndrang; set => harndrang = value; }
        public bool Awake { get => awake; set => awake = value; }
        public bool Alive { get => alive; set => alive = value; }
        public bool Sick { get => sick; set => sick = value; }
        public bool Hatched { get => hatched; set => hatched = value; }

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

        public void ShowStats(){
            
            System.Console.Write("Name: [" + Name);
            System.Console.Write("]  Alter: [" + Math.Round(Age, 1));
            System.Console.Write("]  Hunger: [" + Hunger);
            System.Console.Write("]  Schlaf: [" + Sleepy);
            System.Console.Write("]  Unterhaltung: [" + Bored);
            System.Console.Write("]  Gesundheit: [" + Health);
            System.Console.Write("]  Hygiene: [" + hygiene);
            System.Console.Write("]  Harndrang: [" + Harndrang);
            System.Console.WriteLine("]  Krank: [" + Sick + "]");
        }

        public void Sleep()
        {
            Random random = new Random();
            if( random.Next(10) < 3)
            {
                sleepy += 10;
                Console.WriteLine(name +" hat nicht gut geschlafen");
            }
            Console.WriteLine("z Z");
            sleepy = 100;
        }
        public void Feed()
        {
            if( random.Next(10) < 1)
            {
                hunger -= 10;
                sick = true;
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
            
                while(alive){  
                    
                Thread.Sleep(6000);   
                age += 0.10;
                hunger -= 1;
                hygiene -= 1;
                harndrang += 1;
                bored -= 1;

                if(hygiene < 20){
                    if(random.Next(10) < 3){
                        sick = true;
                    }
                }

                if(awake){
                sleepy -= 1;
                }

                }
        }
        public void CheckStats(){
            if(alive){

            
            if(sick){
                System.Console.WriteLine(name +" ist Krank!");
                health -= 5;
                if(random.Next(10) < 1){
                    alive = false;
                    System.Console.WriteLine(name +" ist gestorben!");
                }
            }
            if(hunger < 30){
                System.Console.WriteLine(name +" hat Hunger!");
                if(hunger == 0){
                    System.Console.WriteLine(name +" ist am verhungern!");
                    health -= 5;
                    if(random.Next(10) < 1){
                        System.Console.WriteLine(name +" ist verhungert!");
                        alive = false;
                    }
                }
            }
            if(sleepy < 20 ){
                System.Console.WriteLine("Du bist müde!");
                if(sleepy <= 0){
                    Sleep();
                    System.Console.WriteLine(name +" ist eingeschlafen!");
                }
            }
            if(harndrang > 80){
                System.Console.WriteLine(name +" muss auf Toilette!");
                if(harndrang > 99){
                    System.Console.WriteLine(name +" hat sich eingepinkelt!");
                    harndrang -= 70;
                    hygiene -= 50;
                }

            }
            if(bored < 30){
                System.Console.WriteLine(name +" ist gelangweilt!");
            }
        }
        }

    }
}