using Oop;

Dog dog = new();

dog.PrintDogNoice();

Cat cat = new();
cat.PrintCatNoice();

IAnimal animal = new Cow();
animal.MakeNoice();

IAnimal animalZebra = new Zebra();

animalZebra.MakeNoice();

MainAnimal mainAnimal = new Lion();

mainAnimal.PrintInfo();

//Encapsulation, Pholymorphysm, Abstraction, Inharitance