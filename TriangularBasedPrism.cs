using System;

namespace Template_Method
{
    class TriangularBasedPrism : RegularPrism
    {
        public override double GetBaseEdgeLength()
        {
            double radians1 = 60*(Math.PI/180);


            double x = Math.Tan(radians1) * RadiusBaseInscribedCircle;

            return 2*x;
            
            
        }
        public override double GetBaseArea(double edge)
        {
            double radians2 = 60*(Math.PI/180);
            double y = Math.Tan(radians2) * (edge/2);
            

            return (edge*y)/2;
        }
        public override double GetLateralArea(double baseL)
        {
            return Height*baseL*3;
        }
    }
}