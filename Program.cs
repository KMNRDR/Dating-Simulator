namespace NewSim2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, loveInterest;
            char optionGlass, optionFight, optionLife;
            int attempts;

            attempts = 3;
            int i = 0;

            while(i < attempts)
            {
                attempts--;
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Welcome to Dating Simulator: Part 2");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("Welcome back, it's been a while since we've seen you." +
                    "\nI hope you're doing well.");
                Console.WriteLine("This is the second installment to your Quest for Love and Happiness.");
                Console.WriteLine("Would you please remind us of your name and love interest.");
                name = Console.ReadLine();
                loveInterest = Console.ReadLine();
                Console.WriteLine("Thank you " + name + ", and once again we welcome you back to your journey to claim " + loveInterest + "'s heart.");
                Console.WriteLine("Now without further ado, lets get back to the game.");

                Console.WriteLine("---------");
                Console.WriteLine("Prologue");
                Console.WriteLine("---------");
                Console.WriteLine("It's been a few months since you officially entered into a relationship with " + loveInterest + " and things have been amazing." +
                    "\nYou've been travelling all around Italy and are now on your way to Vienna.");
                Console.WriteLine("----------------");
                Console.WriteLine("End of Prologue");
                Console.WriteLine("----------------");

                Console.WriteLine("You and your beloved have been travelling for a while and finally reached your destination of Vienna,Austria." +
                    "\nIt is here that,unknown to the lovers, their love and lives will be at stake as past sins come to light.");
                Console.WriteLine("You find yourself on a train with " + loveInterest + " and couldn't help but be entranced by the way she looked in the glistening moonlight.");
                Console.WriteLine("Just then you noticed out of the corner of your eye that there was something in her glass." +
                    "\nSeeing this you...");
                Console.WriteLine("(1) Swapped her glass with yours" +
                    "\n(2) Did nothing and continued gazing at her");
                optionGlass = Convert.ToChar(Console.ReadLine());

                if (optionGlass == '1')
                {
                    Console.WriteLine("You discreetly switched glasses with her and as you took a closer look you realized that there was a, in a semi-dissolved form, pill containing poison that you were all too familiar with... Botulinum Toxin.");
                    Console.WriteLine("At this point you realized that you or beloved were being targeted but you didn't reveal it as that would worry " + loveInterest + " and you cared for her too much to put her in danger.");

                    Console.WriteLine("Putting that thought at the back of your mind, you continued on with your journey on the train and after a few more hours you and " + loveInterest + " reached Vienna.");
                    Console.WriteLine("As soon as you and " + loveInterest + " disembarked from the train, she immediately pulled you with her towards the city square so that they could see the shining lights and beautiful architecture that lined the streets." +
                        "\nWhen you arrived there, you could see how beautiful everything looked and you could appreciate " + loveInterest + "'s beauty even more. This influx of emotions caused you to pull her in for a deep kiss.");
                    Console.WriteLine("While you enraptured by the taste of her lips, out of the corner of your eye you could see a suspicious-looking man looking at you with well-hidden but malicious intent." +
                        "\nSeeing this you quickly broke off the kiss and told " + loveInterest + " that you were going to a store to buy her a present.");
                    Console.WriteLine("Without giving her a chance to respond, you ran down the street and as you expected the suspicious man followed." +
                        "\nEventually you ran down an alleyway to confront him but when the man arrived, he started fighting with you. You and the man were subsequently engaged in a heated competition of martial arts and eventually you bested him in combat." +
                        "\nNow you were faced with a choice... ");
                    Console.WriteLine("(1) Kill him " +
                        "\n(2) Show mercy");
                    optionFight = Convert.ToChar(Console.ReadLine());

                    if (optionFight == '1')
                    {
                        Console.WriteLine("You decided that, above all else, " + loveInterest + "'s safety was your primary goal and so you decided to snap his neck mercilessly.");

                        Console.WriteLine("After you killed him, you took his body and tied it up with bricks on the ends and threw it into a nearby ravine." +
                            "\nYou remembered that you promised " + loveInterest + " that you would buy her a gift and you soon ran to a nearby jewellery store and bought her pendant that had a crystal heart in the centre.");
                        Console.WriteLine("When you finally got back to " + loveInterest + ", she lightly scolded you for leaving her alone so suddenly but was pacified when she saw the pendant that you had gotten for her." +
                            "\nShe was in disbelief as she couldn't believe that you had gotten her something so beautiful and while she gazed at it she noticed a splotch of blood on your knuckles.");
                        Console.WriteLine("She then asked you where the blood had come from but you quickly answered and said that it had happened while you were running to the store." +
                            "\nNot questionning you, she then asked you to put the pendant on for her and obliging you skillfully hooked the pendant behind her neck and let it rest below her collarbone.");
                        Console.WriteLine("After this brief event, both of you continued on your exploration within the beautiful city of Vienna.");

                        Console.WriteLine("-----------------");
                        Console.WriteLine("A Few Days Later");
                        Console.WriteLine("-----------------");

                        Console.WriteLine("A few days after your arrival, you and " + loveInterest + " were enjoying a morning stroll when out of nowhere a hawk swooped down from above and, using its sharp talons, snapped the necklace off of " + loveInterest + "'s neck and flew off." +
                            "\nSeeing this you ran off after the hawk but the hawk was too fast and had an aerial advantage. You were able to catch up a little and saw it fly into the window of a nearby clock tower but before the window closed you saw a mysterious man gaze at you from the clock tower and recognizing this man as your former mentor you steeled your resolve and rushed forward.." +
                            "\nYou reached the clock tower and swiftly entered but were immediately assaulted by the hawk as it bared its sharp talons before you.");
                        Console.WriteLine("Before it attacked, it was called back by a sharp whistle sound and from out of the shadows of the clock tower came your former mentor whom you only knew by his codename: Ocelot." +
                            "\nOcelot then greeted you and explained that he was there to warn you that ATLAS was coming for him and that he wasn't safe anymore. You then tell Ocelot that your life was forfeit the moment you went on the run and now that you have someone to protect you'll stop running." +
                            "\nOcelot only smirks at your statement as he then tells you that ATLAS already knows and that you're on a clock as one of their snipers is on their way to kill " + loveInterest + ".");
                        Console.WriteLine("Ocelot then opens the clock tower's door and tells you to protect the last thing that keeps you human." +
                            "\nNodding at Ocelot, you immediately run out into the street at the fastest speed you can possibly go and eventually you reach the square where you left " + loveInterest + " and as she stands there worrying over where you went you here your phone ringing, but as you go to deny the call you see the number and immediately recognise it as one of the dummy numbers of ATLAS." +
                            "\nYou come to stop and pick up the phone and as you listen to the person on the other side, they introduce themselves as the Head of Operation of ATLAS. They then tell you that if you continue running towards " + loveInterest + ",they will immediately order their sniper to shoot " + loveInterest + ".");
                        Console.WriteLine("You are seething with fury at the ultimatum that has been presented and you decide to...");
                        Console.WriteLine("(1)Continue running to save " + loveInterest + "" +
                            "\n(2)Stop and comply");
                        optionLife = Convert.ToChar(Console.ReadLine());

                        if (optionLife == '1')
                        {
                            Console.WriteLine("You ignore the ATLAS leader and continue on to try and save " + loveInterest + " when suddenly a loud gunshot is heard and right in front of your eyes " + loveInterest + "'s brain matter is splattered on the street." +
                                "\nThe sight of her cold corpse causes your mind to break as you start screaming at the top of your lungs. Through your howls of anguish you threaten the leader of ATLAS that you will find them and destroy everything that they've built." +
                                "\nWith the death of " + loveInterest + " as the spark and your rage at ATLAS the fuel, your wrath would burn them to the ground.");
                            Console.WriteLine("GOOD ENDING?");
                            Console.WriteLine("To be continued...");
                            Console.ReadKey();
                        }
                        else if (optionLife == '2')
                        {
                            Console.WriteLine("Fearing for " + loveInterest + "'s safety, you heeded their warning but that was your biggest mistake. They berated you on your idiocy in believing that they would actually spare " + loveInterest + "'s life and as you came to the realization that you'd been fooled it was too late as the sniper took his shot and snuffed out " + loveInterest + "'s life right before you.");
                            Console.WriteLine("BAD ENDING GAME OVER");
                            Console.WriteLine("No matter what, prey should never believe their predator harmless...");
                            Console.WriteLine("You have " + attempts + " attempts remaining");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Don't be a troll just play the game.");
                            Console.ReadKey();
                        }
                    }
                    else if (optionFight == '2')
                    {
                        Console.WriteLine("You decided to show him mercy as you wanted to show yourself that you truly were a changed man and not the killing machine you were made to be." +
                            "\nTaking advantage of this, the man then pulled out a pistol and shot you mercilessly in the head and as your consciousness faded you could only think of " + loveInterest + " and how you failed to protect her.");
                        Console.WriteLine("BAD ENDING GAME OVER");
                        Console.WriteLine("You merciful idiot...");
                        Console.WriteLine("You have " + attempts + " attempts remaining");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Don't be a troll just play the game.");
                        Console.ReadKey();
                    }
                }
                else if (optionGlass == '2')
                {
                    Console.WriteLine("You just sat there and watched her take a sip of her drink and to your horror she started convulsing and foaming at the mouth." +
                        "\nBlood then began to pour out of her mouth as her body eventualy stopped shaking and after witnessing the gruesome death of " + loveInterest + " you saw her face twisted in an expression of agony.");
                    Console.WriteLine("BAD ENDING GAME OVER");
                    Console.WriteLine("Why didn't you just switch the glasses?");
                    Console.WriteLine("You have " + attempts + " attempts remaining");
                    Console.ReadKey();
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
