using System;
using System.Collections.Generic;

public class Animal
{
  public string Name;
  public int Age;
  public string Species;
}

public class Adoption
{
  public static void Main()
  {
    Animal dog = new Animal();
    dog.Name = "Gou";
    dog.Age = 1;
    dog.Species = "Old English Sheepdog";

    Animal cat = new Animal();
    cat.Name = "Mao";
    cat.Age = 1;
    cat.Species = "Scottish Fold";

    Animal panda = new Animal();
    panda.Name = "Xiongmao";
    panda.Age = 2;
    panda.Species = "Bear";

    Animal sloth = new Animal();
    sloth.Name = "Shuta";
    sloth.Age = 3;
    sloth.Species = "Three Toes Sloth";

    List<Animal> AdoptionAgency = new List<Animal>() { dog, cat, panda, sloth };
    foreach(Animal pet in AdoptionAgency)
    {
      Console.WriteLine("Name: " + pet.Name);
      Console.WriteLine("Age: " + pet.Age);
      Console.WriteLine("Species: " + pet.Species);
    }

    Console.WriteLine("Enter maximum age: ");
    string stringMaxAge = Console.ReadLine();
    int maxAge = int.Parse(stringMaxAge);

    List<Animal> AnimalsMatchingSearch = new List<Animal>();

    foreach(Animal pet in AdoptionAgency)
    {
      if (pet.Age < maxAge)
      {
        AnimalsMatchingSearch.Add(pet);
      }
    }
    foreach(Animal pet in AnimalsMatchingSearch)
    {
      Console.WriteLine("Name: " + pet.Name);
      Console.WriteLine("Age: " + pet.Age);
      Console.WriteLine("Species: " + pet.Species);
    }

  }
}
