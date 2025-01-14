namespace AlgProj;

static class Helper
{
    public static double Distance(Point point1, Point point2)
    {
        return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
    }

    public static int IntValue(this TextBox textBox)
    {
        return int.Parse(textBox.Text);
    }

    public static void DrawPoint(PictureBox pictureBox, int x, int y)
    {
        var graphics = pictureBox.CreateGraphics();
        var image = pictureBox.Image;
        graphics.Clear(Color.White);
        graphics.DrawImage(image, 0, 0);
        graphics.DrawPoint(x, y);
    }

    public static void DrawGraph(PictureBox pictureBox, Graph graph)
    {
        var graphics = pictureBox.CreateGraphics();
        var image = pictureBox.Image;
        graphics.Clear(Color.White);
        graphics.DrawImage(image, 0, 0);
        graphics.DrawGraph(graph);
    }

    public static void DrawPoint(this Graphics source, int x, int y)
    {
        source.DrawEllipse(Pens.Black, x - 5, y - 5, 10, 10);
    }

    public static void DrawLine(this Graphics source, int x1, int y1, int x2, int y2)
    {
        source.DrawLine(Pens.Black, x1, y1, x2, y2);
    }

    public static void DrawGraph(this Graphics source, Graph graph)
    {
        // draw nodes
        graph.Nodes.ForEach(n => { source.DrawPoint((int)n.DeliveryPoint.Point.X, (int)n.DeliveryPoint.Point.Y); });

        // draw edges
        graph.Edges.ForEach(e =>
        {
            var start = e.Start.DeliveryPoint.Point;
            var end = e.End.DeliveryPoint.Point;
            source.DrawLine((int)start.X, (int)start.Y, (int)end.X, (int)end.Y);
        });
    }
}
