using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Tamagotchi;

Pet pet = new Pet("Pascal");

Thread time = new Thread(pet.SimulateTime);
time.Start();



Console.ReadLine();