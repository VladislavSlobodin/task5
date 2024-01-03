namespace task5;

public partial class Form1 : Form
{
    private readonly List<Point> _points = [];

    public Form1()
    {
        InitializeComponent();
        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
    }

    private void AddNodeButton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(XTextBox.Text, out var x) || x < 0 ||
            !int.TryParse(YTextBox.Text, out var y) || y < 0)
        {
            return;
        }

        _points.Add(new(x, y));
        NodesTextBox.Text += $"X: {x}; Y: {y}{Environment.NewLine}";
        XTextBox.Text = YTextBox.Text = string.Empty;
    }

    private void DrawNodes_Click(object sender, EventArgs e)
    {
        var bitmap = (Bitmap)pictureBox1.Image;
        using (var graphics = Graphics.FromImage(bitmap))
        {
            graphics.DrawLines(Pens.Black, _points.Append(_points.First()).ToArray());
        }

        pictureBox1.Image = bitmap;
    }

    private void ClearImageButton_Click(object sender, EventArgs e)
    {
        var bitmap = (Bitmap)pictureBox1.Image;
        using (var graphics = Graphics.FromImage(bitmap))
        {
            graphics.Clear(Color.White);
        }

        pictureBox1.Image = bitmap;
    }

    private void ClearNodeListButton_Click(object sender, EventArgs e)
    {
        _points.Clear();
        NodesTextBox.Clear();
    }
}
