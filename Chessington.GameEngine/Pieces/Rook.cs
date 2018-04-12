﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {

            var pos = board.FindPiece(this);
            var legalMoves = new List<Square>();
            var directions = new List<List<int>>
            {
                new List<int> {0, 1},
                new List<int> {1, 0},
                new List<int> {0, -1},
                new List<int> {-1, 0}
            };

            foreach (var direction in directions)
            {
                for (var i = 1; i < 8; i++)
                {
                    var placeICanMove = pos.NextSquare(direction[0] * i, direction[1] * i);
                    //var pieceColour = new Player();
                    
                    if (placeICanMove.OnBoard() && board.IsVacant(placeICanMove))//|| board.PieceColour(placeICanMove) != Player))
                    {
                        legalMoves.Add(placeICanMove);

                        //if (board.PieceColour(placeICanMove) != Player)
                        //{
                        //    break;
                        //}
                    }
                    else 
                    {
                        break;
                    }
                }
            }



            //for (var i = 0; i < 8; i++)

            //{

            //    var placeICanMove = new Square(pos.Row, i);
            //    var previouSquare = new Square(pos.Row, i + 1);


            //    if (placeICanMove != pos && board.IsVacant(placeICanMove))
            //    {
            //        legalMoves.Add(placeICanMove);
            //    }

            //    placeICanMove = new Square(i, pos.Col);

            //    if (placeICanMove != pos && board.IsVacant(placeICanMove))
            //    {
            //        legalMoves.Add(placeICanMove);
            //    }

            //}



            return legalMoves;
        }
    }
}