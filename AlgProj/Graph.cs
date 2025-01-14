using System.Collections.Generic;

namespace AlgProj;

public class Graph
{
    public List<Node> Nodes { private set; get; } = new List<Node>();
    public List<Edge> Edges { private set; get; } = new List<Edge>();

    public Graph()
    {

    }

    public void AddEdge(Edge edge)
    {
        Edges.Add(edge);
        AddNode(edge.Start);
        AddNode(edge.End);
    }

    public void AddNode(Node node)
    {
        if (!Nodes.Contains(node)) Nodes.Add(node);
    }

    public int CountNewNodes(Edge e)
    {
        int i = 0;

        if (!Nodes.Contains(e.Start))
        {
            i++;
        }

        if (!Nodes.Contains(e.End))
        {
            i++;
        }

        return i;
    }

    public Graph Merge(Graph other)
    {
        var g = new Graph();
        g.Edges.AddRange(this.Edges);
        g.Edges.AddRange(other.Edges);
        return g;
    }

    public Graph Kruskal()
    {
        List<Graph> forest = new List<Graph>();
        var t = new Graph();
        var sortedEdges = new List<Edge>(Edges).OrderBy(x => x.Weight).ToList();

        while (sortedEdges.Any())
        {
            var low = sortedEdges.First();
            sortedEdges.Remove(low);

            var start = findSet(forest, low.Start);
            var end = findSet(forest, low.End);

            if (start == null && end == null)
            {
                var g = new Graph();
                g.AddEdge(low);
                forest.Add(g);
                t.AddEdge(low);
                continue;
            }

            // To samo drzewo
            if (start == end)
            {
                if (start.CountNewNodes(low) != 0)
                {
                    start.AddEdge(low);
                    t.AddEdge(low);
                }
            }
            else
            {
                if (start == null)
                {
                    if (end.CountNewNodes(low) != 0)
                    {
                        end.AddEdge(low);
                        t.AddEdge(low);
                    }
                }
                else if (end == null)
                {
                    if (start.CountNewNodes(low) != 0)
                    {
                        start.AddEdge(low);
                        t.AddEdge(low);
                    }
                }
                else
                {
                    var g = start.Merge(end);
                    forest.Remove(start);
                    forest.Remove(end);
                    forest.Add(g);
                    t.AddEdge(low);
                }
            }
        }

        return t;
    }

    private Graph? findSet(List<Graph> forest, Node node)
    {
        return forest.Where(x => x.Nodes.Contains(node)).FirstOrDefault();
    }
}
