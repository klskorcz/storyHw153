using System;
using System.Collections.Generic;
using System.Text;

namespace storyHw153
{
    class Babyalien : Alien
    {
        public String _color { get; set; }

        

        public Babyalien(String name, int strength, String color) : base(name, strength)
        {
            _name = name;
            _strength = strength;
            _color = color;

        }

       
        

        
    }
}
