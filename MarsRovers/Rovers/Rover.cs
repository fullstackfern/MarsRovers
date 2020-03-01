﻿namespace MarsRovers.Rovers
{
    public class Rover : IRover
    {
        public Rover() {}

        public Rover(int x, int y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }

        public Direction Direction { get; set; }

        public virtual void MoveForward()
        {
            if (Direction == Direction.North)
                YCoordinate++;
            else if (Direction == Direction.South)
                YCoordinate--;
            else if (Direction == Direction.West)
                XCoordinate--;
            else if (Direction == Direction.East)
                XCoordinate++;
        }

        public virtual void TurnLeft()
        {
            if (Direction == Direction.North)
                Direction = Direction.West;
            else if (Direction == Direction.West)
                Direction = Direction.South;
            else if (Direction == Direction.South)
                Direction = Direction.East;
            else if (Direction == Direction.East)
                Direction = Direction.North;
        }

        public virtual void TurnRight()
        {
            if (Direction == Direction.North)
                Direction = Direction.East;
            else if (Direction == Direction.East)
                Direction = Direction.South;
            else if (Direction == Direction.South)
                Direction = Direction.West;
            else if (Direction == Direction.West)
                Direction = Direction.North;
        }
    }
}
