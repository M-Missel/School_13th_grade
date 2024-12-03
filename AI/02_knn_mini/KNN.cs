using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knn
{
    class KNN
    {
        private List<PointDistance> knnList;
        private List<FeatureCount> featureCountList;

        public KNN(int k, Punkt p, List<Punkt> points, int numFeatures)
        {
            List<PointDistance> distanceList = calcDistanceList(p, points);
            extraktkNN(distanceList, k);
            countFeature(numFeatures);
        }

        private List<PointDistance> calcDistanceList(Punkt p, List<Punkt> points)
        {
            List<PointDistance> distanceList = new List<PointDistance>();
            
            for (int i = 0; i < points.Count -1; i++)
            {
                distanceList.Add(new PointDistance(points[i], calcSquareDistance(p, points[i])));
            }

            distanceList.Sort(distanceComparer);

            return distanceList;
        }

        private double calcSquareDistance(Punkt p1, Punkt p2)
        {
            return (Math.Pow(p2.getX() - p1.getX(), 2) + Math.Pow(p2.getY() - p1.getY(), 2));
        }

        private int distanceComparer(PointDistance pd1, PointDistance pd2)
        {
            switch (pd1)
            {
                case PointDistance x when x.getDistance() > pd2.getDistance():
                    return 1;
                case PointDistance x when x.getDistance() < pd2.getDistance():
                    return -1;
                default:
                    return 0;
            }
        }

        private void extraktkNN(List<PointDistance> distanceList, int k)
        {
            knnList = distanceList.GetRange(0,k);
        }

        private void countFeature(int numFeature)
        {
            featureCountList = new List<FeatureCount>();
            int anzahl;
            for (int i = 0; i < numFeature; i++) {
                anzahl = knnList.FindAll(
                    pd => pd.getPoint().getFeatureNum() == i
                    ).Count();

                featureCountList.Add(new FeatureCount(i, anzahl));
            }

            featureCountList.Sort(countComparer);
        }

        private int countComparer(FeatureCount fc1, FeatureCount fc2)
        {
            switch (fc1)
            {
                case FeatureCount x when x.getCount() > fc2.getCount():
                    return -1;
                case FeatureCount x when x.getCount() < fc2.getCount():
                    return 1;
                default:
                    return 0;
            }
        }

        public List<PointDistance> getKNNList()
        {
            return knnList;
        }

        public List<FeatureCount> getFeatureCountList()
        {
            return featureCountList;
        }
    }
}
