package homework2;

public class AnimalInformation {
    public static String animalType;
    public static int animalWeightInKilos;
    public static String animalID;

    public AnimalInformation(String animalType, int animalWeightInKilos, String animalID) {
        this.animalType = animalType;
        this.animalWeightInKilos = animalWeightInKilos;
        this.animalID = animalID;
    }

    public String AnimalSound(String animalType) {
        this.animalType = animalType;

        if (animalType == "Pig") {
            return "Grooh-Grooh...";
        } else if (animalType == "Cow") {
            return "Moo-Moo...";
        } else if (animalType == "Sheep") {
            return "Bee-Bee...";
        } else {
            return "No sound info for this animal!";
        }
    }
}
