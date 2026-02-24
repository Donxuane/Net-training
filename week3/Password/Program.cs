string password = "cat";
int tries = 0;

while (true)
{
    Console.WriteLine("enter password");
    string userPassword = Console.ReadLine();
    

if (userPassword == password)
{
    Console.WriteLine("welcome");
    break;

}
else
{
    Console.WriteLine("Wrong password");
    tries++;
    
} 
if (tries == 3)
{ Console.WriteLine("access denied");
    break;
}
  
}