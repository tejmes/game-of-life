using GameOfLife.Domain;
using GameOfLife.WinForms.Dialogs;
using GameOfLife.WinForms.DTOs;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Text.Json;

namespace GameOfLife.WinForms
{
    public partial class GameOfLifeForm : Form
    {
        private readonly Game game = new Game();

        private Bitmap bmp;

        private int viewStartRow, viewStartCol;
        private int viewLengthRows, viewLengthCols;

        private int cellSizePx = 8;
        private int speed = 300;

        private bool gridOn = true;
        private bool centerOnResize = true;

        private bool isMoving = false;
        private Point movingStart;
        private int movingStartViewRow, movingStartViewCol;
        private int movingThresholdPx = 4;

        private Color aliveCellColor = Color.Green;
        private Color gridColor = Color.Black;
        private Color backgroundColor = Color.Black;

        public GameOfLifeForm()
        {
            InitializeComponent();
        }

        private void GameOfLifeForm_Load(object sender, EventArgs e)
        {
            CalculateViewport();
            viewStartRow = Math.Max(0, (game.WorldRows - viewLengthRows) / 2);
            viewStartCol = Math.Max(0, (game.WorldCols - viewLengthCols) / 2);

            bmp = new Bitmap(viewLengthCols * cellSizePx, viewLengthRows * cellSizePx);
            pictureBox.Image = bmp;

            RenderCycle();
        }

        private void RenderCycle()
        {
            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.Clear(backgroundColor);

                using (var aliveCellBrush = new SolidBrush(aliveCellColor))
                {
                    for (int r = 0; r < viewLengthRows; r++)
                    {
                        int y = r * cellSizePx;

                        for (int c = 0; c < viewLengthCols; c++)
                        {
                            if (!game.GetCell(viewStartRow + r, viewStartCol + c)) continue;

                            int x = c * cellSizePx;
                            graphics.FillRectangle(aliveCellBrush, x, y, cellSizePx, cellSizePx);
                        }
                    }
                }
                if (gridOn)
                {
                    using (var gridPen = new Pen(gridColor, 1))
                    {
                        int widthPx = viewLengthCols * cellSizePx;
                        int heightPx = viewLengthRows * cellSizePx;

                        for (int r = 0; r <= viewLengthRows; r++)
                        {
                            int y = r * cellSizePx;
                            graphics.DrawLine(gridPen, 0, y, widthPx, y);
                        }

                        for (int c = 0; c <= viewLengthCols; c++)
                        {
                            int x = c * cellSizePx;
                            graphics.DrawLine(gridPen, x, 0, x, heightPx);
                        }
                    }
                }
            }
            pictureBox.Invalidate();

            toolStripStatusLabelGeneration.Text = $"Generation: {game.Generation}";
            toolStripStatusLabelAliveCells.Text = $"Alive cells: {game.AliveCells}";
        }

