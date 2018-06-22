using System;
using System.Collections.Generic;
using System.Text;

namespace storyHw153
{
    class Alien
    {
        public String _name { get; set; }
        public int _strength { get; set; }

        public Alien(String name, int strength)
        {
            _name = name;
            _strength = strength;
        }

        public void Finish()
        {
            Console.WriteLine("Well there you go, a story");
        }

    }
}
