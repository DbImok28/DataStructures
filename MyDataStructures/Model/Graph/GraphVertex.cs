namespace MyDataStructures.Model.Graph
{
    public class GraphVertex<T>
    {
        public T Data { get; set; }
        public int Number { get; private set; }

        public GraphVertex(int number)
        {
            Number = number;
        }
        public GraphVertex(int number, T data) : this(number)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}
