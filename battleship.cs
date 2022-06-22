

using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a grid
            int[,] grid = new int[8, 8];

            // hitcounter keeps the score
            int hitcounter = 0;

            // display grid that disguises the answer grid
            int[,] grid2 = new int[8, 8];
            
            // winning positions
            bool game = true;

            grid[3, 7] = 1;
            grid[7, 7] = 1;
            grid[1, 4] = 1;


            //for every row that's less than 8, add 1
            for (int row = 0; row < 8; row++)
            {
                //for every column that's less than 8, add 1
                for (int column = 0; column < 8; column++)
                {
                    Console.Write(grid2[row, column]);
                }
                Console.WriteLine();
            }
            //create a boolean to set game true under following conditions
            while (game == true)
            {
                //ask which row to shoot
                Console.WriteLine("Which row number would you like to shoot?");
                int rowchoice = Convert.ToInt32(Console.ReadLine());

                //ask which column to shoot
                Console.WriteLine("Which column number would you like to shoot?");
                int colchoice = Convert.ToInt32(Console.ReadLine());


                //if user picks cooridniates (3,7) write hit
                if (rowchoice == 3 && colchoice == 7)
                {
                    Console.WriteLine("hit");
                    // hitcounter++ is taking score- until score adds up to 3
                    hitcounter++;
                    grid2[3, 7] = 1; 

                    // just a display line
                    Console.WriteLine("---------------------------------------------------");

                    //refresh display grid2
                    for (int row = 0; row < 8; row++)
                    {
                        for (int column = 0; column < 8; column++)
                        {
                            Console.Write(grid2[row, column]);
                        }
                        Console.WriteLine();
                    }
                }
                //if user picks cooridniates (7,7) write hit
                else if (rowchoice == 7 && colchoice == 7)
                {
                    Console.WriteLine("hit");
                    //hitcounter++ is taking score- until score adds up to 3
                    hitcounter++;
                    grid2[7, 7] = 1;

                    // just a display line
                    Console.WriteLine("----------------------------------------------------");

                    //refresh display grid2
                    for (int row = 0; row < 8; row++)
                    {
                        for (int column = 0; column < 8; column++)
                        {
                            Console.Write(grid2[row, column]);
                        }
                        Console.WriteLine();
                    }
                }
                //if user picks cooridniates (1,4) write hit
                else if (rowchoice == 1 && colchoice == 4)
                {
                    Console.WriteLine("hit");
                    //hitcounter++ is taking score- until score adds up to 3
                    hitcounter++;
                    grid2[1, 4] = 1;

                    // just a display line
                    Console.WriteLine("-----------------------------------------------------");

                    //refresh display grid2
                    for (int row = 0; row < 8; row++)
                    {
                        for (int column = 0; column < 8; column++)
                        {
                            Console.Write(grid2[row, column]);
                        }
                        Console.WriteLine();
                    }
                }
                //letting the user know that they're near the target
                else if ((rowchoice == 3 + 1 || rowchoice == 3 - 1) && (colchoice == 7 + 1 || colchoice == 7 - 1))
                {
                    Console.WriteLine("You're close!");
                }
                //letting the user know that they're near the target
                else if ((rowchoice == 7 + 1 || rowchoice == 7 - 1) && (colchoice == 7 + 1 || colchoice == 7 - 1))
                {
                    Console.WriteLine("You're close!");
                }
                //letting the user know that they're near the target
                else if ((rowchoice == 1 + 1 || rowchoice == 1 - 1) && (colchoice == 4 + 1 || colchoice == 4 - 1))
                {
                    Console.WriteLine("You're close!");
                }
                else
                {

                    Console.WriteLine("miss");
                }
                //if score = 3 or more user wins
                if (hitcounter >= 3)
                {
                    //quit boolean
                    game = false;
                    Console.WriteLine("That's game. you win... i guess :(");
                }
            }

        }
    }
}