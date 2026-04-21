using Generics;

Generics12 generics = new Generics12();

generics.PrintInfo<int>(12);

generics.PrintInfo<TestClass>(new TestClass
{
    Description = "fdsdsd",
    Id = 1,
    Name = "Test"
});


generics.UpdateTabele(new TestClass
{
    Description = "fdsdsd",
    Id = 1,
    Name = "Test"
});
