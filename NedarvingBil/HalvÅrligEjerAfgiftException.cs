using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public class HalvÅrligEjerAfgiftException : Exception
    {

        const string text = "Bilprisen <= 0 eller købsåret er før 2014 ";

        public HalvÅrligEjerAfgiftException()
        : this(text)
        {
        }
        public HalvÅrligEjerAfgiftException(string message)
        : base(message)
        {
        }
        public HalvÅrligEjerAfgiftException(string message, Exception inner)
        : base(message, inner) { }
    

    }
}
