// See https://aka.ms/new-console-template for more information

Sheep sally = new Sheep();

Sheep clonedSheep = (Sheep) CloneFactory.GetClone(sally);

System.Console.WriteLine(sally);

System.Console.WriteLine(clonedSheep);

System.Console.WriteLine($"Sally hash: { sally.GetHashCode() }");
System.Console.WriteLine($"clonedSheep hash: { clonedSheep.GetHashCode() }");
