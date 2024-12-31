using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Models
{
    public class GridSpotModel
    {        
        public GridSpotStatusEnum Status { get; set; } = GridSpotStatusEnum.Empty;
        public int SpotNumber { get; set; }
        public char SpotLetter { get; set; }
        public GridSpotModel(char spotLetter, int spotNumber)
        {
            SpotNumber = spotNumber;
            SpotLetter = spotLetter;
        }
    }
}
