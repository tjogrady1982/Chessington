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
            var directions = new List<List<int>>
            {
                new List<int> {1, 1},
                new List<int> {1, -1},
                new List<int> {-1, -1},
                new List<int> {-1, 1},
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

                    if (placeICanMove.OnBoard() && (board.IsVacant(placeICanMove)|| board.PieceColour(placeICanMove) != Player))
                    {
                        legalMoves.Add(placeICanMove);

                        if (board.IsVacant(placeICanMove) == false)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return legalMoves;

        }
    }
}