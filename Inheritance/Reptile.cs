using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }        
        public bool EatsInsects { get; set; }
        public string TailColor { get; set; }
        public bool CanRun { get; set; }        
        public bool HasClaws { get; set; }

    }
}
