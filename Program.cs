using System.ComponentModel.DataAnnotations;
using System.Reflection;


namespace MoodAnalyzer
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            string moodinput = "Null";
            string moodinput1 = "Empty";

            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                string mood = moodAnalyser.AnalyzeMood(moodinput);

            }
            catch (MoodAnalyserException ex)
            {
                Console.WriteLine(ex.Message);

            }

            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                string mood1 = moodAnalyser.AnalyzeMood(moodinput1);

            }
            catch (MoodAnalyserException ex)
            {
                Console.WriteLine(ex.Message);

            }




        }
    }
}