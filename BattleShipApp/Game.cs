using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Models;
using GameLibrary; 

namespace BattleShipGame
{
    public class Game
    {
        public PlayerGridModel? ActivePlayer { get; set; } = null;
        public PlayerGridModel? Opponent { get; set; } = null;
        public PlayerGridModel? Winner { get; set; } = null;
        public int PlayerNumber { get; set; } = 2;
        public int GridWidth { get; set; } = 5;
        public int GridHeight { get; set; } = 5;
        private List<char> LetterList = new List<char>();
        public void PlayGame()
        {
            
            for (int i = 0; i < GridWidth; i++)
            {
                LetterList.Add(Convert.ToChar(i + 65));
            }
            WelcomeMessage();
            Console.ReadKey();
            Console.Clear();
            ActivePlayer = CreatePlayer();
            Console.Clear();
            Opponent = CreatePlayer();
            Console.Clear();

            if (ActivePlayer == null || Opponent == null)
            {
                Console.WriteLine("Something went wrong, please restart the game");
                return;
            }

            do
            {
                Console.WriteLine(GameLogic.PlayerGrid(Opponent));
                PlayTurn();
                if (Opponent.ShipCount == 0)
                {
                    Winner = ActivePlayer;
                }
                else
                {
                    (ActivePlayer, Opponent) = (Opponent, ActivePlayer);
                }
            } while (Winner == null);
            DisplayWinner();
        }

        private PlayerGridModel CreatePlayer()
        {
            PlayerGridModel output = CreatePlayerGrid();
            PlaceShips(output, GridWidth);

            return output;
        }

        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to this BattleShip game. Press 'enter' to continue.");
        }

        private string GetPlayerName()
        {
            Console.WriteLine("Hello, what is your name: ");
            string? output = Console.ReadLine();
            if (string.IsNullOrEmpty(output))
            {
                Console.WriteLine("You need to type something ");
                return GetPlayerName();
            }
            return output;
        }

        private PlayerGridModel CreatePlayerGrid()
        {
            string name = GetPlayerName();
            PlayerGridModel output = new PlayerGridModel(name, 5, 5);
            GameLogic.InitializeGame(output);
            return output;
        }

        private void PlaceShips(PlayerGridModel model, int shipNumber)
        {
            char letter = ' ';
            int number = 0;
            while (model.ShipCount < 5)
            {
                Console.Write($"{model.PlayerName}, place ship number {model.ShipCount + 1}, (letter number), e.g. 'A 4': ");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || input.Length != 3)
                {
                    Console.WriteLine($"You need to type a letter, a space and a number\n" +
                        $"The letter needs to be between {LetterList[0]} and {LetterList[^1]}\n" +
                        $"and the number between 1 and {GridWidth}");
                    continue;
                }
                letter = ValidateCharInput(input[0].ToString().ToUpper(), LetterList);
                number = ValidateIntInput(input[2].ToString(), GridWidth);
                if (model.GridSpots.Find(x => x.SpotLetter == letter && x.SpotNumber == number).Status == GridSpotStatusEnum.Ship)
                {
                    Console.WriteLine("There is already a ship there");
                    continue;
                }   
                GameLogic.AddShip(model, new GridSpotModel(letter, number));
            }
        }

        private int GetIntInput()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int output))
            {
                return output;
            }
            else
            {
                Console.WriteLine("You need to type a number ");
                return GetIntInput();
            }
        }

        private void DisplayWinner()
        {
            Console.WriteLine(Winner.PlayerName + " WON!!! You took " + Winner.ShotCount + " shots.");
        }

        private void PlayTurn()
        {
            try
            {
                char letter = ' ';
                int number = 0;
                Console.Write($"{ActivePlayer.PlayerName}, please take your shot: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) || input.Length != 3)
                {
                    Console.WriteLine("You need to type a letter, a space and a number");
                    PlayTurn();
                }
                else
                {
                    letter = ValidateCharInput(input[0].ToString().ToUpper(), LetterList);
                    number = ValidateIntInput(input[2].ToString(), GridWidth);
                }
            
                bool isAHit = GameLogic.TakeShot(Opponent, new GridSpotModel(letter, number));
                string hitOrMiss = isAHit ? "hit" : "miss";

                Console.WriteLine($"{letter} {number} was a {hitOrMiss}.\n\n");
                
                ActivePlayer.ShotCount++;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong, please try again");
                PlayTurn();
            }
            
        }



        private int ValidateIntInput(string input, int maxNumber)
        {
            if (int.TryParse(input, out int output) && output <= maxNumber)
            {
                return output;
            }
            else
            {
                Console.WriteLine("You need to type a number between 1 and " + maxNumber);
                return ValidateIntInput(Console.ReadLine(), maxNumber);
            }
        }

        private char ValidateCharInput(string input, List<char> letterList)
        {
            if (char.TryParse(input, out char output))
            {
                if (output >= letterList[0] && output <= letterList[^1])
                {
                    return output;
                }
                else
                {
                    Console.WriteLine($"You need to type a letter between {letterList[0]} and {letterList[^1]}");
                    return ValidateCharInput(Console.ReadLine().ToUpper(), letterList);
                }
            }
            else
            {
                Console.WriteLine("You need to type a letter ");
                return ValidateCharInput(Console.ReadLine().ToUpper(), letterList);
            }
        }
    }
}
