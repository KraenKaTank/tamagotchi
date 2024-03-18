using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Tamagotchi;


bool wantToPlay = true;
Pet pet;
LinuxPet petModel = new LinuxPet();
string petName;
int petType;
int control;
GUI gui = new GUI();


gui.IntroStart();

System.Console.WriteLine("Herzlich Willkommen zu Tamagotchi!");
System.Console.WriteLine("Wie soll dein Tamagotchi heißen?");
petName = Console.ReadLine();





// System.Console.WriteLine("Welchen Tamagotchi hättest du gerne?");
// System.Console.WriteLine("Linux Pinguin [1]");
// while(!int.TryParse(Console.ReadKey().KeyChar.ToString(), out petType)){
// }


pet = new Pet(petName);

System.Console.WriteLine("Willst du im Hardmode spielen? y/n");

if (Console.ReadLine() == "y")
{
    pet.HardMode = true;
}


Thread time = new Thread(pet.SimulateTime);
time.Start();

Thread visual = new Thread(new ParameterizedThreadStart(petModel.Tamagotchi));
visual.Start(pet);



while (wantToPlay)
{

    if (!pet.Alive)
    {

        time.Join(1000);
        visual.Join(1000);


        System.Console.WriteLine("Willst du einen neuen Tamagotchi erstellen? y = yes / any = no");
        if (Console.ReadLine() == "y")
        {
            System.Console.WriteLine("Wie soll dein Tamagotchi heißen?");
            pet = new Pet(Console.ReadLine());
            time = new Thread(pet.SimulateTime);
            visual = new Thread(new ParameterizedThreadStart(petModel.Tamagotchi));
            time.Start();
            visual.Start(pet);

        }
        else
        {
            System.Console.WriteLine("Tschüss!");
            Environment.Exit(0);

        }
    }
    if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out control))
    {
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

            case 7:
                pet.WakeUp();
                break;

            default:
                break;
        }
    }


}

