using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    ///
    /// Stefan 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine(@"                                                                                                                                                                                         __ 
 _____ _____ _____    _____ _____ ___ ___ ___    _____         _ _         _   _                _____                                 _            ___ ___ ___ ___       ___ ___ ___ ___|  |
| __  |   | |  |  |  |     |     | | |  _|_  |  |  _  |___ ___| |_|___ ___| |_|_|___ ___ ___   |  _  |___ ___ ___ ___ ___ _____ _____|_|___ ___   |_  |   |_  |_  |  ___|_  |   |_  |_  |  |
| __ -| | | |  |  |  |   --|  |  |_  |_  |_  |  |     | . | . | | |  _| .'|  _| | . |   |_ -|  |   __|  _| . | . |  _| .'|     |     | |   | . |  |  _| | |  _|_| |_|___|  _| | |  _|  _|__|
|_____|_|___|_____|  |_____|_____| |_|___|___|  |__|__|  _|  _|_|_|___|__,|_| |_|___|_|_|___|  |__|  |_| |___|_  |_| |__,|_|_|_|_|_|_|_|_|_|_  |  |___|___|___|_____|   |___|___|___|___|__|
                                                      |_| |_|                                                |___|                         |___|                                            
                                                                                                                                                                                            
 _          _____ _       ___            _____ _ _                                                                                                                                          
| |_ _ _   |   __| |_ ___|  _|___ ___   |  _  | | |___ ___                                                                                                                                  
| . | | |  |__   |  _| -_|  _| .'|   |  |     | | | -_|   |                                                                                                                                 
|___|_  |  |_____|_| |___|_| |__,|_|_|  |__|__|_|_|___|_|_|                                                                                                                                 
    |___|                                                                                                                                                                                   ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            DistanceConverter converter = new DistanceConverter();

            converter.ConvertDistance();

        }
    }
}
