using System.Collections.Generic;

namespace RH_Modules.UI.Core
{
    public class ModelBuilder
    {
        private readonly List<IBinding> _bindings = new();

        public ModelBuilder With<T>(string id, T value)
        {
            _bindings.Add(new Binding<T>(id, value));

            return this;
        }

        public IModel Build() => 
            new Model(_bindings);
    }
}