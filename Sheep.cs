public class Sheep : Animal {

    public Sheep()
    {
        System.Console.WriteLine("Sheep is made.");
    }
    private Sheep(Sheep sheep) {
        // deep-copy sheep HERE !!!
    }
    public Animal Clone() {

        System.Console.WriteLine("Sheep is being made through copy...");

        // deep copy
        Sheep clonedSheep = new Sheep(this);

        // shallow copy
        // Sheep clonedSheep = this;

        return (Animal)clonedSheep;

    }

    public override string ToString()
    {
        return "Printing Sheep.";
    }
}