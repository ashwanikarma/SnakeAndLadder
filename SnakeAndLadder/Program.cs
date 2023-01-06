namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake & Ladder Simulator");

            int position = 0;

            Console.WriteLine("Welcome Player 1");
            Console.WriteLine("Player 1 is at position : " + position);

            Random random= new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("Player rolls a die and get : {0}", die);

        }
    }
}