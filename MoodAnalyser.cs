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
            if(mood.Contains("I am in Sad mood"))
            {
                return SAD;
            }
            if(mood.Contains("I am in Any Mood"))
            {
                return HAPPY;
            }
            return null;
        }
    }   
    
}