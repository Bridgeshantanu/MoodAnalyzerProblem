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
        public static MoodAnalyser CreateMoodAnalyser(string mood)
        {
            Type type = typeof(MoodAnalyser);

            ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
            if (constructor == null)
            {
                throw new MoodAnalyserException("No such constructor error: MoodAnalyser(string)");
            }

            MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(new object[] { mood });

            return moodAnalyser;
        }
    }
}
