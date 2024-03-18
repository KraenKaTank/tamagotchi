

using Tamagotchi;

class LinuxPet :PetModel
{

  GUI gui = new GUI();

  public override void Tamagotchi(object obj)
  {
    Pet pet = (Pet)obj;

    while(pet.Alive){
      Thread.Sleep(1000);

      if (pet.Age <= 0.5)
      {
        Console.Clear();

        System.Console.WriteLine(@"
      
                .-~-.  
              .'     '.           
             /         \          
            :           ; 
            |           |        
            :           :             
             \         /             
              `.     .'          
                `~~~`   ");
      }
      if (pet.Age >= 0.5 && pet.Age < 0.8)
      {

        Console.Clear();

        System.Console.WriteLine(@" 
           _..._
         .'     '.
        /  _   _  \
        | (o)_(o) |
         \(     ) / 
         / '._.'  \
        |\   /\/ \/|   ,_
        ; \/`     '; , \_',
         \        /
          '.    .'    /`.
            `~~` , /\ ``
                .  `");
      }

      if (pet.Age > 0.8 && pet.Age < 2)
      {

        Console.Clear();

        System.Console.WriteLine(@"

                         _..._
                       .'     '.
                      /  _   _  \
                      | (o)_(o) |
                       \(     ) /
                       //'._.'\ \
                      //   .   \ \
                     ||   .     \ \
                     |\   :     / |
                     \ `) '   (`  /_
                  _)``^.____,.'^` (_
                  )     )'--'(     (
                  '---`      `---`");
      }

      if (pet.Age >= 2)
      {

        Console.Clear();


        System.Console.WriteLine(@"         
                          _nnnn_
                         dGGGGMMb
                         @p~qp~~qMb
                         M|@||@) M|
                         @,----.JM|
                        JS^\__/  qKL
                      dZP        qKRb
                     dZP          qKKb
                    fZP            SMMb
                    HZM            MMMM
                    FqM            MMMM
                 __| '.         |\dS'qML
                 |    `.        | `' \Zq
                _)      \.___., |     .'
                 \____   )MMMMMP|   .'
                      `-'       `--'
                      ");
      }
      gui.GUIBuild(pet);




    }
  }
}
