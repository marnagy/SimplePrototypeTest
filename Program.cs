// See https://aka.ms/new-console-template for more information

Sheep sally = new Sheep();
Dog doug = new Dog();

foreach (Animal a in new Animal[]{sally, doug})
{
    Animal clonedAnimal = CloneFactory.GetClone(a);

    System.Console.WriteLine(a);

    System.Console.WriteLine(clonedAnimal);

    System.Console.WriteLine($"Original animal hash: { a.GetHashCode() }");
    System.Console.WriteLine($"Cloned animal hash: { clonedAnimal.GetHashCode() }");

    System.Console.WriteLine();
}


