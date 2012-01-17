using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GolfPool_Service
{
    class Helper
    {
        public string ReplaceMoneyString(string inputString)
        {
            string outputString;
            outputString = inputString.Replace("$", "").Replace(",", "");
            return outputString;
        }
    }
}
