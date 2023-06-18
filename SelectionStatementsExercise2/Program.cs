namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What's your favorite subject in school?");
            var answer = Console.ReadLine();

            switch (answer.ToLower())
            {
                case "math":
                    Console.WriteLine("I think I can tell");
                    break;
                case "computer science":
                    Console.WriteLine("Bit on the nose, don't you think?");
                    break;
                case "english":
                    Console.WriteLine("Oo, someone's feeling pretentious");
                    break;
                case "gym":
                    Console.WriteLine("Oh I can definitely tell");
                    break;
                case "geography":
                    Console.WriteLine("Name every country right now");
                    break;
                default:
                    Console.WriteLine("yeah, I didn't write a response for that, pick again bozo");
                    break;
            }
        }
    }
}