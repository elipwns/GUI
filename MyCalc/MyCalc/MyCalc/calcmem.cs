using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc
{
    class calcmem
    {
        float mem;
        public calcmem()
        {
            mem = 0;
        }
        public float Getmem()
        {
            return mem;
        }
        public void Setmem(float newmem)
        {
            mem = newmem;
        }
        public void Clear()
        {
            mem = 0;
        }
    }
}
