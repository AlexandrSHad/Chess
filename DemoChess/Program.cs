using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoChess
{
    class Program
    {
        static void Main(string[] args)
        {
            var chess = new Chess.Chess();

            while (true)
            {
                Console.WriteLine(chess.fen);
                var move = Console.ReadLine();
                if (move == "") break;
                chess = chess.Move(move);
            }
        }
    }
}
