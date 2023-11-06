using System;

namespace RH_Modules.UI.Core
{
    public class Binding<T> : IBinding
    {
        public event Action Updated;
        
        public string Id { get; }

        public T Value;

        public Binding(string id, T value)
        {
            Value = value;
            Id = id;
        }

        public void Change(object newValue)
        {
            T newTargetValue = (T)newValue;
            Value = newTargetValue;

            Updated?.Invoke();
        }
    }
}
