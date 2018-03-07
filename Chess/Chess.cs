using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chess
    {
        public string fen { get; private set; }
        Board board;

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this.fen = fen;
            board = new Board(fen);
        }

        Chess(Board board)
        {
            this.board = board;
        }

        public Chess Move(string move) // Pe2e4, Pe7e8Q
        {
            var fm = new FigureMoving(move);
            var nextBoard = board.Move(fm);
            var nextChess = new Chess(nextBoard);
            return nextChess;
        }

        public Char GetFigureAt(int x, int y)
        {
            var square = new Square(x, y);
            var figure = board.GetFigureAt(square);
            return figure == Figure.none ? '.' : (Char)figure;
        }
    }
}
