namespace RH_Modules.UI.Core
{
    public class Binding<T> : IBinding
    {
        public string Id { get; }
        public T Value;

        public Binding(string id, T value)
        {
            Value = value;
            Id = id;
        }
    }
}
