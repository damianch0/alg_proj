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
}
