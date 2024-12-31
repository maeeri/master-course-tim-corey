using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Models
{
    public class PlayerGridModel
    {
        public string PlayerName { get; set; }
        public List<GridSpotModel> GridSpots { get; set; }
        private int _gridWidth;
        public int GridWidth { get { return _gridWidth; } }
        private int _gridHeight;
        public int GridHeight { get { return _gridHeight; } }
        public int ShipCount { get; set; }
        public int ShotCount { get; set; }
        public PlayerGridModel(string playerName, int gridWidth, int gridHeight)
        {
            PlayerName = playerName;
            GridSpots = new List<GridSpotModel>();
            ShipCount = 0;
            _gridWidth = gridWidth;
            _gridHeight = gridHeight;
        }

        
    }
}
