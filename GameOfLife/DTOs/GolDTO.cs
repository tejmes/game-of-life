using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.DTOs
{

    internal sealed class GolDTO
    {
        public int WorldRows { get; set; }
        public int WorldCols { get; set; }

        public int ViewStartRow { get; set; }
        public int ViewStartCol { get; set; }

        public int Generation { get; set; }
        public bool Wrapped { get; set; }

        public Appearance? Appearances { get; set; }
        internal sealed class Appearance
        {
            public int CellSizePx { get; set; }
            public int AliveCellColor { get; set; }
            public int GridColor { get; set; }
            public int BackgroundColor { get; set; }
            public bool GridOn { get; set; }
            public bool CenterOnResize { get; set; }
        }

        public List<string> Data { get; set; } = new();
    }
}
