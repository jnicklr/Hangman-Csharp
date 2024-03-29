﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Models
{
    public class Player
    {
        public Player() { }

        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Points { get; set; }

        private int Life = 6;

        public void LoseLife()
        {
            Life -= 1;
        }

        public int GetLife() 
        {
            return Life;
        }
    }
}
