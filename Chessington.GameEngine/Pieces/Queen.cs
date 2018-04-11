using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {

            var pos = board.FindPiece(this);
            var legalMoves = new List<Square>();


            for (var i = 0; i < 8; i++)

            {

                var placeICanMove = new Square(pos.Row + i, pos.Col + i);

                if (placeICanMove != pos & placeICanMove.Row < 8 & placeICanMove.Col < 8)
                {
                    legalMoves.Add(placeICanMove);
                }

                placeICanMove = new Square(pos.Row - i, pos.Col - i);

                if (placeICanMove != pos & placeICanMove.Row > -1 & placeICanMove.Col > -1)
                {
                    legalMoves.Add(placeICanMove);
                }


                placeICanMove = new Square(pos.Row + i, pos.Col - i);

                if (placeICanMove != pos & placeICanMove.Row < 8 & placeICanMove.Col > -1)
                {
                    legalMoves.Add(placeICanMove);
                }

                placeICanMove = new Square(pos.Row - i, pos.Col + i);

                if (placeICanMove != pos & placeICanMove.Row > -1 & placeICanMove.Col < 8)
                {
                    legalMoves.Add(placeICanMove);
                }

                placeICanMove = new Square(pos.Row, i);

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