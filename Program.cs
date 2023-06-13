using System.ComponentModel.DataAnnotations;
using System.Reflection;


namespace MoodAnalyzer
{
    internal class Program
    {

        static void Main(string[] args)
        {

            MoodAnalyser moodAnalyser1 = MoodAnalyserFactory.CreateMoodAnalyser();
            MoodAnalyser moodAnalyser2 = MoodAnalyserFactory.CreateMoodAnalyser();

            bool isEqual = moodAnalyser1.Equals(moodAnalyser2);

            Console.WriteLine("MoodAnalyser objects equal = " + isEqual);



        }
    }
}