namespace AlgProj;

public class Edge
{
    public Node Start { get; set; }
    public Node End { get; set; }

    public Edge(Node start, Node end)
    {
        Start = start;
        End = end;
    }

    public double Weight
    {
        get
        {
            return Helper.Distance(Start.DeliveryPoint.Point, End.DeliveryPoint.Point);
        }
    }
}