        private void CalculateViewport()
        {
            viewLengthRows = pictureBox.ClientSize.Height / cellSizePx;
            viewLengthCols = pictureBox.ClientSize.Width / cellSizePx;

            viewLengthRows = Math.Max(1, Math.Min(viewLengthRows, game.WorldRows));
            viewLengthCols = Math.Max(1, Math.Min(viewLengthCols, game.WorldCols));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.Step();
            RenderCycle();

            if (!game.Changed) PauseSimulation();
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            int centerRow = viewStartRow + viewLengthRows / 2;
            int centerCol = viewStartCol + viewLengthCols / 2;

            CalculateViewport();

            if (centerOnResize)
            {
                viewStartRow = Math.Max(0, Math.Min(centerRow - viewLengthRows / 2, game.WorldRows - viewLengthRows));
                viewStartCol = Math.Max(0, Math.Min(centerCol - viewLengthCols / 2, game.WorldCols - viewLengthCols));
            }
            else
            {
                viewStartRow = Math.Max(0, Math.Min(viewStartRow, game.WorldRows - viewLengthRows));
                viewStartCol = Math.Max(0, Math.Min(viewStartCol, game.WorldCols - viewLengthCols));
            }

            bmp?.Dispose();
            bmp = new Bitmap(viewLengthCols * cellSizePx, viewLengthRows * cellSizePx);
            pictureBox.Image = bmp;

            RenderCycle();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartSimulation();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            PauseSimulation();
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {
            StepSimulation();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            movingStart = e.Location;
            movingStartViewRow = viewStartRow;
            movingStartViewCol = viewStartCol;
            isMoving = false;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            int distanceRowsPx = e.Y - movingStart.Y;
            int distanceColsPx = e.X - movingStart.X;

            if (!isMoving && (Math.Abs(distanceRowsPx) > movingThresholdPx || Math.Abs(distanceColsPx) > movingThresholdPx)) isMoving = true;

            if (!isMoving) return;

            int distanceRows = -distanceRowsPx / cellSizePx;
            int distanceCols = -distanceColsPx / cellSizePx;

            int newStartViewRow = movingStartViewRow + distanceRows;
            int newStartViewCol = movingStartViewCol + distanceCols;

            newStartViewRow = Math.Max(0, Math.Min(newStartViewRow, game.WorldRows - viewLengthRows));
            newStartViewCol = Math.Max(0, Math.Min(newStartViewCol, game.WorldCols - viewLengthCols));

            if (newStartViewRow != viewStartRow || newStartViewCol != viewStartCol)
            {
                viewStartRow = newStartViewRow;
                viewStartCol = newStartViewCol;

                RenderCycle();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            if (!isMoving)
            {
                int row = e.Y / cellSizePx;
                int col = e.X / cellSizePx;
                int rowWorld = viewStartRow + row;
                int colWorld = viewStartCol + col;

                game.CellToggle(rowWorld, colWorld);
                RenderCycle();
            }

            isMoving = false;
        }

        private void GameOfLifeForm_MouseWheel(object sender, MouseEventArgs e)
        {
            int steps = e.Delta / 120;
            Zoom(steps, e.Location);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartSimulation();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PauseSimulation();
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StepSimulation();
        }

        private void stepNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StepXSimulation();
        }

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeedSimulation();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearMap();
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResizeMap();
        }

