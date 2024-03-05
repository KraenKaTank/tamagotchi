using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Pet
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
        private bool awake = true;
        private bool alive;
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

        public Pet(string nameV)
        {
            name = nameV;
            alive = true;
            hunger = 70;
            sleepy = 70;
            bored = 70;
            age = 0;
            health = 70;
            hygiene = 70;
            social = 70;
            harndrang = 30;
        }
        public Pet CreatePet(){
            System.Console.WriteLine("Wie soll dein Tamagotchi heißen?");
            string nameOfNew = Console.ReadLine();
            return new Pet(nameOfNew); 

        }

        public void SetStat(int value, ref int stat){
            if(stat + value < 0){
                stat = 0;
            }else{
                stat += value;
            }
        }

        public void ShowStats()
        {

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
            if (random.Next(10) < 3)
            {
                SetStat(10,ref sleepy);
                Console.WriteLine(name + " hat nicht gut geschlafen");
            }
            Console.WriteLine("z Z");
            sleepy = 100;
        }
        public void Feed()
        {
            if (random.Next(10) < 1)
            {
                SetStat(-10, ref hunger);
                sick = true;
                Console.WriteLine("Food was spoiled");
            }
            SetStat(30, ref hunger);

        }
        public void Play()
        {
            if (age > 5)
            {
                SetStat(15,ref bored);
            }
            SetStat(30, ref bored);
        }
        public void Dead(string name, string dead)
        {

            alive = false;
            Console.Clear();
            Console.WriteLine(name + " ist gestorben wegen " + dead);
            // Environment.Exit(0);


        }


        public void SimulateTime()
        {

            while (alive)
            {
                 if (awake)
                {
                Thread.Sleep(1000);
                age += 0.05;
                SetStat(-3, ref hunger);
                SetStat(-3, ref hygiene);
                SetStat(3,ref harndrang);
                SetStat(-3, ref bored);
                SetStat(-1, ref sleepy);
                }

            }
        }
        public void CheckStats()
        {

            if(hygiene < 20 && alive  ){
                if(random.Next(20) < 1){
                    sick = true;
                }
                
            }
            if (sick && alive)
            {
                System.Console.WriteLine(name + " ist Krank!");
                SetStat(-5, ref health);
                if (random.Next(10) < 1)
                {
                    Dead(name, "Krankheit");
                }
            }
            if (hunger < 30 && alive)
            {
                System.Console.WriteLine(name + " hat Hunger!");
                if (hunger == 0)
                {
                    System.Console.WriteLine(name + " ist am verhungern!");
                    SetStat(-5, ref health);
                    if (random.Next(10) < 1)
                    {
                        Dead(name, "Hunger");
                    }
                }
            }
            if (sleepy < 20 && alive)
            {
                System.Console.WriteLine(name +" ist müde!");
                if (sleepy <= 0)
                {
                    Sleep();
                    System.Console.WriteLine(name + " ist eingeschlafen!");
                }
            }
            if (harndrang > 80 && alive)
            {
                System.Console.WriteLine(name + " muss auf Toilette!");
                if (harndrang > 99)
                {
                    System.Console.WriteLine(name + " hat sich eingepinkelt!");
                    SetStat(-70, ref harndrang);
                    SetStat(-50, ref hygiene);
                }

            }
            if (bored < 30 && alive)
            {
                System.Console.WriteLine(name + " ist gelangweilt!");
            }

        }

    }
}