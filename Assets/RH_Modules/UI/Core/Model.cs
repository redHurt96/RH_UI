using System.Collections.Generic;
using System.Linq;

namespace RH_Modules.UI.Core
{
    internal class Model : IModel
    {
        public IEnumerable<IBinding> Bindings { get; }

        public Model(IEnumerable<IBinding> bindings) => 
            Bindings = bindings;

        public void Change<T>(string id, T newValue)
        {
            IBinding target = Bindings.FirstOrDefault(x => x.Id == id);
            
            if (target == null)
                throw new($"Change error: there is no binding with id {id}");
            
            target.Change(newValue);
        }
    }
}