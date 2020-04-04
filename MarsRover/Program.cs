using System;

namespace MarsRover
{
    class Program
    {
        #region Properties

        static InputModel inputModel { get; set; }
        
        /// <summary>
        /// Defines the count of the rovers. To run the program for more rovers, just change this parameter.
        /// </summary>
        static int roverCount = 2; // this value should be taken from a config file. 

        #endregion

        static void Main(string[] args)
        {
            Welcome();
            GetInputs();
            MoveRoversAndWriteLastPositions();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Gets upper-right coordinates, starting positions and moves of the rovers to run the rest of the program.
        /// </summary>
        static void GetInputs()
        {
            inputModel = new InputModel();
            Console.WriteLine("Please enter the upper-right coordinates of the plateau:");
            inputModel.PlateauEndCoordinates = Console.ReadLine();
            // input should be verified.

            for (var i = 0; i < roverCount; i++)
            {
                Console.WriteLine("Please enter the starting position of {0}. rover:", i + 1);
                string pos = Console.ReadLine(); // input should be verified.
                Console.WriteLine("Please enter the moves of {0}. rover:", i + 1);
                string moves = Console.ReadLine(); // input should be verified.
                inputModel.Rovers.Add(new Rover(pos, moves));
            }
        }

        /// <summary>
        /// Moves the rovers and writes the last positions to console.
        /// </summary>
        static void MoveRoversAndWriteLastPositions()
        {
            Console.WriteLine("The last positions of the rovers are:");

            foreach (var rover in inputModel.Rovers)
            {
                Console.WriteLine(rover.Move());
            }
        }

        /// <summary>
        /// Welcome message.
        /// </summary>
        static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string welcomeMsg = "Hello from Mars Rover!";

            foreach (var c in welcomeMsg)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine(); Console.WriteLine();
        }
    }
}
