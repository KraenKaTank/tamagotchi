
using System.Xml.Schema;

class PetModel{

    public PetModel() {

    }

    public PetModel(int value){
        if(value == 1){
            new LinuxPet();
        }
    }

    
}