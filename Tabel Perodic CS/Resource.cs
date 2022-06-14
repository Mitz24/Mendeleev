using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabel_Perodic_CS
{
    static class Resource
    {
        public static float FindMolecularMass(string symbol)
        {
            List<Element> elements;
            elements = Element.ReturElementDB();

            if (symbol.Length <= 2)
            {
                for(int i = 0; i < 118; i++)
                {
                    if (elements[i].Simbol.Contains(symbol))
                        return elements[i].MasaMolara;
                }
                return -1;
            }  
            else
                return -1;
        }

    }
}
