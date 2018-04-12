using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        private bool hasEverMoved;

        public Pawn(Player player)
            : base(player)
        {
            hasEverMoved = false;
        }




        public override void MoveTo(Board board, Square square)
        {
            hasEverMoved = true;
            base.MoveTo(board, square);
        }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var pos = board.FindPiece(this);
            var direction = Player == Player.Black ? 1 : -1;//ternary operator

            var legalMoves = new List<Square>();
            var squareInFront = new Square(pos.Row + direction, pos.Col);

            if (board.IsVacant(squareInFront))
            {
                legalMoves.Add(squareInFront); //check if position is occupied
            }

            var squareTwoInFront = new Square(pos.Row + 2 * direction, pos.Col);

            if (!hasEverMoved && board.IsVacant(squareTwoInFront)&& board.IsVacant(squareInFront))
            {
                legalMoves.Add(squareTwoInFront);//check if position is occupied
            }

            return legalMoves;
        }
    }
}