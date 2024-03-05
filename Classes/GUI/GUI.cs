using Tamagotchi;

public class GUI{

    public void GUIBuild(Object obj){
        Pet pet = (Pet) obj;
        pet.ShowStats();
    }
    public void GUIOptions(){
        System.Console.Write("Füttern [1] | Spielen [2] | Schlafen [3] | Medizin [4] | Duschen [5] | Toilette [6] ");
    }
}