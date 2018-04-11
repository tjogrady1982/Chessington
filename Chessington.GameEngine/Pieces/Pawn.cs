using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            
           var column = board.FindPiece(this).Col;
            var row = board.FindPiece(this).Row;
            if (Player == Player.Black)
            {
                return new List<Square>
                {
                    Square.At(row + 1, column)
                };
            }
            else if (Player == Player.White)

            {
                return new List<Square>
                {
                    Square.At(row - 1, column)
                };
            }

            return new List<Square>
            {
                //Square.At(6, 0)
            };

            //return Enumerable.Empty<Square>();
        }
    }
}