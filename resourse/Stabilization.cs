using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SergxloveCoin.resourse
{
    internal class Stabilization
    {
        public string stabilizationFloatToString(string value, int quantityDiggit)
        {
            string result = "";
            bool isHavePoint = false;
            int countDiggit = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '.' || value[i] == ',')
                {
                    if (quantityDiggit == 0)
                    {
                        return result;
                    }
                    isHavePoint = true;
                    result += value[i];
                }
                else
                {
                    if (isHavePoint)
                    {
                        result += value[i];
                        countDiggit++;
                        if (countDiggit == quantityDiggit)
                        {
                            return result;
                        }
                    }
                    else
                    {
                        result += value[i];
                    }
                }
            }
            while (countDiggit <= quantityDiggit)
            {
                result += '0';
            }
            return result;
        }
        public string stabilizationFloatToString(float value, int quantityDigit)
        {
            string result = "";
            string valueStr = value.ToString();
            bool isHavePoint = false;
            int countDigit = 0;
            for( int i = 0;i<valueStr.Length;i++)
            {
                if (valueStr[i] == '.' || valueStr[i] ==  ',')
                {
                    if(quantityDigit == 0)
                    {
                        return result;
                    }
                    isHavePoint = true;
                    result += valueStr[i];
                }
                else
                {
                    if (isHavePoint) 
                    {
                        result+= valueStr[i];
                        countDigit++;
                        if(countDigit == quantityDigit)
                        {
                            return result;
                        }
                    }
                    else
                    {
                        result += valueStr[i];
                    }
                }
            }
            while(countDigit <= quantityDigit)
            {
                result += '0';
            }
            return result;
        }
    }
}
