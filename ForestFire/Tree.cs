using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ForestFire
{
    public class Tree
    {
        public int HealthPoints { get; set; }

        public event Action<Tree> Trees;

        private BuringFunction _buringFunction { get; set; }

        public TreeSituation TreeStatus { get; set; }

        public Tree(BuringFunction buringFunction ,int healthPoints)
        {
            HealthPoints = healthPoints;
            _buringFunction = buringFunction;
        }


        public void SetStatusTree(TreeSituation status) 
        {
            TreeStatus = status;
            if (TreeStatus == TreeSituation.Burning) 
            {
                Trees?.Invoke(this);
            }
        }

        public void Subsribe(Tree tree) 
        {
            tree.Trees += _buringFunction.Buring;
        }

        public void UnSubsribe(Tree tree)
        {
            tree.Trees -= _buringFunction.Buring;
        }
    }
}
