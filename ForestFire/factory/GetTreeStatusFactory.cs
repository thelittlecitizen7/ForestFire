using System;
using System.Collections.Generic;
using System.Text;

namespace ForestFire.factory
{
    public class GetTreeStatusFactory
    {
        public TreeSituation GetFactoryStatus(string mark)
        {
            switch (mark)
            {
                case "0":
                    return TreeSituation.Healthy;
                case "X":
                    return TreeSituation.Burning;
                case ".":
                    return TreeSituation.Dead;
                default: return default;

            }
        }
    }
}
