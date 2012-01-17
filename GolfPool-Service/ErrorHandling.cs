using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GolfPool_Service
{
    public class ErrorHandling
    {
        public List<System.Exception> errors;
        public List<string> stackTraces;
       
        public ErrorHandling()
        {
            errors = new List<System.Exception>();
            stackTraces = new List<string>();
        }

        public void addError(System.Exception e)
        {
            errors.Add(e);
            stackTraces.Add(DateTime.Now.ToString() + e.StackTrace);
        }

        public List<string> getErrorStackTraces()
        {
            return stackTraces;
        }

    }
}
