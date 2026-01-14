using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Application.DTOs
{
    public sealed class AppearanceDto
    {
        public int CellSizePx { get; set; }
        public int AliveCellColor { get; set; }
        public int GridColor { get; set; }
        public int BackgroundColor { get; set; }
        public bool GridOn { get; set; }
        public bool CenterOnResize { get; set; }
    }
}
