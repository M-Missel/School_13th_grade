using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knn
{
    class FeatureCount
    {
        private int featureNum;
        private int count;

        public FeatureCount(int featureNum, int count) {
            this.featureNum = featureNum;
            this.count = count;
        }

        public int getFeatureNum()
        {
            return featureNum;
        }

        public int getCount()
        {
            return count;
        }
    }
}
