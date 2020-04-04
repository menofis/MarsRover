using System.Collections.Generic;

namespace MarsRover
{
    /// <summary>
    /// Includes all inputs taken from the user.
    /// </summary>
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
