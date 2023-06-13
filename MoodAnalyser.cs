using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoodAnalyzer
{
    enum mood
    {
        Null, Empty
    }
    public class MoodAnalyser
    { 
        public string AnalyzeMood(string message)
        {
            if(message == mood.Null.ToString())
            {
                throw new MoodAnalyserException("mood is Null");
            }
            if (message == mood.Empty.ToString())
            {
                throw new MoodAnalyserException("Empty mood");
            }
            return null;
        }






    }

}