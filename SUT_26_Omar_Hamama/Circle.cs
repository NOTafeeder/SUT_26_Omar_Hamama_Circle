using System;
using System.Collections.Generic;
using System.Text;

namespace SUT_26_Omar_Hamama
{
    class Circle
    {
        float _pi = 3.14f;
        int Radius;
        public Circle(int radius)
        {
            Radius = radius;
        }
        public float GetArea()
        {
            return _pi * Radius * Radius;
        }
    }
}
