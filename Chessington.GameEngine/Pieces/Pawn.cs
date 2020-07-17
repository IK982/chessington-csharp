﻿﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            if(Player == Player.White)
            {
                return new List<Square>
                {
                    Square.At(3 , 0)
                };

            }

            return new List<Square>
            {
                Square.At(5 , 0)
            };
                
        }
    }
}