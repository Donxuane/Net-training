using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom.objects.task
{

    public class Arrow
    {
        public string arrowHead;
        public int arrowStringLength;
        public string arrowfeather;

        public Arrow(string arrowHead, int arrowStringLength, string arrowfeather)
        {
            this.arrowHead = arrowHead;
            this.arrowStringLength = arrowStringLength;
            this.arrowfeather = arrowfeather;

            Console.WriteLine("new object created");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{arrowHead}, {arrowStringLength}, {arrowfeather}");
        }

        public float GetCost()
        {
            float cost = 0;
            if (arrowHead == "Steel")
            {
                cost += 10;
            }
            else if (arrowHead == "Wood")
            {
                cost += 3;

            }
            else if (arrowHead == "Obsidian")
            {
                cost += 2;
            }

            if (arrowfeather == "Plastic")
            {
                cost += 10;
            }
            else if (arrowfeather == "Turkey feather")
            {
                cost += 5;
            }
            else if (arrowfeather == "Goose feather")
            {
                cost += 3;
            }

            cost += arrowStringLength * (float)0.05;

            return cost;

        }
    }
}
