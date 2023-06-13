using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    internal class MoodAnalyserFactory
    {
        public static MoodAnalyser CreateMoodAnalyser()
        {
            Type type = typeof(MoodAnalyser);
           
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            if (constructor == null)
            {
                throw new ArgumentException("MoodAnalyser does not have a default constructor.");
            }

            MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(null);

            return moodAnalyser;
        }
    }
}
