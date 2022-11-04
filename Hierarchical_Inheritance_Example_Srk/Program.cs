// See https://aka.ms/new-console-template for more information
using Hierarchical_Inheritance_Example_Srk;

Console.WriteLine("Hello, World!");


Snake_Sound objSnake = new Snake_Sound();
objSnake.CobraSound();
objSnake.DogSound();
objSnake.soundOfHumans = "Human Snake";
Console.WriteLine(objSnake.soundOfHumans);
Console.WriteLine();

Bird_Sound objBird=new Bird_Sound();
objBird.ParrotSound();
objBird.DogSound();
objBird.soundOfHumans = "Human Bird";
Console.WriteLine(objBird.soundOfHumans);
Console.WriteLine();

Animal_Sound objAnimal = new Animal_Sound();
objAnimal.DogSound();
objAnimal.soundOfHumans = "Human Animal";
Console.WriteLine(objAnimal.soundOfHumans);