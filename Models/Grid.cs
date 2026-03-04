namespace WhatTheCode.Models
{
    public class Grid
    {
        public int Columns { get; }
        public int Rows { get; }

        // Optional: track which cells have been visited
        public bool[,] Visited { get; }

        public Grid(int columns = 8, int rows = 8)
        {
            Columns = columns;
            Rows = rows;
            Visited = new bool[columns, rows];
        }

        public bool IsInBounds(int x, int y) =>
            x >= 0 && x < Columns && y >= 0 && y < Rows;

        public void MarkVisited(int x, int y)
        {
            if (IsInBounds(x, y))
                Visited[x, y] = true;
        }

        public void Reset()
        {
            for (int x = 0; x < Columns; x++)
                for (int y = 0; y < Rows; y++)
                    Visited[x, y] = false;
        }
    }
}