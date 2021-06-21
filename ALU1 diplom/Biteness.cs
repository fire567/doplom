using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU1_diplom
{
    class Biteness
    {
        public String changeStr;
        public int biteness;

        public String changedString(String changeStr, int biteness)
        {
            for(int i = 0; i < biteness; i++)
            {
                changeStr += String.Concat("0");
            }
            return changeStr;
        }
    }
}
