using System;

namespace MyDataStructures.Model.Graph
{
    public class GraphEdge<T>
    {
        public GraphVertex<T> From { get; set; }
        public GraphVertex<T> To { get; set; }
        public int Weight { get; set; }
        public GraphEdge(GraphVertex<T> from, GraphVertex<T> to, int weight = 1)
        {
            From = from ?? throw new ArgumentNullException(nameof(from));
            To = to ?? throw new ArgumentNullException(nameof(to));
            Weight = weight;
        }
        public override string ToString()
        {
            return $"({From.ToString()} - {To.ToString()}) : {Weight.ToString()}";
        }       
    }
}
