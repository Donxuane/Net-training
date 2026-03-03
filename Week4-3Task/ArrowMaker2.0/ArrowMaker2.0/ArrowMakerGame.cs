namespace ArrowMaker2._0;

public class ArrowMakerGame
{
    public void GameLogic()

    {

        Console.WriteLine("Below will be questions for building arrow. Please input data when asked!");


        Arrow myarrow = new Arrow("DefaultArrow", 0, "defaultFeather");

        

        Console.WriteLine("Enter arrowHead:");

        DefineArrowHead(myarrow);


        Console.Write("Enter arrowStringLenth: ");
        DefineStringLenght(myarrow);

        Console.Write("Enter arrowFeather: ");
        DefineArrowFeather(myarrow);


    }


    private void DefineArrowHead(Arrow myarrow)
    {
        bool arrowHeadIsSet = false;
        while (!arrowHeadIsSet)
        {

            Console.WriteLine("Enter number 0 - Steel, 1 - wood, 2 - obsidian:");
            string userarrowHead = Console.ReadLine();
            if (userarrowHead == "0")
            {
                myarrow.arrowHead = "Steel";
                arrowHeadIsSet = true;
            }
            else if (userarrowHead == "1")
            {
                myarrow.arrowHead = "Wood";
                arrowHeadIsSet = true;
            }
            else if (userarrowHead == "2")
            {
                myarrow.arrowHead = "Obsidian";
                arrowHeadIsSet = true;
            }
            else
            {
                Console.WriteLine("Wrong number please read instructions again");
            }
        }
    }

    private void DefineStringLenght(Arrow myarrow)
    {
        while (true)
        {
            int userarrowStringLength = Convert.ToInt32(Console.ReadLine());


            if (userarrowStringLength >= 60 && userarrowStringLength <= 100)
            {
                myarrow.arrowStringLength = userarrowStringLength;
                break;
            }
            else
            {
                Console.WriteLine("Length should between 60-100 : ");
            }
        }
    }

    private void DefineArrowFeather(Arrow myarrow)
    {
        bool arrowfeatherIsSet = false;
       

        while (!arrowfeatherIsSet)

        {
            string userarrowFeather = (Console.ReadLine());

            if (userarrowFeather == "0")
            {
                myarrow.arrowfeather = "plastic";
                arrowfeatherIsSet = true;
            }
            else if (userarrowFeather == "1")
            {
                myarrow.arrowfeather = "Turkey feather";
                arrowfeatherIsSet = true;
            }
            else if (userarrowFeather == "2")
            {
                myarrow.arrowfeather = "Goose feather";
                arrowfeatherIsSet = true;
            }
            else
            {
                Console.WriteLine("Wrong number please read instructions again");

            }

            myarrow.PrintInfo();
            Console.WriteLine(myarrow.GetCost());

        }
    }
}
