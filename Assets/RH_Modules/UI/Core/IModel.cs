using System.Collections.Generic;

namespace RH_Modules.UI.Core
{
    public interface IModel
    {
        IEnumerable<IBinding> Bindings { get; }
        void Change<T>(string id, T newValue);
    }
}