using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Application.DTOs
{
    public sealed class GolDto
    {
        public int WorldRows { get; set; }
        public int WorldCols { get; set; }

        public int ViewStartRow { get; set; }
        public int ViewStartCol { get; set; }

        public int Generation { get; set; }
        public bool Wrapped { get; set; }

        public AppearanceDto? Appearance { get; set; }

        public List<string> Data { get; set; } = new();
    }
}
