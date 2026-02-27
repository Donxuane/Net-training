using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom.objects.task
{

    public class ArrowMakerGame
    {
        public void GameLogic()

        {

            Console.WriteLine("Below will be questions for building arrow. Please input data when asked!");


            Arrow myarrow = new Arrow("DefaultArrow", 0, "defaultFeather");

            bool arrowHeadIsSet = false;

            Console.WriteLine("Enter arrowHead:");

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


            Console.Write("Enter arrowStringLenth: ");

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

            bool arrowfeatherIsSet = false;
            Console.Write("Enter arrowFeather: ");

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


}
