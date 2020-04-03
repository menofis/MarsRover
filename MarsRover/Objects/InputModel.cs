using System.Collections.Generic;

namespace MarsRover
{
    public class InputModel
    {
        public string PlateauEndCoordinates { get; set; }

        public List<Rover> Rovers { get; set; }

        public InputModel()
        {
            Rovers = new List<Rover>();
        }
    }
}
