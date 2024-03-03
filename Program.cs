using System.Runtime.CompilerServices;
using Tamagotchi;




Pet pet = new Pet("Pascal");
DateTime currentTime = DateTime.Now;
Timer timer = new Timer(TamagotchiEgg, null, 0, 2000);


while(Console.ReadLine() != )

Console.ReadLine();

static void TamagotchiEgg(object state){
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


static void Tamagotchihatched(object state){
  
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

static void TamagotchiBaby(object state){
  
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
static void TamagotchiAdult(object state){

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
 __| '.        |\dS'qML
 |    `.       | `' \Zq
_)      \.___.,|     .'
\____   )MMMMMP|   .'
     `-'       `--'
    ");

}