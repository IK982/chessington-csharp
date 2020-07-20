﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var currentSquare = board.FindPiece(this);
            var checkSquare = board.GetPiece(Square.At(currentSquare.Row + 1, currentSquare.Col));
            if(checkSquare == currentSquare.Row + 1)
            {}

            if(IsSpaceEmpty() == true)
            {

                if(Player == Player.White)
                {
                    if(currentSquare.Row == 6)
                    {

                        return new List<Square>
                        {
                            Square.At(currentSquare.Row - 1, currentSquare.Col),
                            Square.At(currentSquare.Row - 2, currentSquare.Col)
                        };


                    }
                    return new List<Square> 
                        {
                            Square.At(currentSquare.Row - 1, currentSquare.Col)
                        };
                }

                    if(currentSquare.Row == 1)
                    {
                        return new List<Square>
                        {
                            Square.At(currentSquare.Row + 1, currentSquare.Col),
                            Square.At(currentSquare.Row + 2, currentSquare.Col)
                        };

                    }
                    return new List<Square>
                    {
                        Square.At(currentSquare.Row + 1, currentSquare.Col)
                    };
            }

            return new List<Square>
            {
                Square.At(currentSquare.Row, currentSquare.Col),
                Square.At(currentSquare.Row, currentSquare.Col)
            };


        }

        private bool IsSpaceEmpty()
        {
            return true;   
        }

    }
}


              //if there is at piece at the row in front (1 or 2 rows), then you cannot move
                    // if(nextSquare.)