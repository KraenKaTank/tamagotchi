using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Tamagotchi;

Pet pet = new Pet("Pascal");
LinuxPet linuxPet = new LinuxPet();

Thread time = new Thread(pet.SimulateTime);
time.Start();

Thread visual = new Thread(new ParameterizedThreadStart(linuxPet.LinuxTamagotchi));
visual.Start(pet);

while(pet.Alive){
    
}