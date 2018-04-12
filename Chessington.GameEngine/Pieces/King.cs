using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var pos = board.FindPiece(this);
            var legalMoves = new List<Square>();

            var placeICanMove = new Square(pos.Row , pos.Col + 1);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }

            placeICanMove = new Square(pos.Row , pos.Col - 1);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }


            placeICanMove = new Square(pos.Row + 1, pos.Col);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }

            placeICanMove = new Square(pos.Row - 1, pos.Col);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }

            placeICanMove = new Square(pos.Row+ 1, pos.Col + 1);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }

            placeICanMove = new Square(pos.Row + 1, pos.Col -1);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }

            placeICanMove = new Square(pos.Row - 1, pos.Col + 1);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }

            placeICanMove = new Square(pos.Row - 1, pos.Col - 1);

            if (placeICanMove != pos && placeICanMove.OnBoard() && (board.IsVacant(placeICanMove) || board.PieceColour(placeICanMove) != Player))
            {
                legalMoves.Add(placeICanMove);
            }

            return legalMoves;
        }
    }
}