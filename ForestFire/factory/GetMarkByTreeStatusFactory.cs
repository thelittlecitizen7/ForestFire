using System;
using System.Collections.Generic;
using System.Text;

namespace ForestFire.factory
{
    public class GetMarkByTreeStatusFactory
    {
        public static string GetMarkFactiry(Tree tree)
        {
            switch (tree.TreeStatus)
            {
                case TreeSituation.Healthy:
                    return "o";
                case TreeSituation.Burning:
                    return "X";
                case TreeSituation.Dead:
                    return ".";
                default: return null;
            }
        }
    }
}
