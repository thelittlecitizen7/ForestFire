using ForestFire.factory;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ForestFire
{
    public class Forest
    {
        public static Random rnd { get; set; }
        public Tree[,] Trees { get; set; }
        public int H { get; set; }

        public int W { get; set; }
        public Forest(int h , int w)
        {
            rnd = new Random();
            H = h;
            W = w;
            Trees = new Tree[h, w];
            initAllTrees();
        }

        private void initAllTrees() 
        {
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    Trees[i, j] = new Tree(new BuringFunction(), 5);
                    Trees[i, j].SetStatusTree(TreeSituation.Healthy);
                }
            }
        }


        public void CalcForest()
        {
            PrintAllTree();
        }

        public void PrintAllTree() 
        {
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    Console.Write(GetMarkByTreeStatusFactory.GetMarkFactiry(Trees[i,j]));
                }
                Console.WriteLine(Environment.NewLine);
            }
        }

        public void BurnTree(int row , int column) 
        {
            Trees[row, column].TreeStatus = TreeSituation.Burning;
        }


        public void ChanceToComunicate() 
        {
            for (int i = 0; i < H - 1; i++)
            {
                for (int j = 0; j < W - 1; j++)
                {
                    int number = rnd.Next(1, 101);
                    if (number < 70) 
                    {
                        Trees[i + 1, j + 1].Subsribe(Trees[i, j]);
                    }
                }
            }
        }

        public void Run() 
        {
            ChanceToComunicate();
            Console.WriteLine("Please enter the H");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the W");
            int w = int.Parse(Console.ReadLine());

            
            BurnTree(h, w);

            PrintAllTree();

        }
    }
}
