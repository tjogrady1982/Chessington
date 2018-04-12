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
           // var lastRow = Player == Player.Black ? 7 : 0;

            var legalMoves = new List<Square>();
            var squareInFront = new Square(pos.Row + direction, pos.Col);
            var potentialVictim1 = new Square(pos.Row + direction, pos.Col + direction);
            var potentialVictim2 = new Square(pos.Row + direction, pos.Col - direction);

            if (board.IsVacant(squareInFront) && squareInFront.OnBoard())
            {
                legalMoves.Add(squareInFront); //check if position is occupied
            }

            if (board.IsVacant(potentialVictim1) == false && board.PieceColour(potentialVictim1) != Player)
            {
                legalMoves.Add(potentialVictim1);
            }

            if (board.IsVacant(potentialVictim2) == false && board.PieceColour(potentialVictim2) != Player)
            {
                legalMoves.Add(potentialVictim2);
            }

            var squareTwoInFront = new Square(pos.Row + 2 * direction, pos.Col);

            if (!hasEverMoved && board.IsVacant(squareTwoInFront) && board.IsVacant(squareInFront) && squareInFront.OnBoard())
            {
                legalMoves.Add(squareTwoInFront);//check if position is occupied
            }

            return legalMoves;
        }
    }
}