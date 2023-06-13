using System.ComponentModel.DataAnnotations;
using System.Reflection;


namespace MoodAnalyzer
{
    internal class Program
    {

        static void Main(string[] args)
        {

            try
            {
                MoodAnalyser moodAnalyser = MoodAnalyserFactory.CreateMoodAnalyser("InvalidClassName");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
    }
}