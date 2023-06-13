using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MoodAnalyzer
{
    
    public class MoodAnalyser
    {
        public string mood;
        public MoodAnalyser()
        {
            mood = "Unknown";
        }

        public bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            MoodAnalyser other = (MoodAnalyser)obj;

            return mood == other.mood;
        }





   
     }
}