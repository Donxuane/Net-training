//int age = 18;

//switch (age)
//{
//    case < 18:
//        {
//            Console.WriteLine("Minor");
//            break;
//        }
//    case 18:
//        {
//            Console.WriteLine("18");
//            break;
//        }
//    default:
//        {
//            Console.WriteLine("No");
//            break;
//        }
//}

//int[] ages = [6,5,6,7,8,9];

//foreach (int ag in ages)
//{
//    Console.WriteLine(ag);
//    if (ag == 6)
//        ages[2] = 15;
//}

//Console.WriteLine("test");

//for (int i = ages.Length-1;i >= 0; i--)
//{
//    Console.WriteLine($"index of value : {i}");
//    Console.WriteLine($"value: {ages[i]}");
//}
//char symbol = 'y';
//string text = "ytegeehcdjcdcc";

//foreach (char c in text)
//{
//    Console.WriteLine(c);
//}

//for (int i = 0; i < text.Length; i++)
//{
//    Console.WriteLine(text[i]);
//}

//int index = 0;

//while (index < text.Length)
//{
//    Console.WriteLine("test");

//    int tes;

//    index++;
//}

//string[] arrayText = ["test1", "test2"];

//foreach (string s in arrayText)
//{
//    Console.WriteLine(s);
//}


using System.Text;

string testString1 = "qwer";
string[] stringArray = ["test12", "test123", "test124", "test125"];
double[] doubleArray = [12.3, 45.67, 89.12, 11];

char[] arrayChar = ['t','e','s','t'];

StringBuilder stringBuilder = new StringBuilder();

foreach(char c in arrayChar)
{
    Console.WriteLine(c);
    stringBuilder.Append(c);
}

Console.WriteLine(stringBuilder.ToString());
