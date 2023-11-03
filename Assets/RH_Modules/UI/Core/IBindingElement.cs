namespace RH_Modules.UI.Core
{
    public interface IBindingElement
    {
        string Id { get; }
        void Setup(IBinding target);
    }
}