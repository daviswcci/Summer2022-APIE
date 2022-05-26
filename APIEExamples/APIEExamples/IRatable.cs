using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIEExamples
{
    internal interface IRatable
    {
        // method signatures
        public void IncreaseRating(double change); 

        public void DecreaseRating(double change);
    }
}
