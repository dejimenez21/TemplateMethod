using System;

namespace Template_Method
{
    abstract class RegularPrism
    {
        public double RadiusBaseInscribedCircle;
        public double Height;

        public double GetPrismArea()
        {
            double edge = GetBaseEdgeLength();
            double baseArea = GetBaseArea(edge);
            double lateralArea = GetLateralArea(edge);

            return (2*baseArea) + lateralArea;
        }

        public abstract double GetBaseEdgeLength();
        public abstract double GetBaseArea(double edge);
        public abstract double GetLateralArea(double baseL);
    }
}