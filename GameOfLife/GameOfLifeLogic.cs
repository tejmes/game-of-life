using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    internal class GameOfLifeLogic
    {
        private bool[,] map;
        private bool[,] mapNext;
        private readonly Random rnd = new Random();

        public int WorldRows { get; private set; } = 500;
        public int WorldCols { get; private set; } = 800;
        public int Generation { get; private set; }
        public int AliveCells { get; private set; }

        public bool Changed { get; private set; }
        public bool WrappedEdges { get; private set; } = true;

        public GameOfLifeLogic()
        {
            map = new bool[WorldRows, WorldCols];
            mapNext = new bool[WorldRows, WorldCols];
        }

        public void RandomFill(int density, int? seed, bool isEntire, int startRow, int startCol, int rows, int cols)
        {
            if (isEntire) Generation = 0;

            var rng = seed.HasValue ? new Random(seed.Value) : rnd;

            int rowsMax = Math.Min(startRow + rows, WorldRows);
            int colsMax = Math.Min(startCol + cols, WorldCols);

            for (int r = startRow; r < rowsMax; r++)
            {
                for (int c = startCol; c < colsMax; c++)
                {
                    map[r, c] = rng.Next(100) < density;
                }
            }

            CountAliveCells();
        }

        public void Cycle()
        {
            AliveCells = 0;
            bool changed = false;

            for (int row = 0; row < WorldRows; row++)
            {
                for (int col = 0; col < WorldCols; col++)
                {
                    int aliveNeighbors = 0;

                    for (int neighborRow = -1; neighborRow <= 1; neighborRow++)
                    {
                        for (int neighborCol = -1; neighborCol <= 1; neighborCol++)
                        {
                            if (neighborRow != 0 || neighborCol != 0)
                            {
                                if (WrappedEdges)
                                {
                                    int wrappedRow = (row + neighborRow + WorldRows) % WorldRows;
                                    int wrappedCol = (col + neighborCol + WorldCols) % WorldCols;

                                    if (map[wrappedRow, wrappedCol]) ++aliveNeighbors;
                                }
                                else
                                {
                                    int unwrappedRow = row + neighborRow;
                                    int unwrappedCol = col + neighborCol;
                                    if (unwrappedRow < 0 || unwrappedRow >= WorldRows || unwrappedCol < 0 || unwrappedCol >= WorldCols) continue;
                                    if (map[unwrappedRow, unwrappedCol]) aliveNeighbors++;
                                }
                            }
                        }
                    }
                    if (map[row, col])
                    {
                        if (aliveNeighbors < 2 || aliveNeighbors > 3) mapNext[row, col] = false;
                        else
                        {
                            mapNext[row, col] = true;
                            AliveCells++;
                        }
                    }
                    else
                    {
                        if (aliveNeighbors == 3)
                        {
                            mapNext[row, col] = true;
                            AliveCells++;
                        }
                        else mapNext[row, col] = false;
                    }

                    if (map[row, col] != mapNext[row, col]) changed = true;
                }
            }

            bool[,] tmp = map;
            map = mapNext;
            mapNext = tmp;
            Generation++;
            Changed = changed;
        }

        private void CountAliveCells()
        {
            AliveCells = 0;

            for (int row = 0; row < WorldRows; row++)
            {
                for (int cell = 0; cell < WorldCols; cell++)
                {
                    if (map[row, cell]) AliveCells++;
                }
            }
        }

        public void Clear()
        {
            Generation = 0;
            AliveCells = 0;

            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    map[row, col] = false;
                }
            }
        }

        public void Resize(int newRows, int newCols)
        {
            map = new bool[newRows, newCols];
            mapNext = new bool[newRows, newCols];

            WorldRows = newRows;
            WorldCols = newCols;

            Generation = 0;
            AliveCells = 0;
        }

        public bool GetCell(int row, int col)
        {
            return map[row, col];
        }

        public void CellToggle(int row, int col)
        {
            if (row < 0 || row >= map.GetLength(0) || col < 0 || col >= map.GetLength(1)) return;

            if (map[row, col])
            {
                map[row, col] = false;
                AliveCells--;
            }
            else
            {
                map[row, col] = true;
                AliveCells++;
            }

            Changed = true;
        }

        public void WrappedEdgesToggle()
        {
            WrappedEdges = !WrappedEdges;
        }

        public void SetGeneration(int generation)
        {
            Generation = Math.Max(0, generation);
        }
    }
}
