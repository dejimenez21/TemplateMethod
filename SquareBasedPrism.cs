using System;

namespace Template_Method
{
    class SquareBasedPrism : RegularPrism
    {
        public override double GetBaseEdgeLength()
        {
            return RadiusBaseInscribedCircle*2;
        }
        public override double GetBaseArea(double edge)
        {
            return edge*edge;
        }
        public override double GetLateralArea(double baseL)
        {
            return Height*baseL*4;
        }
    }
}