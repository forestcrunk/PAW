using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3_element
{
    class Element
    {
        int intreg;
        public Element(int fintreg)
        {
            intreg = fintreg;
        }

        public static Element operator++(Element elem)
        {
            elem.intreg++;
            return elem;
        }
        public override string ToString()
        {
            return this.intreg.ToString();
        }
    }

    struct structElement
    {
        int intreg;
        public structElement(int fintreg)
        {
            intreg = fintreg;
        }

        public static structElement operator ++(structElement elem)
        {
            elem.intreg++;
            return elem;
        }
        public override string ToString()
        {
            return this.intreg.ToString();
        }
    }
}
