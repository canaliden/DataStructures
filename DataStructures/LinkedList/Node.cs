namespace DataStructures.LinkedList
{
    public class Node<T>
    {
        public Node(T value)
        {
            Value = value;
        }

        public T Value { get; }

        public Node<T> NextNode { get; set; }

        /// <summary>
        /// May be overridden according to the data type
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Node<T>)
            {
                return this.Value.Equals(((Node<T>)obj).Value);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
