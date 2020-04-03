using MarsRover.Interfaces;
using System;

namespace MarsRover
{
    /// <summary>
    /// Defines a rover with the parameters of starting position and the moves.
    /// </summary>
    public class Rover : IMove
    {
        const string directions = "NESW"; // directions to follow when turns right.

        int xAxis { get; set; }
        
        int yAxis { get; set; }


        public string[] StartingPosition { get; set; }

        public string Moves { get; set; }

        /// <summary>
        /// Creates a rover object with the given parameters.
        /// </summary>
        /// <param name="startingPosition">Starting position as x-y coordinates</param>
        /// <param name="moves">Moves as 'L','R','M'</param>
        public Rover(string startingPosition, string moves)
        {
            this.StartingPosition = startingPosition.Split(" ");
            this.Moves = moves;
            this.xAxis = Convert.ToInt32(StartingPosition[0]);
            this.yAxis = Convert.ToInt32(StartingPosition[1]);
        }

        /// <summary>
        /// Moves te rover.
        /// </summary>
        /// <returns>Returns the last position of rover.</returns>
        public string Move()
        {
            // will be implemented.
            throw new NotImplementedException();
        }
    }
}
