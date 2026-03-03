//უნდა შევქმნა person ტიპის ობიექტი, რომელსაც გავუწერ მახასიათებლებს და განვუსაზღვრაც 2 მეთოდს:
//პირველი მეთოდი დაბეჭდავს პერსონაზე ინფორმაციას, მეროე დააბრუნებს ასაკს.
//person ტიპის ობიექტს კონსტრუქტორიდან ვანიჭებთ მნიშვნელობებს.

using person;

Person InfoToka = new Person("Tornike", "Beradze", 35, "tokatoka12");
InfoToka.PrintInfo();
int tokaAge = InfoToka.GetAge();
Console.WriteLine(tokaAge);
InfoToka.GetEmail("Tornike");
string email = InfoToka.GetEmail("Vakho");
Console.WriteLine(email);
InfoToka.profession("veterinarian");
