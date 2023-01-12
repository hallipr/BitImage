using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ColorHelper;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private byte[] _bytes;
        private Color[] _colors;
        private int oldWidth; 
        private int oldScale;

        public Form1()
        {
            InitializeComponent();
            offsetSlider.ValueChanged += (_, _) => RedrawImage();
            widthSlider.ValueChanged += (_, _) => RedrawImage();
            scaleSlider.ValueChanged += (_, _) => RedrawImage();
            picture.MouseMove += HandleMouseMove;

            offsetLabel.Text = $"Offset: {offsetSlider.Value}";
            widthLabel.Text = $"Width: {widthSlider.Value}";
            scaleLabel.Text = $"Scale: {scaleSlider.Value}";

            oldWidth = widthSlider.Value;
            oldScale = scaleSlider.Value;
            _bytes = Array.Empty<byte>();
            _colors = BuildPalette();
        }

        private void HandleMouseMove(object? sender, MouseEventArgs e)
        {
            var scale = scaleSlider.Value;
            var scaledX = e.X / scale;
            var scaledY = e.Y / scale;

            var index = scaledY * widthSlider.Value + scaledX - offsetSlider.Value;
            if (index < 0 || index >= _bytes.Length)
            {
                toolTip.SetToolTip(picture, null);
                return;
            }
            
            var value = _bytes[index];
            toolTip.SetToolTip(picture, $"{value:X2} @ {index:X}");
        }

        private void RedrawImage()
        {
            if (_bytes == null || _bytes.Length == 0)
            {
                return;
            }

            var offset = offsetSlider.Value;
            var width = widthSlider.Value;
            var scale = scaleSlider.Value;

            offsetLabel.Text = $"Offset: {offset}";
            widthLabel.Text = $"Width: {width}";
            scaleLabel.Text = $"Scale: {scale}";

            var height = (int) Math.Ceiling((offset + _bytes.Length) / (double) width);

            var pixelCount = width * height;
            var tail = pixelCount - _bytes.Length - offset;

            var bytes = new byte[offset]
                .Concat(_bytes)
                .Concat(new byte[tail])
                .ToArray();

            var topLeftPixel = (int)Math.Round(-(double)picture.Top / oldScale * oldWidth);

            picturePanel.SuspendLayout();
            picture.Width = width * scale;
            picture.Height = height * scale;
            picture.Top = -topLeftPixel / width * scale;
            picture.Image = new Bitmap(picture.Width, picture.Height);

            using var graphics = Graphics.FromImage(picture.Image);

            for (var i = 0; i < bytes.Length; i++)
            {
                var x = i % width;
                var y = i / width;
                var color = _colors[bytes[i]];
                graphics.FillRectangle(new SolidBrush(color), x * scale, y * scale, scale, scale);
            }

            oldWidth = widthSlider.Value;
            oldScale = scaleSlider.Value;
            picturePanel.ResumeLayout(true);
        }

        private Color[] BuildPalette()
        {
            var random = new Random();
            var colors = Range(Color.Red, Color.Red, 255)
                .OrderBy(x => random.Next())
                .Skip(1)
                .Prepend(Color.White)
                .Append(Color.Black)
                .ToArray();

            return colors;
        }

        private static IEnumerable<Color> Range(Color firstColor, Color lastColor, int count)
        {
            var firstHsv = ColorHelper.ColorConverter.RgbToHsv(new RGB(firstColor.R, firstColor.G, firstColor.B));
            var lastHSv = ColorHelper.ColorConverter.RgbToHsv(new RGB(lastColor.R, lastColor.G, lastColor.B));

            return Range(firstHsv, lastHSv, count, Direction.Clockwise)
                .Select(ColorHelper.ColorConverter.HsvToRgb)
                .Select(x => Color.FromArgb(x.R, x.G, x.B));
        }

        private static IEnumerable<HSV> Range(
            HSV firstColor,
            HSV lastColor,
            int count,
            Direction hueDirection)
        {
            var color = firstColor;

            if (count <= 0)
                yield break;

            if (count == 1)
                yield return firstColor;

            float startingHue = color.H;
            var stepHue = GetStepping(firstColor.H, lastColor.H, count - 1, hueDirection);
            var stepSaturation = (lastColor.S - firstColor.S) / (count - 1);
            var stepBrightness = (lastColor.V - firstColor.V) / (count - 1);

            for (int i = 1; i < count; i++)
            {
                yield return color;

                var hue = (int)Math.Abs(startingHue + stepHue * i) % 360;

                color = new HSV(
                    hue,
                    (byte)(Clamp(color.S + stepSaturation, 0, 1) * 100),
                    (byte)(Clamp(color.V + stepBrightness, 0, 1) * 100));
            }

            yield return lastColor;
        }

        private enum Direction
        {
            Clockwise = 0,
            CounterClockwise = 1
        }

        private static float GetStepping(float start, float end, int count, Direction direction)
        {
            var hueDiff = end - start;

            switch (direction)
            {
                case Direction.CounterClockwise:
                    if (hueDiff >= 0)
                        hueDiff = (360 - hueDiff) * -1;
                    break;

                default:
                    if (hueDiff <= 0)
                        hueDiff = 360 + hueDiff;
                    break;
            }

            return hueDiff / count;
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min)
                return min;

            if (value > max)
                return max;

            return value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { Title = "Open file...", InitialDirectory = @"d:\castle", Filter = "All files (*.*)|*.*" };

            if (dialog.ShowDialog(this) == DialogResult.OK && File.Exists(dialog.FileName))
            {
                fileTextBox.Text = dialog.FileName;
                _bytes = File.ReadAllBytes(dialog.FileName);
            }

            RedrawImage();
        }

        private void colorsButton_Click(object sender, EventArgs e)
        {
            _colors = BuildPalette();
            RedrawImage();
        }
    }
}
