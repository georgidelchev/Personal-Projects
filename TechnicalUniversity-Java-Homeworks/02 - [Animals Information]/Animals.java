package homework2;

public class Animals {
    public static void main(String[] args) {
        AnimalInformation animal = new AnimalInformation("Pig", 110, "78487");
        System.out.println("Pig Kilos: " + animal.animalWeightInKilos);
        System.out.println("Pig ID: " + animal.animalID);
        System.out.println("Pig makes: " + animal.AnimalSound(AnimalInformation.animalType));

        System.out.println();

        animal = new AnimalInformation("Cow", 250, "62612");

        System.out.println("Cow Kilos: " + animal.animalWeightInKilos);
        System.out.println("Cow ID: " + animal.animalID);
        System.out.println("Cow makes: " + animal.AnimalSound(AnimalInformation.animalType));

        System.out.println();

        animal = new AnimalInformation("Sheep", 56, "12526");

        System.out.println("Sheep Kilos: " + animal.animalWeightInKilos);
        System.out.println("Sheep ID: " + animal.animalID);
        System.out.println("Sheep makes: " + animal.AnimalSound(AnimalInformation.animalType));
    }
}
