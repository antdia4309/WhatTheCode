namespace WhatTheCode.Models
{
    public enum Direction { Up, Right, Down, Left }

    public class Character
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }

        public Character(int startX, int startY, Direction startFacing = Direction.Right)
        {
            X = startX;
            Y = startY;
            Facing = startFacing;
        }

        public void TurnLeft()
        {
            Facing = Facing switch
            {
                Direction.Up    => Direction.Left,
                Direction.Left  => Direction.Down,
                Direction.Down  => Direction.Right,
                Direction.Right => Direction.Up,
                _               => Facing
            };
        }

        public void TurnRight()
        {
            Facing = Facing switch
            {
                Direction.Up    => Direction.Right,
                Direction.Right => Direction.Down,
                Direction.Down  => Direction.Left,
                Direction.Left  => Direction.Up,
                _               => Facing
            };
        }

        /// <summary>
        /// Returns true if the move was legal (within grid bounds).
        /// </summary>
        public bool MoveForward(int gridCols, int gridRows)
        {
            int nextX = X;
            int nextY = Y;

            switch (Facing)
            {
                case Direction.Up:    nextY--; break;
                case Direction.Down:  nextY++; break;
                case Direction.Left:  nextX--; break;
                case Direction.Right: nextX++; break;
            }

            if (nextX < 0 || nextX >= gridCols || nextY < 0 || nextY >= gridRows)
                return false;

            X = nextX;
            Y = nextY;
            return true;
        }

        public void Reset(int startX, int startY, Direction startFacing = Direction.Right)
        {
            X = startX;
            Y = startY;
            Facing = startFacing;
        }
    }
}