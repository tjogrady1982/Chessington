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
            var legalMoves = new List<Square>
            {
                new Square(pos.Row + direction, pos.Col)
            };
            if (!hasEverMoved)
            {
                legalMoves.Add(new Square(pos.Row + 2 * direction, pos.Col));
            }

            return legalMoves;
        }
    }
}