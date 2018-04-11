using System.Collections.Generic;
using System.Linq;
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
            

            for (var i = 0; i < 8; i++)

            {
                
                var placeICanMove = new Square(pos.Row,  i);

                if (placeICanMove != pos)
                {
                    legalMoves.Add(placeICanMove);
                }

                placeICanMove = new Square(i, pos.Col);

                if (placeICanMove != pos)
                {
                    legalMoves.Add(placeICanMove);
                }

            }

            

            return legalMoves;
        }
    }
}