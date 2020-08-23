using System;
using System.Collections.Generic;
using System.Text;

namespace ForestFire
{
    public class BuringFunction
    {
        public void Buring(Tree tree) 
        {
            if (tree.TreeStatus == TreeSituation.Burning)
            {
                if (tree.HealthPoints > 0)
                {
                    tree.HealthPoints--;
                }
                else
                {
                    tree.TreeStatus = TreeSituation.Dead;
                }
            }
            else if (tree.TreeStatus == TreeSituation.Healthy)
            {
                tree.TreeStatus = TreeSituation.Burning;
            }
        }
    }
}
