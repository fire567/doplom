using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU1_diplom
{
    class Sequence
    {
        String DRActive = "";
        String DLActive = "";
        String Shina = "";
        String DRValue = "0";
        String DLValue = "0";
        String DRSActive = "";
        String DRSValue = "0";
        String DLSValue = "0";
        String DLSActive = "";
        String R = "00000000";
        String S = "00000000";
        String Q = "00000000";
        String F = "00000000";
        String C = "00000000";
        String D = "00000000";

        public void sequenceArr(bool[] steps)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                if(i == 0 && steps[i] == true)
                {

                }
            }
        }
    }
}
