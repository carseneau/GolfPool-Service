using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GolfPool_Service
{
    class Helper
    {
        public decimal ReplaceMoneyString(string inputString)
        {
            
            decimal outDec;
            decimal.TryParse(inputString.Replace("$", "").Replace(",", ""),out outDec);
                    return outDec;
        }
    }
}