        private void randomFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomFill();
        }

        private void wrappedEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WrappedEdgesToggle();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zoom(1);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zoom(-1);
        }

        private void defaultZoomtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomReset();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colors();
        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridToggle();
        }

        private void centerOnResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterOnResizeToggle();
        }

        private void Import()
        {
            PauseSimulation();

            using (var dialog = new OpenFileDialog
            {
                Filter = "JSON (*.json)|*.json"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string json = File.ReadAllText(dialog.FileName);
                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var payload = JsonSerializer.Deserialize<GolDTO>(json, options);

                        if (payload == null)
                        {
                            MessageBox.Show("Invalid file.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ImportFromPayload(payload);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Import failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ImportFromPayload(GolDTO payload)
        {
            bool needsResize = payload.WorldRows != game.WorldRows || payload.WorldCols != game.WorldCols;
            if (needsResize) game.Resize(payload.WorldRows, payload.WorldCols);
            else game.Clear();

            for (int r = 0; r < payload.WorldRows; r++)
            {
                string line = payload.Data[r];
                for (int c  = 0; c < payload.WorldCols; c++)
                {
                    if (line[c] == 'O') game.CellToggle(r, c);
                }
            }

            game.SetGeneration(payload.Generation);

            if (payload.Wrapped != game.WrappedEdges) game.WrappedEdgesToggle();

            if (payload.Appearances != null)
            {
                int newCellSizePx = Math.Max(2, Math.Min(32, payload.Appearances.CellSizePx));
                if (newCellSizePx != cellSizePx) cellSizePx = newCellSizePx;

                aliveCellColor = Color.FromArgb(payload.Appearances.AliveCellColor);
                gridColor = Color.FromArgb(payload.Appearances.GridColor);
                backgroundColor = Color.FromArgb(payload.Appearances.BackgroundColor);
                gridOn = payload.Appearances.GridOn;
                centerOnResize = payload.Appearances.CenterOnResize;
            }

            CalculateViewport();
            bmp?.Dispose();
            bmp = new Bitmap(viewLengthCols * cellSizePx, viewLengthRows * cellSizePx);
            pictureBox.Image = bmp;

            viewStartRow = Math.Max(0, Math.Min(payload.ViewStartRow, Math.Max(0, game.WorldRows - viewLengthRows)));
            viewStartCol = Math.Max(0, Math.Min(payload.ViewStartCol, Math.Max(0, game.WorldCols - viewLengthCols)));

            RenderCycle();
        }

        private void Export()
        {
            PauseSimulation();

            using (var dialog = new ExportDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    bool isEntire = dialog.EntireMap;

                    try
                    {
                        if (dialog.Image) ExportImage(isEntire);
                        else ExportState(isEntire);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Export failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportImage(bool isEntire)
        {
            if (!isEntire)
            {
                using (var dialog = new SaveFileDialog
                {
                    Filter = "PNG Image (*.png)|*.png"
                })
                {
                    if (dialog.ShowDialog() == DialogResult.OK) bmp.Save(dialog.FileName, ImageFormat.Png);
                }

                return;
            }

            int rows = game.WorldRows;
            int cols = game.WorldCols;
            int widthPx = cols * cellSizePx;
            int heightPx = rows * cellSizePx;

            using (var dialog = new SaveFileDialog
            {
                Filter = "PNG Image (*.png)|*.png"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (var exportBmp = new Bitmap(widthPx, heightPx, PixelFormat.Format24bppRgb))
                    using (var graphics = Graphics.FromImage(exportBmp))
                    using (var aliveBrush = new SolidBrush(aliveCellColor))
                    using (var gridPen = new Pen(gridColor, 1))
                    {
                        graphics.Clear(backgroundColor);

                        for (int r = 0; r < rows; r++)
                        {
                            int y = r * cellSizePx;
                            for (int c = 0; c < cols; c++)
                            {
                                if (!game.GetCell(r, c)) continue;
                                int x = c * cellSizePx;
                                graphics.FillRectangle(aliveBrush, x, y, cellSizePx, cellSizePx);
                            }
                        }

                        if (gridOn)
                        {
                            for (int r = 0; r <= rows; r++) graphics.DrawLine(gridPen, 0, r * cellSizePx, widthPx, r * cellSizePx);
                            for (int c = 0; c <= cols; c++) graphics.DrawLine(gridPen, c * cellSizePx, 0, c * cellSizePx, heightPx);
                        }

                        exportBmp.Save(dialog.FileName, ImageFormat.Png);
                    }
                }
            }
        }

        private void ExportState(bool isEntire)
        {
            int startRow = isEntire ? 0 : viewStartRow;
            int startCol = isEntire ? 0 : viewStartCol;
            int rows = isEntire ? game.WorldRows : viewLengthRows;
            int cols = isEntire ? game.WorldCols : viewLengthCols;

            var data = new List<string>(rows);
            var sb = new StringBuilder(cols);

            for (int r = 0; r < rows; r++)
            {
                sb.Clear();
                for (int c = 0; c < cols; c++) sb.Append(game.GetCell(startRow + r, startCol + c) ? 'O' : '.');
                data.Add(sb.ToString());
            }

            var payload = new
            {
                worldRows = rows,
                worldCols = cols,
                viewStartRow = isEntire ? viewStartRow : 0,
                viewStartCol = isEntire ? viewStartCol : 0,
                generation = game.Generation,
                wrapped = game.WrappedEdges,

                appearance = new
                {
                    cellSizePx = cellSizePx,
                    aliveCellColor = aliveCellColor.ToArgb(),
                    gridColor = gridColor.ToArgb(),
                    backgroundColor = backgroundColor.ToArgb(),
                    gridOn = gridOn,
                    centerOnResize = centerOnResize
                },

                data
            };

            string json = JsonSerializer.Serialize(payload, new JsonSerializerOptions { WriteIndented = true });

            using (var dialog = new SaveFileDialog
            {
                Filter = "JSON (*.json)|*.json"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK) File.WriteAllText(dialog.FileName, json, Encoding.UTF8);
            }
        }

        private void StartSimulation()
        {
            timer.Interval = speed;
            timer.Enabled = true;
        }

        private void PauseSimulation()
        {
            timer.Enabled = false;
        }

        private void StepSimulation()
        {
            PauseSimulation();
            game.Step();
            RenderCycle();
        }

        private void StepXSimulation()
        {
            PauseSimulation();

            using (var dialog = new StepNDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int steps = dialog.Steps;

                    for (int i = 0; i < steps; i++) game.Step();

                    RenderCycle();
                }
            }
        }

        private void SpeedSimulation()
        {
            using (var dialog = new SpeedDialog())
            {
                dialog.Speed = speed;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    speed = dialog.Speed;
                    timer.Interval = speed;
                }
            }
        }

        private void ClearMap()
        {
            var result = MessageBox.Show("Do you really want to clear the map?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                PauseSimulation();
                game.Clear();
                RenderCycle();
            }
        }

        private void ResizeMap()
        {
            using (var dialog = new ResizeDialog())
            {
                dialog.NewWidth = game.WorldCols;
                dialog.NewHeight = game.WorldRows;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PauseSimulation();

                    int width = dialog.NewWidth;
                    int height = dialog.NewHeight;

                    if (width == game.WorldCols && height == game.WorldRows) return;

                    var result = MessageBox.Show("All cells will be cleared!", "Confirm", MessageBoxButtons.OKCancel);
                    if (result != DialogResult.OK) return;

                    game.Resize(height, width);
                    CalculateViewport();

                    viewStartRow = Math.Max(0, Math.Min(viewStartRow, game.WorldRows - viewLengthRows));
                    viewStartCol = Math.Max(0, Math.Min(viewStartCol, game.WorldCols - viewLengthCols));

                    bmp?.Dispose();
                    bmp = new Bitmap(viewLengthCols * cellSizePx, viewLengthRows * cellSizePx);
                    pictureBox.Image = bmp;

                    RenderCycle();
                }
            }
        }

        private void RandomFill()
        {
            using (var dialog = new RandomFillDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PauseSimulation();

                    int density = dialog.Density;
                    int? seed = dialog.Seed;
                    bool isEntire = dialog.TargetEntireMap;

                    if (dialog.TargetEntireMap) game.RandomFill(density, seed, isEntire, 0, 0, game.WorldRows, game.WorldCols);
                    else game.RandomFill(density, seed, isEntire, viewStartRow, viewStartCol, viewLengthRows, viewLengthCols);

                    RenderCycle();
                }
            }
        }

        private void WrappedEdgesToggle()
        {
            game.WrappedEdgesToggle();
        }

        private void Zoom(int step, Point? focus = null)
        {
            int newCellSizePx = cellSizePx + step;
            if (newCellSizePx < 2 || newCellSizePx > 32) return;

            Point focusPoint = focus ?? new Point(pictureBox.ClientSize.Width / 2, pictureBox.ClientSize.Height / 2);

            int focusRowInView = focusPoint.Y / cellSizePx;
            int focusColInView = focusPoint.X / cellSizePx;

            int focusRowWorld = viewStartRow + focusRowInView;
            int focusColWorld = viewStartCol + focusColInView;

            cellSizePx = newCellSizePx;
            CalculateViewport();

            viewStartRow = focusRowWorld - (focusPoint.Y / cellSizePx);
            viewStartCol = focusColWorld - (focusPoint.X / cellSizePx);

            viewStartRow = Math.Max(0, Math.Min(viewStartRow, game.WorldRows - viewLengthRows));
            viewStartCol = Math.Max(0, Math.Min(viewStartCol, game.WorldCols - viewLengthCols));

            bmp?.Dispose();
            bmp = new Bitmap(viewLengthCols * cellSizePx, viewLengthRows * cellSizePx);
            pictureBox.Image = bmp;

            RenderCycle();
        }

        private void ZoomReset()
        {
            cellSizePx = 8;
            CalculateViewport();

            viewStartRow = Math.Max(0, (game.WorldRows - viewLengthRows) / 2);
            viewStartCol = Math.Max(0, (game.WorldCols - viewLengthCols) / 2);

            bmp?.Dispose();
            bmp = new Bitmap(viewLengthCols * cellSizePx, viewLengthRows * cellSizePx);
            pictureBox.Image = bmp;

            RenderCycle();
        }

        private void Colors()
        {
            using (var dialog = new ColorsDialog())
            {
                dialog.AliveCellColor = aliveCellColor;
                dialog.GridColor = gridColor;
                dialog.BackgroundColor = backgroundColor;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    aliveCellColor = dialog.AliveCellColor;
                    gridColor = dialog.GridColor;
                    backgroundColor = dialog.BackgroundColor;

                    RenderCycle();
                }
            }
        }

        private void GridToggle()
        {
            gridOn = !gridOn;
            RenderCycle();
        }

        private void CenterOnResizeToggle()
        {
            centerOnResize = !centerOnResize;
        }
    }
}
