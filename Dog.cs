public class Dog : Animal {

    public Dog()
    {
        System.Console.WriteLine("Dog is made.");
    }
    private Dog(Dog dog) {
        // deep-copy Dog HERE !!!
    }
    public Animal Clone() {

        System.Console.WriteLine("Dog is being made through copy...");

        // deep copy
        //Dog clonedDog = new Dog(this);

        // shallow copy
        Dog clonedDog = this;

        return (Animal)clonedDog;

    }

    public override string ToString()
    {
        return "Printing Dog.";
    }
}