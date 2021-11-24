using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSampe
{
    class Triangle
    {
        private float bottom;
        private float height;
        public Triangle(float B, float H)
        {
            this.bottom = B;
            this.height = H;
        }
        public float GetSurface()
        {
            return bottom * height / 2;
        }
    }
}