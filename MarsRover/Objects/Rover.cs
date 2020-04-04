using MarsRover.Interfaces;
using System;

namespace MarsRover
{
    /// <summary>
    /// Defines a rover with the parameters of starting position and the moves.
    /// </summary>
    public class Rover : IMove
    {
        #region Rover Properties

        string directions = "NESW"; // directions to follow when turns right.

        int xAxis { get; set; }
        
        int yAxis { get; set; }

        string currentDirection { get; set; }

        public string[] StartingPosition { get; set; }

        public string Moves { get; set; }
        
        #endregion

        /// <summary>
        /// Creates a rover object with the given parameters.
        /// </summary>
        /// <param name="startingPosition">Starting position as x-y coordinates.</param>
        /// <param name="moves">Moves as 'L','R','M'</param>
        public Rover(string startingPosition, string moves)
        {
            this.StartingPosition = startingPosition.Split(" ");
            this.Moves = moves;
            this.xAxis = Convert.ToInt32(StartingPosition[0]);
            this.yAxis = Convert.ToInt32(StartingPosition[1]);
            this.currentDirection = this.StartingPosition[2];
        }

        /// <summary>
        /// Moves te rover.
        /// </summary>
        /// <returns>Returns the last position of rover.</returns>
        public string Move()
        {
            foreach (var m in Moves)
            {
                if (m != 'M') { SetPosition(m); }
                else 
                {
                    switch (currentDirection)
                    {
                        case "N":
                            this.yAxis++;
                            break;
                        case "E":
                            this.xAxis++;
                            break;
                        case "S":
                            this.yAxis--;
                            break;
                        case "W":
                            this.xAxis--;
                            break;
                        default:
                            // nothing to do.
                            break;
                    }
                }
            }

            return string.Format("{0} {1} {2}", xAxis.ToString(), yAxis.ToString(), currentDirection);
        }

        /// <summary>
        /// Sets the current position of the rover according to the next character of "Moves" object.
        /// </summary>
        /// <param name="c"></param>
        private void SetPosition(char c)
        {
            switch (c)
            {
                case 'L':
                    if (this.directions.IndexOf(currentDirection) == 0)
                    {
                        this.currentDirection = this.directions[3].ToString();
                    }
                    else { this.currentDirection = this.directions[this.directions.IndexOf(currentDirection) - 1].ToString(); }
                    break;
                case 'R':
                    this.currentDirection = this.directions[(this.directions.IndexOf(currentDirection) + 1) % this.directions.Length].ToString();
                    break;
                default:
                    // nothing to do.
                    break;
            }
        }
    }
}
