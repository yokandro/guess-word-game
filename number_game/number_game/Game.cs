using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_game
{
    class Game
    {
         static int guess;
         static int target;
         static string Input = "";
         static Random RandomNumber = new Random();

        public static void Play()
        {
            target = RandomNumber.Next(10);
            Console.Write("Enter the number:");
            Input = Console.ReadLine();
            {
                if (int.TryParse(Input, out guess))
                {
             
                        if (guess == target)
                        {
                            Console.WriteLine("Congratulations! You guessed!\nThe number that was conceived:" + target + ".");
                            Console.WriteLine("Press enter to try again!");
                            Play();
                            
                        }
                        else
                        {
                             Console.WriteLine("You did not guess!\nThe number that was conceived:" + target + "\nTry again!");
                             Console.WriteLine("Press enter to try again!");
                             Play();      
                         } 
                    }               
                else
                {
                    Console.WriteLine("Please enter a number.");
                    Console.WriteLine("Press enter to continue...");
                }
                
            }
            Console.ReadLine();
        }
            

        }



    }


