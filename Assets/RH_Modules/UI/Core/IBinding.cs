using System;

namespace RH_Modules.UI.Core
{
    public interface IBinding
    {
        event Action Updated; 
        string Id { get; }
        void Change(object newValue);
    }
}