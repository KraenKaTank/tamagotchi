using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Tamagotchi;

Pet pet = new Pet("Pascal");
LinuxPet linuxPet = new LinuxPet();

Thread time = new Thread(pet.SimulateTime);
time.Start();

Thread visual = new Thread(linuxPet.TamagotchiEgg);

visual.Start();
visual.Join();

while(pet.Alive){
    if(pet.Age > 0.5){
        visual = new Thread(linuxPet.TamagotchiHatched);
        visual.Start();

    }
    if(pet.Age <= 1){

    }
}