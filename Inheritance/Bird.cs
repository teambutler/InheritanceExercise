using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }
        public string TailColor { get; set; }
        public bool CanFly { get; set; }
        public string BirdNoise { get; set; }
        public double HeadSize { get; set; }


    }
}
