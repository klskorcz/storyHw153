using System;

namespace storyHw153
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey! You over there! What's your name? [Enter your name] ");
            String alienName = Console.ReadLine();
            Console.ReadKey();
            Alien bigAlien = new Alien(alienName, 50);
            Babyalien lilalien = new Babyalien(alienName, 30, "purple");

          

            Console.WriteLine("Oh {0}, that's a nice name. I happen to know an alien who has the same name.", alienName);
            Console.ReadKey();
            Console.WriteLine("Well let me tell ya {0}, {0} was just the most obnoxious alien ever known to man. I think he may have been the only alien, but that's besides the point.", alienName);
            Console.ReadKey();
            Console.WriteLine("So I was walking down a dark deserted country road, like I do every other night at 11:37. All of a sudden this big gangly thing runs out of the trees, straight into me.");
            Console.ReadKey();
            Console.WriteLine("I said whoa dude, who are you?");
            Console.ReadKey();
            Console.WriteLine("Oh my name is {0}. Sorry you are in my way and I must go.", alienName);
            Console.ReadKey();
            Console.WriteLine("Oh gee well so SORRY to be in your way, I responded.");
            Console.ReadKey();
            Console.WriteLine("And then he left.");
            Console.ReadKey();
            bigAlien.Finish();
            Console.ReadKey();






        }
    }
}
