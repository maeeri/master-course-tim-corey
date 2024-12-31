using GameLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public static class GameLogic
    {
        public static void InitializeGame(PlayerGridModel model)
        {
            for (int i = 0; i < model.GridWidth; i++)
            {
                for (int j = 0; j < model.GridHeight; j++)
                {
                    model.GridSpots.Add(new GridSpotModel(Convert.ToChar(i + 65), j + 1));
                }
            }
        }

        public static string PlayerGrid(PlayerGridModel model)
        {
            string output = string.Empty;
            output += "  ";
            for (int i = 0; i < model.GridWidth; i++)
            {
                output += i + 1 + " ";
            }
            output += "\n  ____________________";
            for (int i = 0; i < model.GridSpots.Count; i++)
            {
                if (i % model.GridWidth == 0)
                {
                    output += "\n" + Convert.ToChar(i / model.GridWidth + 65) + " |";
                }

                switch (model.GridSpots[i].Status)
                {
                    case GridSpotStatusEnum.Hit:
                        output += "H ";
                        break;
                    case GridSpotStatusEnum.Miss:
                        output += "M ";
                        break;
                    default:
                        output += "O ";
                        break;
                }
            }
            return output;
        }


        public static bool TakeShot(PlayerGridModel opponent, GridSpotModel gridSpot)
        {
            GridSpotModel? spot = opponent.GridSpots.Find(x => x.SpotLetter == gridSpot.SpotLetter && x.SpotNumber == gridSpot.SpotNumber);
            bool output = false;

            if (spot != null)
            {
                if (spot.Status == GridSpotStatusEnum.Ship)
                {
                    spot.Status = GridSpotStatusEnum.Hit;
                    output = true;
                    opponent.ShipCount--;
                }
                else if (spot.Status == GridSpotStatusEnum.Empty)
                {
                    spot.Status = GridSpotStatusEnum.Miss;
                }
                Console.WriteLine();
                return output;
            }
            else
            {
                throw new Exception("Grid spot was not found.");
            }
        }

        public static void AddShip(PlayerGridModel playerGrid, GridSpotModel ship)
        {
            if (ship.Status == GridSpotStatusEnum.Empty)
            {
                GridSpotModel? spot = playerGrid.GridSpots.Find(x => x.SpotLetter == ship.SpotLetter && x.SpotNumber == ship.SpotNumber);

                if (spot != null)
                {
                    spot.Status = GridSpotStatusEnum.Ship;
                    playerGrid.ShipCount++;
                }
                else
                {
                    throw new Exception("Grid spot was not found.");
                }
            }
            else
            {
                throw new Exception("Space is occupied by another ship.");
            }
        }

        public static List<char> GetLetterList(PlayerGridModel model)
        {
            List<char> output = new List<char>();
            for (int i = 0; i < model.GridWidth; i++)
            {
                output.Add(Convert.ToChar(i + 65));
            }
            return output;
        }

        public static List<int> GetNumberList(PlayerGridModel model)
        {
            List<int> output = new List<int>();
            for (int i = 0; i < model.GridHeight; i++)
            {
                output.Add(i + 1);
            }
            return output;
        }
    }
}
