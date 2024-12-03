using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knn
{
    class PointDistance
    {
        private double squareDistance;
        private Punkt punkt;

        public PointDistance(Punkt p, double squareDistance) {
            this.punkt = p;
            this.squareDistance = squareDistance;
        }

        public double getDistance() {
            return squareDistance;
        }

        public Punkt getPoint()
        {
            return punkt;
        }
    }
}
