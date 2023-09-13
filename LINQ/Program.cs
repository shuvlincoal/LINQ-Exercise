namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Galaga", "Mario", "Tour Of Duty", "HALO", "Donky Kong", "Space Invaders", };

            //videoGames.OrderBy(x => x.Length).ToList();
            var gameTitlesLength = videoGames.OrderBy(x => x.Length);

            foreach (var title in gameTitlesLength)
            {
                Console.WriteLine(title);
            }

        }//method
    }//class
}//namespace
