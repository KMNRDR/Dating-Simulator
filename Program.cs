namespace NewSim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, loveinterest;
            char optionIntro, optionDate, optionFright, optionKiss;
            int attempts;

            attempts = 3;
            int i = 0;

            while (i < attempts) 
            {
                attempts--;
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Welcome to the Dating Simulator");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Please enter your name");
                name = Console.ReadLine();
                Console.WriteLine("Welcome " + name + ", please try your best to achieve the best ending.");
                Console.WriteLine("To get you started please enter the name of your potential love interest.");
                loveinterest = Console.ReadLine();
                Console.WriteLine("Thank you, now it's time to enter the game!");
                Console.WriteLine("-------------------------------");

                Console.WriteLine("One day you were wandering the streets of Venice when you came across this beautiful girl.");
                Console.WriteLine("As soon as the two of you met each others eyes, they felt a resonance deep within each others souls as if you were meant to be together.");
                Console.WriteLine("You went up to here and...");
                Console.WriteLine("(1) Tried to kill her \n(2) Introduced yourself");
                optionIntro = Convert.ToChar(Console.ReadLine());

                if (optionIntro == '1')
                {
                    Console.WriteLine("You took out a blade hidden in your sleeve and gutted her mercilessly.");
                    Console.WriteLine("BAD ENDING GAME OVER");
                    Console.WriteLine("Better luck next time.");
                    Console.WriteLine("You have " + attempts + " attempts remaining");
                    Console.ReadKey();
                }
                else if (optionIntro == '2')
                {
                    Console.WriteLine("You introduced yourself to her and she respondedly kindly with her name which was " + loveinterest);
                    Console.WriteLine("You spoke for a few minutes and eventually you got her number and asked her out on a date.");
                    Console.WriteLine("She answers with a resounding...");
                    Console.WriteLine("(1) No \n(2) Yes");
                    optionDate = Convert.ToChar(Console.ReadLine());

                    if (optionDate == '1')
                    {
                        Console.WriteLine(loveinterest + " said that she found you repulsive and kicked you in the balls.");
                        Console.WriteLine("BAD ENDING GAME OVER");
                        Console.WriteLine("Oof, thats gotta hurt! No more children for you.");
                        Console.WriteLine("You have " + attempts + " attempts remaining");
                        Console.ReadKey();
                    }
                    else if (optionDate == '2')
                    {
                        Console.WriteLine(loveinterest + " happily said yes and jumped into your arms before kissing you on the cheek and running off.");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("NEXT DAY");
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("While you were waiting for " + loveinterest + " you saw a store with a variety of weapons.");
                        Console.WriteLine("While you were examining the weapons, you didn't notice " + loveinterest + " and noticing this she decided to scare you.");
                        Console.WriteLine("She crept up behind and whispered in his ears in an eerie voice that she was there to take him away.");
                        Console.WriteLine("You got a massive fright and...");
                        Console.WriteLine("(1) Grabbed a weapon and attacked the, then unknown, assailant \n(2) Turned around and saw that it was " + loveinterest);
                        optionFright = Convert.ToChar(Console.ReadLine());

                        if (optionFright == '1')
                        {
                            Console.WriteLine("You quickly hacked and slashed away with the longsword that you picked up and only after the bloody massacre did you realize that it was " + loveinterest);
                            Console.WriteLine("BAD ENDING GAME OVER");
                            Console.WriteLine("Guess that you're the type of guy to kill first ask questions later.");
                            Console.WriteLine("You have " + attempts + " attempts remaining");
                            Console.ReadKey();
                        }
                        else if (optionFright == '2')
                        {
                            Console.WriteLine("You quickly turned around and saw that it was " + loveinterest + " you complained about how she shouldn't sneak up on him, especially if he's near weapons, because he frightens easily.");
                            Console.WriteLine("She just laughed it off and we continued with our date.");
                            Console.WriteLine("We went in a gondola to tour the famous canals of Venice. We were also serenaded by the gondola man with a beautiful rendition of an Italian opera.");
                            Console.WriteLine("We were so engrossed in the romance of the moment and the beautiful city that we didn't notice that we had moved closer together and were then but an inch apart.");
                            Console.WriteLine("You then gathered up the courage to go in for a kiss and... ");
                            Console.WriteLine("(1) She reciprocates the kiss \n(2) She refuses the kiss");
                            optionKiss = Convert.ToChar(Console.ReadLine());

                            if (optionKiss == '1')
                            {
                                Console.WriteLine("When your lips meet, you taste a sweet honey-like flavour that keeps you asking for more.");
                                Console.WriteLine("For the next few minutes, the both of you enjoy the taste of each other and right then and there you ask her to be you girlfriend.");
                                Console.WriteLine(loveinterest + " says that she would love to be your girlfriend.");
                                Console.WriteLine("The two of you embrace one another and look towards the sunset as you ponder your new lives with one another.");
                                Console.WriteLine("GOOD ENDING WOOOOOHHHHHHH!!!!!!!!");
                                Console.WriteLine("Congratulations! You successfully found love but this isn't the end of our story. Stay tuned for Dating Simulator: Part 2");
                                Console.ReadKey();
                            }
                            else if (optionKiss == '2')
                            {
                                Console.WriteLine("She vehemently refuses the kiss and then explains to you how this had all been a ruse and that she had been stringing you along as a joke.");
                                Console.WriteLine("Distraught at the fact that your feelings had been played with like a toy, you jumped into the canal and drowned yourself.");
                                Console.WriteLine("BAD ENDING GAME OVER");
                                Console.WriteLine("A tale as old as time, boy meets girl, girl plays with boys feelings, boy drowns himself,classic.");
                                Console.WriteLine("You have " + attempts + " attempts remaining");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Don't be a troll just play the game.");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Don't be a troll just play the game.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't be a troll just play the game.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Don't be a troll just play the game.");
                    Console.ReadKey();
                }
            }
        }
    }
}
        
    

