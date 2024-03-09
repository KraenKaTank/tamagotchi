using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Tamagotchi;


bool wantToPlay = true;
Pet pet;
LinuxPet petModel = new LinuxPet();
string petName;
int petType;
int control;

System.Console.WriteLine("Herzlich Willkommen zu Tamagotchi!");
System.Console.WriteLine("Wie soll dein Tamagotchi heißen?");
petName = Console.ReadLine();


// System.Console.WriteLine("Welchen Tamagotchi hättest du gerne?");
// System.Console.WriteLine("Linux Pinguin [1]");

// while(!int.TryParse(Console.ReadKey().KeyChar.ToString(), out petType)){
// }

pet = new Pet(petName);


Thread time = new Thread(pet.SimulateTime);
time.Start();

Thread visual = new Thread(new ParameterizedThreadStart(petModel.LinuxTamagotchi));
visual.Start(pet);


while(wantToPlay){

if(!pet.Alive){
    System.Console.WriteLine("Willst du einen neuen Tamagotchi erstellen? y = yes / any = no");
    if(Console.ReadKey().ToString() == "y"){
            System.Console.WriteLine("Wie soll dein Tamagotchi heißen?");
            pet = new Pet(Console.ReadLine());
    }else{
        System.Console.WriteLine("Tschüss!");
        wantToPlay = false;
    }
}
if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out control)){
    switch (control)
    {
        case 1:
        pet.Feed();
        break;

        case 2:
        pet.Play();
        break;

        case 3:
        pet.Sleep();
        break;
        
        case 4:
        pet.Medicate();
        break;

        case 5:
        pet.Shower();
        break;

        case 6:
        pet.UseToilette();
        break;
        
        default:
        break;
    }
}


}

