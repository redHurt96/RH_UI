using System.Collections.Generic;

namespace RH_Modules.UI.Core
{
    internal class Model : IModel
    {
        public IEnumerable<IBinding> Bindings { get; }
        
        public Model(IEnumerable<IBinding> bindings) => 
            Bindings = bindings;
    }
}