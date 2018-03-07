﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chess
    {
        string fen;

        public Chess(string fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1")
        {
            this.fen = fen;
        }

        public Chess Move(string move) // Pe2e4, Pe7e8Q
        {
            var nextChess = new Chess(fen);
            return nextChess;
        }

        public Char GetFigureAt(int x, int y)
        {
            return '.';
        }
    }
}