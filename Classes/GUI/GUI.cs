using Tamagotchi;

public class GUI{


    public void GUIBuild(Object obj){
        Pet pet = (Pet) obj;
        pet.ShowStats();
        GUIOptions();
        pet.CheckStats();

    }
    public void GUIOptions(){
        System.Console.WriteLine("Füttern [1] | Spielen [2] | Schlafen [3] | Medizin [4] | Duschen [5] | Toilette [6] ");
    }
}