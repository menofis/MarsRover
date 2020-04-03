using System;

namespace MarsRover
{
    class Program
    {
        static InputModel inputModel { get; set; }
        static int roverCount = 2; // value should be taken from a config file.

        static void Main(string[] args)
        {
            Welcome();
            GetInputs();

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
        /// Welcome message.
        /// </summary>
        static void Welcome()
        {
            string welcomeMsg = "Hello from Mars Rover!";

            foreach (var c in welcomeMsg)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(30);
            }

            Console.WriteLine();
        }
    }
}
