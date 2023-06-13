using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class MoodAnalyserException : Exception
    {
        public MoodAnalyserException(string msg) : base(msg)
        {
                
        }
    }
}
