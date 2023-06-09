namespace MoodAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                string result = moodAnalyser.AnalyzeMood();
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  

            MoodAnalyser moodAnalyser1 = new MoodAnalyser("I am in Happy Mood");
            string result1 = moodAnalyser1.AnalyzeMood();
            Console.WriteLine(result1);
        }
    }
}