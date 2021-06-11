using Chess.Enums;
using System;
using System.IO;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            string[] lines = File.ReadAllLines("inputFile.txt");
            Chess chess = new Chess(Piece.Rook);
            foreach (string line in lines)
                if (chess.ValidPhoneNumber(line))
                    counter += 1;

            Console.WriteLine($"Number of valid 7-digit phone numbers: {counter}");
        }
    }
}
