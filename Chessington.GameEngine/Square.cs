﻿namespace Chessington.GameEngine
{
    public struct Square
    {
        public readonly int Row;
        public readonly int Col;

        public Square(int row, int col)
        {
            Row = row;
            Col = col;
        }

        public static Square At(int row, int col)
        {
            return new Square(row, col);
        }

        public Square NextSquare(int rowChange, int columnChange)
        {
            return new Square(Row + rowChange, Col + columnChange);
        }

        public bool OnBoard()
        {
            return
                0 <= Row &&
                Row < GameSettings.BoardSize &&
                0 <= Col &&
                Col < GameSettings.BoardSize;
        }

        public bool Equals(Square other)
        {
            return Row == other.Row && Col == other.Col;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Square && Equals((Square)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Row * 397) ^ Col;
            }
        }

        public static bool operator ==(Square left, Square right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Square left, Square right)
        {
            return !left.Equals(right);
        }

        public override string ToString()
        {
            return string.Format("Row {0}, Col {1}", Row, Col);
        }
    }
}