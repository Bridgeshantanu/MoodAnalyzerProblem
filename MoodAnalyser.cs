using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string HAPPY = "HAPPY";
        public string SAD = "SAD";
        public string AnalyzeMood(string mood)
        {
            if (mood.ToLower().Contains("i am in sad mood"))
            {
                return SAD;
            }
            return null;
        }
    }   
    
}