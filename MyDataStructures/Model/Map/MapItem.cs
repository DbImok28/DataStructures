namespace MyDataStructures.Model.Map
{
    public class MapItem<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public MapItem(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is MapItem<TKey, TValue> ? ((MapItem<TKey, TValue>)obj).Key.Equals(Key) && ((MapItem<TKey, TValue>)obj).Value.Equals(Value) : false;
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
