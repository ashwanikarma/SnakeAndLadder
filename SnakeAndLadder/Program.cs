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

            Random random = new Random();

            while (position <= 100)
            {
                int temp = position;

                int die = random.Next(1, 7);
                Console.WriteLine("Player rolls a die and get : {0}", die);

                int check = random.Next(0, 3);

                if (check == 0)
                {
                    Console.WriteLine("No Play");
                }
                else if (check == 1)
                {
                    Console.WriteLine("Player Moves Ahead by {0} from ladder", die);
                    position += die;
                }
                else
                {
                    Console.WriteLine("Player Moves Behind by {0} from Snake", die);
                    position -= die;
                }
                if (position < 0)
                {
                    position = 0;
                }
                else if (position > 100)
                {
                    position = temp;
                } 
                Console.WriteLine("Player current position is : "+position);
            }
            Console.WriteLine("Current Position is : {0}", position);
        }
    }
}