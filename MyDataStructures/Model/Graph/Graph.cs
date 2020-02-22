using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDataStructures.Model.Graph
{
    public class Graph<T>
    {
        private List<GraphVertex<T>> Vertexes { get; set; } = new List<GraphVertex<T>>();
        private List<GraphEdge<T>> Edges { get; set; } = new List<GraphEdge<T>>();
        public int VertexCount => Vertexes.Count;
        public int EdgeCount => Edges.Count;

        public Graph()
        {

        }

        public void Add(GraphEdge<T> edge)
        {
            if (edge == null)
            {
                throw new ArgumentNullException(nameof(edge));
            }
            Edges.Add(edge);
        }
        public void Add(List<GraphEdge<T>> edges)
        {
            if (edges == null)
            {
                throw new ArgumentNullException(nameof(edges));
            }
            Edges.AddRange(edges);
        }
        public void Add(GraphVertex<T> vertex)
        {
            if (vertex == null)
            {
                throw new ArgumentNullException(nameof(vertex));
            }
            Vertexes.Add(vertex);
        }
        public void Add(List<GraphVertex<T>> vertexs)
        {
            if (vertexs == null)
            {
                throw new ArgumentNullException(nameof(vertexs));
            }
            Vertexes.AddRange(vertexs);
        }
        public void Add(GraphVertex<T> vertex, GraphEdge<T> edge)
        {
            if (vertex == null)
            {
                throw new ArgumentNullException(nameof(vertex));
            }
            if (edge == null)
            {
                throw new ArgumentNullException(nameof(edge));
            }
            Vertexes.Add(vertex);
            Edges.Add(edge);
        }
        public void Add(GraphVertex<T> vertex, List<GraphEdge<T>> edges)
        {
            if (vertex == null)
            {
                throw new ArgumentNullException(nameof(vertex));
            }
            if (edges == null)
            {
                throw new ArgumentNullException(nameof(edges));
            }
            Vertexes.Add(vertex);
            Edges.AddRange(edges);
        }
        public void Add(List<GraphVertex<T>> vertexs, List<GraphEdge<T>> edges)
        {
            if (vertexs == null)
            {
                throw new ArgumentNullException(nameof(vertexs));
            }
            if (edges == null)
            {
                throw new ArgumentNullException(nameof(edges));
            }
            Vertexes.AddRange(vertexs);
            Edges.AddRange(edges);
        }
        public void Add(GraphVertex<T> vertex, GraphVertex<T> to, int weight = 1)
        {
            if (vertex == null)
            {
                throw new ArgumentNullException(nameof(vertex));
            }
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }
            Vertexes.Add(vertex);
            Edges.Add(new GraphEdge<T>(vertex, to, weight));
        }

        public int[,] GetMatrix()
        {
            int[,] matrix = new int[VertexCount, VertexCount];
            foreach (var edge in Edges)
            {
                matrix[edge.From.Number, edge.To.Number] = edge.Weight;
            }
            return matrix;
        }
        public List<GraphVertex<T>> GetVertexList(GraphVertex<T> vertex)
        {
            List<GraphVertex<T>> result = new List<GraphVertex<T>>();
            foreach (var edge in Edges)
            {
                if(edge.From.Equals(vertex))
                    result.Add(edge.To);
            }
            return result;
        }
        public bool Wave(GraphVertex<T> from, GraphVertex<T> to)
        {
            if (from == null)
            {
                throw new ArgumentNullException(nameof(from));
            }

            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            var list = new List<GraphVertex<T>>();
            list.Add(from);

            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];

                foreach (var item in GetVertexList(vertex))
                {
                    if (!list.Contains(item))
                    {
                        if (item.Equals(to))
                        {
                            return true;
                        }
                        list.Add(item);
                    }
                }
            }
            return false;
        }
    }
}
