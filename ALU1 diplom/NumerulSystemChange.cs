using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU1_diplom
{
    class NumerulSystemChange
    {
        public String num;
        public int decNum;
        public int bitenessNum;

        public String changeToDecimalSystem (String num)
        {
            int currentValue = 0;
            int powNum = 0;
            for(int i = num.Length - 1; i >= 0; i--)
            {
                
                currentValue += Convert.ToInt32((num[i]).ToString()) * Convert.ToInt32(Math.Pow(2, powNum));
                powNum++;
            }
            
            return currentValue.ToString();
        }

        public String changeToBinarySystem(int decNum, int bitenessNum)
        {
            
            int currentValue = decNum;
            String remainder = "";
            String formatStr = "";
            String reverse = "";
            int res = 0;
            while (currentValue > 0)
            {
                
                res = currentValue / 2;
                remainder += String.Concat(currentValue % 2);
                currentValue = res;
                
            }

            for (int i = 0; i < bitenessNum; i++)
            {
                if (remainder.Length - 1 >= i)
                {
                    
                    formatStr += String.Concat(remainder[i]);
                }
                else formatStr += String.Concat("0");
              
            }
            
            for (int i = formatStr.Length - 1; i >= 0; i--)
            {
                
                reverse += String.Concat(formatStr[i]);
            }
            
            return reverse;
        }
    }
}
