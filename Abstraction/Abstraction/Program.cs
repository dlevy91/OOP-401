﻿using System;
using Abstraction.Classes;

namespace Abstraction{
    class Program{
        static void Main(string[] args){
            KidParty johnsParty = new KidParty();
            johnsParty.Setup();
            johnsParty.TearDown();
            johnsParty.PlayGames();
        }
    }
}