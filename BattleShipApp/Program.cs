﻿using GameLibrary;
using GameLibrary.Models;

namespace BattleShipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PlayGame();
            Console.ReadLine();
        }
    }
}


