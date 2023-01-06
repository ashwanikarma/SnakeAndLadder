namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake & Ladder Simulator");
            int player1=0, player2=0;
            int NumberOfTimes_Dice1 = 0, NumberOfTimes_Dice2 = 0 ;
            int check;

            Console.WriteLine("Welcome Player 1");
            Console.WriteLine("Welcome Player 2");
            Console.WriteLine("Player 1 is at position : " + player1);
            Console.WriteLine("Player 2 is at position : " + player2);

            Random random = new Random();

            while (player1 < 100 && player2 < 100)
            {                                            

                //player1

                while (true)
                {
                    if (player1 == 100)
                    {
                        break;
                    }
                    int die1 = random.Next(1, 7);
                    Console.WriteLine("Player1 rolls a die and get : {0}", die1);
                    NumberOfTimes_Dice1++;
                    if (player1 < 0)
                    {
                        player1 = 0;
                    }
                    check = random.Next(0, 3);

                    if (check == 0) //for No play
                    {
                        Console.WriteLine("No Play");
                        Console.WriteLine("Player1 current position is : " + player1); //checks position after every die roll
                        break;
                    }
                    else if (check == 1) //for Ladder
                    {
                        Console.WriteLine("Player1 Moves Ahead by {0} from ladder", die1);
                        player1 += die1;
                        Console.WriteLine("Player1 current position is : " + player1); //checks position after every die roll
                        if (player1 > 100)
                        {
                            player1 -= die1;

                        }
                        if (player1 == 100)
                        {
                            break;
                        }
                        continue;
                    }
                    else // for snake
                    {
                        Console.WriteLine("Player1 Moves Behind by {0} from Snake", die1);
                        player1 -= die1;

                        Console.WriteLine("Player1 current position is : " + player1); //checks position after every die roll
                        break;
                    }                          
                }
                //player 2

                while (true)
                {
                    if(player2 == 100)
                    {
                        break;
                    }
                    int die2 = random.Next(1, 7);
                    NumberOfTimes_Dice2++;
                    Console.WriteLine("Player2 rolls a die and get : {0}", die2);
                    if (player2 < 0)
                    {
                        player2 = 0;
                    }
                    check = random.Next(0, 3);

                    if (check == 0) //for No play
                    {
                        Console.WriteLine("No Play");
                        Console.WriteLine("Player2 current position is : " + player2); //checks position after every die roll
                        break;
                    }
                    else if (check == 1) //for Ladder
                    {
                        Console.WriteLine("Player2 Moves Ahead by {0} from ladder", die2);
                        player2 += die2;
                        if (player2 > 100)
                        {
                            player2 -= die2;

                        }
                        if (player1 == 100)
                        {
                            break;
                        }
                        Console.WriteLine("Player2 current position is : " + player2); //checks position after every die roll
                        continue;
                    }
                    else // for snake
                    {
                        Console.WriteLine("Player2 Moves Behind by {0} from Snake", die2);
                        player2 -= die2;
                        Console.WriteLine("Player2 current position is : " + player2); //checks position after every die roll
                        break;
                    }                                
                }
            }
            if ( player1 == 100 )
            {
                Console.WriteLine("Number of times the dice is Thrown for player 1 to win is {0}", NumberOfTimes_Dice1);
                Console.WriteLine("Current Position of player 1 is : {0}", player1);
            } 
            else if ( player2 == 100 ) 
            {
                Console.WriteLine("Number of times the dice is Thrown for player 2 to win is {0}", NumberOfTimes_Dice2);
                Console.WriteLine("Current Position of player 2 is : {0}", player2);
            }
        }
    }
}