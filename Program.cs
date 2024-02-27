using System.Runtime.CompilerServices;
using Tamagotchi;




Pet pet = new Pet("Pascal");
DateTime currentTime = DateTime.Now;

Timer timer = new Timer(GameOnGoing, null, 0, 2000);

Console.ReadLine();

static void GameOnGoing(object state){

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